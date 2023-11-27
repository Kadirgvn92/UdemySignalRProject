# UdemySignalRProject

Hello everyone I started my new project about Restaurant and I want to code it along with .NET also approach with
MVC(Model-View-Controller).

Herkese merhaba Yeni bir projeyle kar��n�zday�m,bu proje Restorant ile ilgili olacak ve projeyi MVC yakla��m� ile 
.NET C# kullanarak yazaca��m. Frontend'te ise HTML,CSS,Bootstrap kullanaca��m.

Bu projede N katmanl� mimari ile in�a edece�iz. Projemde 4 katman bulunmakta;

- EntityLayer -> Bu katmanda Entityler tan�mlanacak CodeFirst - Migration yakla��m� ile EntityFramework kullanarak 
database olu�turaca��m.
- DataAccessLayer -> Bu katmanda Repository Design Pattern ile database CRUD(Create, Read, Update, Delete) i�lemleri 
i�in altyap� haz�rlayaca��m. 
- BussinessLayer -> Bu katmanda validasyonlar�n kontrol� olacak.
- WebAPI -> ba�lant�lar�m� web ap� ile yapaca��m.

Ders-2;

- TraversalCore olarak ASP.NET MVC projemi yaratt�m, 
- EntityLayer, DataAccessLayer ve BussinessLayer olarak Class Library'lerimi olu�turdum.
- T�m projelerime teker teker a�a��da belirtti�im NuGet paketlerimi y�kledim.
	- Microsoft.EntityFrameworkCore
	- Microsoft.EntityFrameworkCore.Design
	- Microsoft.EntityFrameworkCore.SqlServer
	- Microsoft.EntityFrameworkCore.Tools

Ders-3/4/5/6;

- BussinessLayer -> Add -> Project Reference yaparak DataAccessLayer ve EntityLayer tan�mlad�m.
- DataAccessLayer -> Add -> Project Reference yaparak EntityLayer tan�mlad�m.
- EntityLayer libraryde Concrete Folder i�ine Tablolar�m i�in s�n�flar�m� olu�turdum ve propertylerimi yazd�m.

Ders-7;

- DataAccesssLayer libraryde Concrete folder i�ine DbContext ba�lant�s� i�in methodumu olu�turdum ve COntext 
class'�m� olu�turdum.

Ders-8;

- Bu i�lemden sonra NuGet Manage Package Console �zerinden Add-Migration mig1 olarak migration i�lemini yapt�m.
- Add-Migration ba�ar�l� olduktan sonra Update-Database i�lemi yapt�m bir hata verdi daha sonra hatay� ��zd�kten 
sonra i�lemi ger�ekle�tirdim.
- Ald���m hata veritaban� sertifika hatas� verdi ConnectionStringte baz� de�i�iklikler yap�p ba�lant�n�n g�venli 
oldu�unu ConnectionString i�ine yazd�ktan sonra 
hata giderildi.

Ders-9/10;

- Abstract folder i�ine IGuideDal olarak s�n�f�m� olu�trup Crud methodlar�m� yazd�m.
- DataAccessLayer projemde Abstract classlarda her bir entity class'�n i�ine Crud i�lemleri i�in metotlar yazmam
gerekiyor ancak hepsine teker teker Crud operasyonlar� yazmak yerine IGenericDal olarak b�t�n� kapsayan bir 
yap�y� kullan�yorum. Bu IGenericDal interface'ini herbir entity class'� i�in girip inherit yaparak kullan�yorum.
- DataAccessLayer projemde daha sonra Repository folder i�ine Generic class olu�turup Crud i�lemleri i�in az
�nce yapt���m�z gibi inherit edilebilecek kodlar�m�z� yazd�m.
