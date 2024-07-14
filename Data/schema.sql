
CREATE TABLE [User] (
    id int NOT NULL IDENTITY(1,1),
    username varchar(100) NOT NULL,
    password varchar(300) NOT NULL,
    managerId int NULL,
    CONSTRAINT User_Manager FOREIGN KEY (managerId) REFERENCES [Manager] (id),
    CONSTRAINT User_pk PRIMARY KEY (id)
);


CREATE TABLE [Manager] (
    id int NOT NULL IDENTITY(1,1),
    userId int NOT NULL,
    CONSTRAINT Manager_pk PRIMARY KEY (id, userId),
    CONSTRAINT Manager_User FOREIGN KEY (userId) REFERENCES [User] (id)
);



CREATE TABLE SharedTask (
    userId int NOT NULL,
    Task_id int NOT NULL,
    CONSTRAINT SharedTask_pk PRIMARY KEY (userId, Task_id),
    CONSTRAINT SharedTask_User FOREIGN KEY (userId) REFERENCES [User] (id),
    CONSTRAINT SharedTask_Task FOREIGN KEY (Task_id) REFERENCES TaskTodo (id)
);

CREATE TABLE [Priority] (
    id int NOT NULL IDENTITY(1,1),
    name varchar(100) NOT NULL,
    CONSTRAINT Priority_pk PRIMARY KEY (id)
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
    CONSTRAINT Task_Priority FOREIGN KEY (priorityId) REFERENCES Priority (id),
);


INSERT INTO Priority (name) VALUES ('Low');
INSERT INTO Priority (name) VALUES ('Medium');
INSERT INTO Priority (name) VALUES ('High');