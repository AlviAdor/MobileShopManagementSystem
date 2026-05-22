-- Admin (no EmployeeID)
INSERT INTO Login (Username, Password, Role, UserID)
VALUES 
('alvi', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 'Admin', NULL);

-- Employees
INSERT INTO Login (Username, Password, Role, UserID)
VALUES 
('ridita', '2a66147c65070341fc8cbd34cb0429d4cbd650964b6700c637725ad901c00255', 'Employee', 101),
('nova',   '0f4c06f3191d881bbd456a6db165810aa578f6d65c31b6581f2ce4ac7b70d8a3', 'Employee', 100),
('orne',   'f0cf4b2a88f1e62eec4439b1b7014de92fd91d524dc2e68f98bdf3f2cfa10a55', 'Employee', 102);