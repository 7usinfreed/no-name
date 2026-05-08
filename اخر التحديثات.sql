use mang
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
leader_id INT NOT NULL REFERENCES members(m_id) ON DELETE CASCADE  --قائد الفريق
);
-- 3. المشاريع
CREATE TABLE projects (
project_id INT PRIMARY KEY IDENTITY(1,1),
project_name NVARCHAR(100) NOT NULL,
description NVARCHAR(MAX),
status NVARCHAR(20) NOT NULL DEFAULT 'Planning'
    CHECK (status IN ('Planning', 'Active', 'Completed')),
start_date DATE,
deadline_date DATE,
team_id INT REFERENCES teams(tm_id) not null -- كل مشروع لفريق واحد
);
-- 4. ربط الأعضاء بالمشاريع (M:N)
CREATE TABLE project_members (
project_id INT REFERENCES projects(project_id) ON DELETE CASCADE not null,
m_id INT REFERENCES members(m_id) ON DELETE CASCADE,
role_name NVARCHAR(50) not null,  -- دور العضو في هذا المشروع
PRIMARY KEY (project_id, m_id)
);
-- 5. المهام
CREATE TABLE tasks (
tk_id INT PRIMARY KEY IDENTITY(1,1),
tk_name NVARCHAR(100) NOT NULL,
description NVARCHAR(MAX),
status NVARCHAR(20) NOT NULL DEFAULT 'Planning'
    CHECK (status IN ('Planning', 'Active', 'Completed')),
project_id INT REFERENCES projects(project_id) not null,
assigned_to INT REFERENCES members(m_id) not null  -- العضو المسؤول
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
-- ربط project_members.role_name مع roles
ALTER TABLE project_members 
ADD CONSTRAINT FK_project_members_role 
FOREIGN KEY (role_name) REFERENCES roles(role_name);

CREATE VIEW vw_simple_dashboard AS
SELECT 
    p.project_name,
    p.status,
    t.tm_name,
    COUNT(pm.m_id) as members_count,  -- 
    COUNT(ts.tk_id) as tasks_count
FROM projects p
JOIN teams t ON p.team_id = t.tm_id
LEFT JOIN project_members pm ON p.project_id = pm.project_id  -- 
LEFT JOIN tasks ts ON p.project_id = ts.project_id
GROUP BY p.project_name, p.status, t.tm_name;
