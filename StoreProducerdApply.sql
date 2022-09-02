use Northwind 
go

CREATE PROC Cau6 @TenSP nvarchar (40), @MaLSP int, @TrangThai int output
as
	BEGIn
		Begin Try
			insert into Products(ProductName, CategoryID)
			Values (@TenSP, @MaLSP)
			if @@ROWCOUNT>0
				Set @TrangThai=1
		End Try

		Begin Catch
			Set @TrangThai=1;
			Throw 50002,'Loi he thong',1
		End Catch
	End
return

exec Cau6 @tenSP = N'Lua',@MaLSP = 7, @TrangThai=0
print @TrangThai


use jobdb
go
Create Proc CreateApply @Description nvarchar(200), @PostID int, @UserID int, @Cv nvarchar(200), @TrangThai int output
as
Begin
	declare @dem int
	set @dem = -1
	select @dem = count(*) 
	from jobdb.jobdb.jobs_apply as a
	where a.post_id = @PostID and
			a.user_id = @UserID
	if @dem > 0 
		begin
			set @TrangThai = 0
		end
	if @dem <= 0
		begin
			Begin Try
				insert into jobdb.jobdb.jobs_apply( active,created_date,updated_date,description, post_id, user_id, CV)
				values (1, GETDATE(),GETDATE() ,@Description, @PostID, @UserID, @Cv)
				if @@ROWCOUNT>0
					Set @TrangThai=1
			End Try
			Begin Catch
				Set @TrangThai=0;
				Throw 50002,'Loi he thong',1
			End Catch
		end
End
return @TrangThai
go
declare @create int
exec CreateApply N'Nguyễn Long Nhật TEst',  24, 9, 'uploadCV', @create output
print @create

print @TrangThai

insert into jobdb.jobdb.jobs_apply( active,created_date,updated_date,description, post_id, user_id, CV)
				values (1, GETDATE(),GETDATE() ,'xin chao', 33, 12, 'CV')