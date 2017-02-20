CREATE PROCEDURE dbo.Login
	@username NVARCHAR(254),
	@password NVARCHAR(50),
	@errorMessage NVARCHAR(250) = '' OUTPUT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @userID INT
	IF EXISTS (SELECT TOP 1 UserID FROM [dbo].[tblStudent] WHERE Username = @username)
	BEGIN
		SET @userID = (SELECT UserID FROM [dbo].[tblStudent] WHERE Username = @username
		AND PasswordHash = HASHBYTES('SHA2_512', @password + CAST(Salt AS NVARCHAR(36))))

		IF(@userID IS NULL)
			SET @errorMessage = 'Incorrect password'
		ELSE
			SET @errorMessage = 'Student logged in successfully'
		END
	ELSE
		SET @errorMessage = 'Invalid username'
END