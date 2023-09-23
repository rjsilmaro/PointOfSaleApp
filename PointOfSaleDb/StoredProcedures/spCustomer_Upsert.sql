CREATE PROCEDURE [dbo].[spCustomer_Upsert]
	@CustomerId int output,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Email nvarchar(50)
AS
BEGIN

	if exists (select 1 from Customer where Email = @Email)
		begin
			update Customer
			set FirstName = @FirstName, LastName = @LastName
			where Email = @Email;

			select @CustomerId = Id from Customer where Email = @Email;
		end
	else
		begin
			insert into Customer (FirstName, LastName, Email)
			values (@FirstName, @LastName, @Email);

			select @CustomerId = SCOPE_IDENTITY();
		end
END
