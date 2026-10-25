CREATE DATABASE DBHocSinh;
GO

USE DBHocSinh;
GO

CREATE TABLE Lop
(
    MaLop VARCHAR(10) PRIMARY KEY,
    TenLop NVARCHAR(50),
    SiSo SMALLINT
);

CREATE TABLE HocSinh
(
    MaHS VARCHAR(10) PRIMARY KEY,
    MaLop VARCHAR(10),
    TenHS NVARCHAR(100),
    NgaySinh DATE,
    FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
);
GO
USE DBHocSinh;
GO

SELECT * FROM Lop;
SELECT * FROM HocSinh;

USE DBHocSinh;
GO

INSERT INTO Lop (MaLop, TenLop, SiSo)
VALUES
('10A1', N'Lớp 10A1', 30),
('10A2', N'Lớp 10A2', 25),
('10A3', N'Lớp 10A3', 22);
GO

INSERT INTO HocSinh (MaHS, MaLop, TenHS, NgaySinh)
VALUES
('HS01', '10A1', N'Nguyễn Văn An', '2009-01-15'),
('HS02', '10A1', N'Trần Thị Bình', '2009-03-20'),
('HS03', '10A2', N'Lê Minh Anh', '2009-05-10');
GO

USE DBHocSinh;
GO

SELECT * FROM Lop;
SELECT * FROM HocSinh;

USE DBHocSinh;
GO

SELECT HS.MaHS, HS.TenHS, L.TenLop
FROM HocSinh AS HS
JOIN Lop AS L
    ON HS.MaLop = L.MaLop;