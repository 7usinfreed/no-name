create database Mangment
-- 1. الأعضاء
CREATE TABLE members (
    m_id INT PRIMARY KEY IDENTITY(1,1),
    m_name NVARCHAR(50) NOT NULL,
    email NVARCHAR(50) UNIQUE NOT NULL
);

-- 2. الفرق (تعديل: جعل القائد اختياري عند الحذف لمنع انهيار البيانات)
CREATE TABLE teams (
    tm_id INT PRIMARY KEY IDENTITY(1,1),
    tm_name NVARCHAR(50) NOT NULL,
    leader_id INT NULL REFERENCES members(m_id) ON DELETE SET NULL 
);

-- 3. المشاريع
CREATE TABLE projects (
    project_id INT PRIMARY KEY IDENTITY(1,1),
    project_name NVARCHAR(50) NOT NULL,
    description NVARCHAR(MAX),
    status NVARCHAR(20) NOT NULL DEFAULT 'Planning'
        CHECK (status IN ('Planning', 'Active', 'Completed')),
    start_date DATE,
    deadline_date DATE,
    team_id INT REFERENCES teams(tm_id) NOT NULL
);

-- 4. الأدوار العامة
CREATE TABLE roles (
    role_name NVARCHAR(50) PRIMARY KEY,
    description NVARCHAR(250)
);

-- 5. ربط الأعضاء بالمشاريع
CREATE TABLE project_members (
    project_id INT REFERENCES projects(project_id) ON DELETE CASCADE NOT NULL,
    m_id INT REFERENCES members(m_id) ON DELETE CASCADE NOT NULL,
    role_name NVARCHAR(50) REFERENCES roles(role_name), 
    PRIMARY KEY (project_id, m_id)
);

-- 6. المهام
CREATE TABLE tasks (
    tk_id INT PRIMARY KEY IDENTITY(1,1),
    tk_name NVARCHAR(50) NOT NULL,
    description NVARCHAR(MAX),
    status NVARCHAR(20) NOT NULL DEFAULT 'Planning'
        CHECK (status IN ('Planning', 'Active', 'Completed')),
	task_start DATE,
    task_end DATE,
    project_id INT REFERENCES projects(project_id) NOT NULL,
    assigned_to INT REFERENCES members(m_id) NOT NULL
);
-- 7. تتبع تغييرات حالة المهام
CREATE TABLE task_status_tracking (
    tracking_id INT PRIMARY KEY IDENTITY(1,1),
    tk_id INT REFERENCES tasks(tk_id) ON DELETE CASCADE, -- إذا حذفت المهمة يحذف تاريخها
    old_status NVARCHAR(20),
    new_status NVARCHAR(20) NOT NULL,
    changed_at DATETIME DEFAULT GETDATE(),
    changed_by INT REFERENCES members(m_id) ON DELETE SET NULL -- إذا حذفت العضو يبقى السجل موجوداً
);
-- إضافة عمود المستوى كـ رقم (Integer)
-- القيمة الافتراضية (DEFAULT 1) تعني أنه لو لم ترسل قيمة من سي شارب، سيتم تخزين 1 تلقائياً
ALTER TABLE tasks 
ADD tk_level INT CONSTRAINT DF_TaskLevel DEFAULT 1;

CREATE VIEW vw_simple_dashboard AS
SELECT 
    p.project_name,
    p.status,
    t.tm_name,
    COUNT(DISTINCT pm.m_id) as members_count, -- حساب الأعضاء الفريدين
    COUNT(DISTINCT ts.tk_id) as tasks_count    -- حساب المهام الفريدة
FROM projects p
JOIN teams t ON p.team_id = t.tm_id
LEFT JOIN project_members pm ON p.project_id = pm.project_id
LEFT JOIN tasks ts ON p.project_id = ts.project_id
GROUP BY p.project_id, p.project_name, p.status, t.tm_name;

Create VIEW vw_level_dashboard AS--يحسب عدد المهام والمستويات
SELECT 
    p.project_name,
    p.status,
    t.tm_name,
    COUNT(DISTINCT pm.m_id) as members_count,
    COUNT(DISTINCT ts.tk_id) as tasks_count,
    -- هنا سيظهر لك متوسط مستويات المهام أو أعلى مستوى في المشروع
    MAX(ts.tk_level) as max_priority_level 
FROM projects p
JOIN teams t ON p.team_id = t.tm_id
LEFT JOIN project_members pm ON p.project_id = pm.project_id
LEFT JOIN tasks ts ON p.project_id = ts.project_id
GROUP BY p.project_id, p.project_name, p.status, t.tm_name;