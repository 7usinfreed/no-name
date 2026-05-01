-- 1. الأعضاء
CREATE TABLE members (
m_id INT PRIMARY KEY IDENTITY(1,1),
m_name NVARCHAR(100) NOT NULL,
email NVARCHAR(100) UNIQUE NOT NULL
);
-- 2. الفرق
CREATE TABLE teams (
tm_id INT PRIMARY KEY IDENTITY(1,1),
tm_name NVARCHAR(100) NOT NULL,
leader_id INT REFERENCES members(m_id) -- قائد الفريق
);
-- 3. المشاريع
CREATE TABLE projects (
project_id INT PRIMARY KEY IDENTITY(1,1),
project_name NVARCHAR(100) NOT NULL,
description NVARCHAR(MAX),
start_date DATE,
deadline_date DATE,
team_id INT REFERENCES teams(tm_id) -- كل مشروع لفريق واحد
);
-- 4. ربط الأعضاء بالمشاريع (M:N)
CREATE TABLE project_members (
project_id INT REFERENCES projects(project_id) ON DELETE CASCADE,
m_id INT REFERENCES members(m_id) ON DELETE CASCADE,
role_name NVARCHAR(50),  -- دور العضو في هذا المشروع
PRIMARY KEY (project_id, m_id)
);
-- 5. المهام
CREATE TABLE tasks (
tk_id INT PRIMARY KEY IDENTITY(1,1),
tk_name NVARCHAR(100) NOT NULL,
description NVARCHAR(MAX),
status NVARCHAR(20) DEFAULT 'Pending', -- Pending, InProgress, Done
project_id INT REFERENCES projects(project_id),
assigned_to INT REFERENCES members(m_id)  -- العضو المسؤول
);
-- 6. تتبع تغييرات حالة المهام
CREATE TABLE task_status_tracking (
tracking_id INT PRIMARY KEY IDENTITY(1,1),
tk_id INT REFERENCES tasks(tk_id) ON DELETE CASCADE,
old_status NVARCHAR(20),
new_status NVARCHAR(20) NOT NULL,
changed_at DATETIME DEFAULT GETDATE(),
changed_by INT REFERENCES members(m_id)
);
-- 7. الأدوار العامة (اختياري)
CREATE TABLE roles (
role_name NVARCHAR(50) PRIMARY KEY,
description NVARCHAR(255)
);

CREATE VIEW [dbo].[link]
AS
SELECT dbo.members.m_id, dbo.teams.tm_id, dbo.tasks.tk_id, dbo.projects.project_id, dbo.project_members.project_id AS Expr1, dbo.project_members.m_id AS Expr2, dbo.roles.role_name, dbo.task_status_tracking.tracking_id
FROM     dbo.members INNER JOIN
                  dbo.teams ON dbo.members.m_id = dbo.teams.leader_id INNER JOIN
                  dbo.projects ON dbo.teams.tm_id = dbo.projects.team_id INNER JOIN
                  dbo.project_members ON dbo.members.m_id = dbo.project_members.m_id AND dbo.projects.project_id = dbo.project_members.project_id INNER JOIN
                  dbo.tasks ON dbo.members.m_id = dbo.tasks.assigned_to AND dbo.projects.project_id = dbo.tasks.project_id INNER JOIN
                  dbo.task_status_tracking ON dbo.members.m_id = dbo.task_status_tracking.changed_by AND dbo.tasks.tk_id = dbo.task_status_tracking.tk_id INNER JOIN
                  dbo.roles ON dbo.project_members.role_name = dbo.roles.role_name
GO