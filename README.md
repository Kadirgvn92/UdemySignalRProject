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
- DataAccessLayer k�sm�nda bulunan EntityFramework klas�r�n�n i�ine teker teker Ef...Dal olarak classlar�m� 
olu�turdum ve GenericRepositoryden miras ald�m.
- Abstract folder i�ine IGuideDal olarak s�n�f�m� olu�trup Crud methodlar�m� yazd�m.
- DataAccessLayer projemde Abstract classlarda her bir entity class'�n i�ine Crud i�lemleri i�in metotlar yazmam
gerekiyor ancak hepsine teker teker Crud operasyonlar� yazmak yerine IGenericDal olarak b�t�n� kapsayan bir 
yap�y� kullan�yorum. Bu IGenericDal interface'ini herbir entity class'� i�in girip inherit yaparak kullan�yorum.
- DataAccessLayer projemde daha sonra Repository folder i�ine Generic class olu�turup Crud i�lemleri i�in az
�nce yapt���m�z gibi inherit edilebilecek kodlar�m�z� yazd�m.

Ders-11;
- BusinesslLayer i�indeki Manager s�n�flar�n� teker teker olu�turduk ve impelemnt i�lemini ger�ekle�tirdik.
(t�m Entityler i�in) 

Ders-14-15;
- Data Transfer Object dedi�imiz DTO katman�n� ekledik. T�m entityler i�in Result..Dto, Create..Dto, Update..Dto, 
Get...Dto olarak dto classlar�m�z� olu�turduk. DTO nedir diye sorarsak 

DTO : Herhangi bir davarn��� olmayan ve uygulaman�n �e�itli yerlerinde yaln�zca bir veri t�ketimi ve iletimi
i�in kullan�lan, veritaban�ndaki herhangi bir verinin transfer nesnesidir/kar��l���d�r/g�r�n�m�d�r.

Ders-16 ;
- AutoMapper Nuget paketlerini webpap� projemize y�kledik hem automapper hemde dependency mod�l�n� daha sonra
Ap� projemize mapping folder a�arak her bir entity i�in mapping class mapleme methodalar�n� olu�turduk.

Ders-17;
- Controller classlar�m�z� olu�turmaya ba�lad�k. Ap�n�n i�ine her bir entity i�in contorller olu�tuduk.

Ders-18;
- Controller classlar�m�z� olu�turduk ve ap�lerimizi test ettik.

Ders-19;
- Booking ap� olu�turup kontrol ettik.

Ders-20-23;
- Di�er entity ap�lerimizi olu�turduk controller i�ine ve test ettik.

Ders-24;
- Category ve product aras�nda veriler aras�nda entity framwork �zerinden bire �ok ili�kisi olu�truduk ve 
tekrardan migration i�lemi yapt�k. 

Ders-25-26;
- Product ve category aras�ndaki ili�kiye �zg� metot yazd�k.

Ders-27;
- Layout haz�rlama k�sm�na geldik ve bir template indirip wwwroot i�ine att�k