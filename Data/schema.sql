
-- tables
-- Table: Manager
CREATE TABLE Manager (
    id int  NOT NULL,
    userId int  NOT NULL,
    CONSTRAINT Manager_pk PRIMARY KEY  (id,userId)
);

-- Table: Priority
CREATE TABLE Priority (
    id int  NOT NULL,
    name varchar(100)  NOT NULL,
    CONSTRAINT Priority_pk PRIMARY KEY  (id)
);

-- Table: Status
CREATE TABLE Status (
    id int  NOT NULL,
    name varchar(100)  NOT NULL,
    CONSTRAINT Status_pk PRIMARY KEY  (id)
);

-- Table: Task
CREATE TABLE Task (
    id int  NOT NULL,
    title varchar(100)  NOT NULL,
    description text  NOT NULL,
    createdAt datetime  NOT NULL,
    updatedAt datetime  NOT NULL,
    userId int  NOT NULL,
    priorityId int  NOT NULL,
    statusId int  NOT NULL,
    CONSTRAINT Task_pk PRIMARY KEY  (id)
);

-- Table: User
CREATE TABLE "User" (
    id int  NOT NULL,
    username varchar(100)  NOT NULL,
    password varchar(300)  NOT NULL,
    CONSTRAINT User_pk PRIMARY KEY  (id)
);

-- foreign keys
-- Reference: Manager_User (table: Manager)
ALTER TABLE Manager ADD CONSTRAINT Manager_User
    FOREIGN KEY (userId)
    REFERENCES "User" (id);

-- Reference: Task_Priority (table: Task)
ALTER TABLE Task ADD CONSTRAINT Task_Priority
    FOREIGN KEY (priorityId)
    REFERENCES Priority (id);

-- Reference: Task_Status (table: Task)
ALTER TABLE Task ADD CONSTRAINT Task_Status
    FOREIGN KEY (statusId)
    REFERENCES Status (id);

-- Reference: Task_User (table: Task)
ALTER TABLE Task ADD CONSTRAINT Task_User
    FOREIGN KEY (userId)
    REFERENCES "User" (id);

-- End of file.

-- Inserts for Status table
INSERT INTO Status (id, name) VALUES (1, 'New');
INSERT INTO Status (id, name) VALUES (2, 'In Progress');
INSERT INTO Status (id, name) VALUES (3, 'Completed');
INSERT INTO Status (id, name) VALUES (4, 'On Hold');
INSERT INTO Status (id, name) VALUES (5, 'Cancelled');

-- Inserts for Priority table
INSERT INTO Priority (id, name) VALUES (1, 'Low');
INSERT INTO Priority (id, name) VALUES (2, 'Medium');
INSERT INTO Priority (id, name) VALUES (3, 'High');
INSERT INTO Priority (id, name) VALUES (4, 'Urgent');
INSERT INTO Priority (id, name) VALUES (5, 'Critical');

-- Example inserts for User table
INSERT INTO "User" (id, username, password) VALUES (1, 'john_smith', 'hashed_password_1');
INSERT INTO "User" (id, username, password) VALUES (2, 'emma_johnson', 'hashed_password_2');
INSERT INTO "User" (id, username, password) VALUES (3, 'michael_brown', 'hashed_password_3');

-- Example inserts for Manager table
INSERT INTO Manager (id, userId) VALUES (1, 1);
INSERT INTO Manager (id, userId) VALUES (2, 3);

-- Example inserts for Task table
INSERT INTO Task (id, title, description, createdAt, updatedAt, userId, priorityId, statusId)
VALUES (1, 'Prepare Report', 'Prepare monthly sales report', '2024-07-08 10:00:00', '2024-07-08 10:00:00', 2, 2, 1);

INSERT INTO Task (id, title, description, createdAt, updatedAt, userId, priorityId, statusId)
VALUES (2, 'Software Update', 'Update operating system on all computers', '2024-07-08 11:30:00', '2024-07-08 14:15:00', 3, 3, 2);

INSERT INTO Task (id, title, description, createdAt, updatedAt, userId, priorityId, statusId)
VALUES (3, 'Client Meeting', 'Prepare presentation and meet with client XYZ', '2024-07-09 09:00:00', '2024-07-09 09:00:00', 1, 4, 1);