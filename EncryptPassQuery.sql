ALTER TABLE dbo.[ExamDB].[tblStudent] ADD Salt UNIQUEIDENTIFIER
GO

ALTER PROCEDURE dbo.uspChangePass
	@username NVARCHAR(50),
	@password NVARCHAR(50),
	@forename NVARCHAR(40) = NULL,
	@surname NVARCHAR(40) = NULL,
	@message NVARCHAR(250) OUTPUT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @salt UNIQUEIDENTIFIER = NEWID()
	BEGIN TRY
		INSERT INTO dbo.[tblStudent](PasswordHash, Salt) 
		VALUES(HASHBYTES('SHA2_512', @password + CAST(@salt AS NVARCHAR(36))), @salt)

		SET @message = 'Success'
	END TRY
	BEGIN CATCH
		SET @message = ERROR_MESSAGE()
	END CATCH
END