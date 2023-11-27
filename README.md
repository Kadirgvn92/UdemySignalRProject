# UdemySignalRProject

Hello everyone I started my new project about Restaurant and I want to code it along with .NET also approach with
MVC(Model-View-Controller).

Herkese merhaba Yeni bir projeyle karþýnýzdayým,bu proje Restorant ile ilgili olacak ve projeyi MVC yaklaþýmý ile 
.NET C# kullanarak yazacaðým. Frontend'te ise HTML,CSS,Bootstrap kullanacaðým.

Bu projede N katmanlý mimari ile inþa edeceðiz. Projemde 4 katman bulunmakta;

- EntityLayer -> Bu katmanda Entityler tanýmlanacak CodeFirst - Migration yaklaþýmý ile EntityFramework kullanarak 
database oluþturacaðým.
- DataAccessLayer -> Bu katmanda Repository Design Pattern ile database CRUD(Create, Read, Update, Delete) iþlemleri 
için altyapý hazýrlayacaðým. 
- BussinessLayer -> Bu katmanda validasyonlarýn kontrolü olacak.
- WebAPI -> baðlantýlarýmý web apý ile yapacaðým.

Ders-2;

- TraversalCore olarak ASP.NET MVC projemi yarattým, 
- EntityLayer, DataAccessLayer ve BussinessLayer olarak Class Library'lerimi oluþturdum.
- Tüm projelerime teker teker aþaðýda belirttiðim NuGet paketlerimi yükledim.
	- Microsoft.EntityFrameworkCore
	- Microsoft.EntityFrameworkCore.Design
	- Microsoft.EntityFrameworkCore.SqlServer
	- Microsoft.EntityFrameworkCore.Tools

Ders-3/4/5/6;

- BussinessLayer -> Add -> Project Reference yaparak DataAccessLayer ve EntityLayer tanýmladým.
- DataAccessLayer -> Add -> Project Reference yaparak EntityLayer tanýmladým.
- EntityLayer libraryde Concrete Folder içine Tablolarým için sýnýflarýmý oluþturdum ve propertylerimi yazdým.

Ders-7;

- DataAccesssLayer libraryde Concrete folder içine DbContext baðlantýsý için methodumu oluþturdum ve COntext 
class'ýmý oluþturdum.

Ders-8;

- Bu iþlemden sonra NuGet Manage Package Console üzerinden Add-Migration mig1 olarak migration iþlemini yaptým.
- Add-Migration baþarýlý olduktan sonra Update-Database iþlemi yaptým bir hata verdi daha sonra hatayý çözdükten 
sonra iþlemi gerçekleþtirdim.
- Aldýðým hata veritabaný sertifika hatasý verdi ConnectionStringte bazý deðiþiklikler yapýp baðlantýnýn güvenli 
olduðunu ConnectionString içine yazdýktan sonra 
hata giderildi.

Ders-9/10;

- Abstract folder içine IGuideDal olarak sýnýfýmý oluþtrup Crud methodlarýmý yazdým.
- DataAccessLayer projemde Abstract classlarda her bir entity class'ýn içine Crud iþlemleri için metotlar yazmam
gerekiyor ancak hepsine teker teker Crud operasyonlarý yazmak yerine IGenericDal olarak bütünü kapsayan bir 
yapýyý kullanýyorum. Bu IGenericDal interface'ini herbir entity class'ý için girip inherit yaparak kullanýyorum.
- DataAccessLayer projemde daha sonra Repository folder içine Generic class oluþturup Crud iþlemleri için az
önce yaptýðýmýz gibi inherit edilebilecek kodlarýmýzý yazdým.
