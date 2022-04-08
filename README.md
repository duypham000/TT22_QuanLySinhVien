# TT22_QuanLySinhVien
mở App.config ra, tìm đến dòng:
```
<connectionStrings>
	 <add name="QuanLySinhVienDbContext" connectionString="data source=.;initial catalog=QuanLySinhVien;persist security info=True;user id=sa;password=05082002;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />
</connectionStrings>
```
thay 05082002 bằng mật khẩu của sa
nếu vẫn lỗi thì thay 
```
data source=.\SQLEXPRESS
```
