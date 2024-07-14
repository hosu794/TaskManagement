
DROP TABLE IF EXISTS SharedTask;
DROP TABLE IF EXISTS [TaskTodo];


IF EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = 'User_Manager')
BEGIN
    ALTER TABLE [User] DROP CONSTRAINT User_Manager;
END

DROP TABLE IF EXISTS [User];
DROP TABLE IF EXISTS [Manager];

DROP TABLE IF EXISTS [Priority];

GO; 

DROP PROCEDURE IF EXISTS [GetTaskStatisticsByManager];

CREATE TABLE [Priority] (
    id int NOT NULL IDENTITY(1,1),
    name varchar(100) NOT NULL,
    CONSTRAINT Priority_pk PRIMARY KEY (id)
);

CREATE TABLE [User] (
    id int NOT NULL IDENTITY(1,1),
    username varchar(100) NOT NULL,
    password varchar(300) NOT NULL,
    managerId int NULL,
    CONSTRAINT User_pk PRIMARY KEY (id)
);

CREATE TABLE [Manager] (
    userId int NOT NULL,
    CONSTRAINT Manager_pk PRIMARY KEY (userId),
    CONSTRAINT Manager_User FOREIGN KEY (userId) REFERENCES [User] (id)
);


CREATE TABLE [TaskTodo] (
    id int NOT NULL IDENTITY(1,1),
    title varchar(100) NOT NULL,
    description text NOT NULL,
    createdAt datetime NOT NULL,
    updatedAt datetime NOT NULL,
    userId int NOT NULL,
    priorityId int NOT NULL,
    CONSTRAINT Task_pk PRIMARY KEY (id),
    CONSTRAINT Task_User FOREIGN KEY (userId) REFERENCES [User] (id),
    CONSTRAINT Task_Priority FOREIGN KEY (priorityId) REFERENCES Priority (id)
);

CREATE TABLE SharedTask (
    userId int NOT NULL,
    Task_id int NOT NULL,
    CONSTRAINT SharedTask_pk PRIMARY KEY (userId, Task_id),
    CONSTRAINT SharedTask_User FOREIGN KEY (userId) REFERENCES [User] (id),
    CONSTRAINT SharedTask_Task FOREIGN KEY (Task_id) REFERENCES TaskTodo (id)
);

INSERT INTO Priority (name) VALUES ('Low');
INSERT INTO Priority (name) VALUES ('Medium');
INSERT INTO Priority (name) VALUES ('High');

GO;

CREATE PROCEDURE GetTaskStatisticsByManager
    @ManagerId INT
AS
BEGIN
    SELECT 
        u.Id AS UserId,
        u.Username,
        DATEPART(YEAR, t.CreatedAt) AS Year,
        DATEPART(MONTH, t.CreatedAt) AS Month,
        COUNT(*) AS TaskCount
    FROM 
        [User] u
    INNER JOIN 
        TaskTodo t ON u.Id = t.UserId
    WHERE 
        u.ManagerId = @ManagerId
    GROUP BY 
        u.Id, u.Username, DATEPART(YEAR, t.CreatedAt), DATEPART(MONTH, t.CreatedAt)
    ORDER BY 
        u.Username, Year, Month
END