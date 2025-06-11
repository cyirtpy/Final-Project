CREATE TABLE [dbo].[Basic] (
    [書名]      NVARCHAR(MAX)        NOT NULL,
    [英文書名]    NVARCHAR(MAX) NULL,
    [開頭字母]    NCHAR (1) NULL,
    [作者]      NVARCHAR(MAX) NULL,
    [出版社]     NVARCHAR(MAX) NULL,
    [出版日期(年)] INT NULL,
    [出版日期(月)] INT NULL,
    [出版日期(日)] INT NULL,
    [ISBN]    NCHAR (13) NULL,
    PRIMARY KEY CLUSTERED ([書名] ASC)
);

