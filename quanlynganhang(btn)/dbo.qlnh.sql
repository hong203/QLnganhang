CREATE TABLE [dbo].[qlnh]
(
	[Id] INT  IDENTITY (1, 1) NOT NULL PRIMARY KEY, 
    [Tentaikhoan] NVARCHAR(50) NULL, 
    [Sotaikhoan] INT NULL, 
    [Matkhau] NVARCHAR(50) NULL, 
    [Diachiemail] NVARCHAR(50) NULL, 
    [Gioitinh] BIT NULL, 
    [Socccd] INT NULL, 
    [Sodienthoai] INT NULL, 
    [Ngaysinh] DATE NULL, 
    [Quoctich] NVARCHAR(50) NULL
)
