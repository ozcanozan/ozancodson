# ozancod

App.config içerisindeki veritabanı bilgileri değiştirilmelidir.

<connectionStrings>
        <add name="WindowsFormsApp1.Properties.Settings.Stok_TakipConnectionString"
            connectionString="Data Source=xxx\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True"
            providerName="System.Data.SqlClient" />
  </connectionStrings>
    
ara depo güncelleme eksik
tarihler otomatik gelecek

makinelere kurarken bir veritabanı kurulacak diğer makineden buraya erişim var mı telnet makine ipsi 1433 portu

ya da udl uzaltılı dosya oluştur connectionstringteki ayarları ver dene

ozan.sql çalıştırırken burdaki filenameleri değiştir (ozanergen directorysini bulamaz:))

( NAME = N'Stok_Takip', FILENAME = N'C:\ozanergen\sql\Stok_Takip.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Stok_Takip_log', FILENAME = N'C:\ozanergen\sql\Stok_Takip_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )

    
