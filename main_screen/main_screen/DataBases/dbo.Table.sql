CREATE TABLE [dbo].[Table]
(
	[mail_id] INT NOT NULL PRIMARY KEY, 
    [user_id_send] NCHAR(10) NULL, 
    [user_id_get] NCHAR(10) NULL, 
    [date_time] NCHAR(10) NULL, 
    [msg_txt] NTEXT NULL
)
