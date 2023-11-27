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


Ders-11;

- Daha sonra DataAccessLayer projemde EntityFramework folder i�ine EF..Dal olarak class'lar�m�z� yaz�p 
Repository folder i�inde olu�turdu�umuz Generic class�m�z� ve I..Dal interfaci inherit yapt�k.

Ders-12;

- BusinessLayer projemde Concrete folder i�ine AboutManager yaz�p crud operasyonlar�n� yazd�k 
- Daha sonra Abstract folder i�ine IGenericService ad� alt�nda yine �ablon olarak kullanabilee�imiz Crud
operasyonlar� yazd�k ve bu folder i�ine di�er entitylerimizi I....Service olarak yaz�p IGenericService 
inherit ettik.
- Bu projede dependency �njection uygulamal� g�rd�m AboutManager class'�na IAboutService inherit ettikten sonra 
IAboutDal _aboutDal olarak field olu�turduktan sonra AboutManager constructor olu�turup IAboutDal aboutDal 
parametresi verdikten sonra i�ine _aboutDal = aboutDal; yazarak dependency Injection yapm�� oluyoruz.

Ders-13;

- BusinessLayer projeme FluentValidation ve ASP.NETCore NuGet package y�kledik.
- Daha sonra BusinessLayer projeme ValidationRules olarak folder a�t�m sonra AboutValidator olarak class olu�turduktan 
sonra i�ine AbstractValidator class�n� inherit ettim ki bu class Validator'den gelmekte sonra baz� methodlar yazarak
validasyonlar� s�n�rlamaya �al��t�m.
- Controller k�sm�na gelerek bir tane DefaultController olu�turduk
- View k�sm�na bir tane default view ekledik.

Ders-14;

- Daha sonra W3 Template sitesinden Travel Agency ile ilgili bir projeyi indirip wwwroot k�sm�na att�k 
- O projeye ait Index sayfas�ndaki Layout'u Shared k�sm�ndas yeni bir Layout a�arak buraya kopyalad�k ve js. 
dosya yollar�n� klas�r�m�zdeki js yolunu verdik. 
- Daha sonra Default k�sm�ndaki Index sayfas�na renderbody yaparak main sectionlar� buraya att�k 
 

Ders-15;
- di�er kalan header, footer, navbar, script dosyalar�n� partial olarak viewlara kaydettik ki Shared �zerindeki
Layout �zerinde daha rahat �al��al�m diye.
- TraversalCore projesine yeni bir folder ekliyoruz "ViewComponents" olarak ve Default olarak tekrar klas�r a��yoruz
- i�ine  "_SliderPartial.cs"  koyarak slider par�as�n� buraya koyuyoru bu �ekilde ad�m ad�m di�er 
b�l�mleride par�alayarak daha kullan��l� bir yap� elde edece�iz 

Ders-16;
- Daha sonra Destination tablosuna giderek seed i�lemini sql �zerinde yap�yoruz.
- Di�er index k�sm�ndaki par�alar i�in yani sectionlar i�in yine ViewComponents folder i�ine Default folder i�ine
s�ras�yla _PopularDestinations, _Statistics ve _Feature classlar� ekledik. Bunlar�n ba�lant�s�n� i�ine girerek
hem Businesslayer taraf�yla inherit ettik hemde EfFeatureDal olarak newledik.
- View par�alama i�lemlerinin en sonu olarak Testimonial k�sm�n� �st sat�rda yap�lan i�lemleri yaparak ay�rd�ktan 
sonra cshtml k�sm�nda gerekli kodlar� yazarak foreach d�ng�s�yle veritaban�m�zda yaratt���m�z seed datalar� 
sitemize getirmi� olduk

Ders-17;

- Destination Default sayfas�na veritbana�na girdi�imiz de�erleri foreach kulllanarak razor sayfam�za ekledik.
- Statictic sayfas�n�da olu�turduk mainden par�alayarak layout olarak 
- FeatureManager olu�turduk ve Feature sayfas�n� par�alayarak layout olarak ald�k.

Ders-18;
- Feature Database k�sm�na seed verilerimizi yazd�k ve denemelerini yapt�k
- Viewbag olarak db'den ald���m�z verleri sayfam�za aktard�k.
- ViewComponente subabout ve testimonial k�s�mlar�n� ekleyerek onlar�da par�alad�k

Ders-19;
- Testimonail manager ekleyip kodlar�m� yaz�p Testimonail veritaban�nda olu�turdu�um seed datay� sayfama 
aktard�m. 
- Footer k�sm�n�da d�zenledim. 

Ders-20;
- Sayfan�n �cretli tam halini indirip proejmi yeni tasla�a g�re haz�rlad�m.

Ders-21;
- �cretli tam tasla��n� revize etmeye devam ettim. ve DestintionDetails k�s�mda detaylar� yazd�m

Ders-22;
- DestinationDetails k�sm�na devam ettim, destination Ef class'�ma birka� s�tun ekleyip tekrar migration i�lemi
yapt�m. Manager k�sm�ndan GetByID methodunu ekledik crud i�lemlerin alt�na b�ylece �d ile destination bulup
i�lem yapabilece�iz
- Destination cshtml k�sm�n� veritabtan�ndan veri �ekerek foreach ile view sayfam�za entegre ettik b�ylece
veritaban�na girilen turlar bu sayfada otomatik ��kacak

Ders-23;
- Comment k�sm�n� yapmaya ba�lad�m. �lk �nce entitiy k�sm�ndan bir tablo yapmak i�in comment class olu�turdum
de�erlerini i�ine yazd�m ve destination k�s�mlar�nda kullanaca��m i�in des. class i�ine de comment ba�lant�s� yapt�m
ayn� �ekilde comment class i�ine destination s�tunu olu�turarak des. ba�lant�s�n� yapt�m.
- DAL k�sm�ndan contextten comment tablomu ekledim.
- Son de�i�iklikleri yapt�ktan sonra comment i�in migration i�lemini yapt�m.
- COmment seed i�lemlerini sql �zerinden yapt�m ve view k�sm�nda comment verileini sayfaya yans�tmak i�in model ve 
foreach kulland�m.

Ders-24;
- Comment i�lemlerine devam ettim. CommentManager ile crud i�lemleri kapsam�nda inherit yapt�ktan sonra filterleme i�lemi
i�in metot yazd�m.

Ders-25;
- Comment i�lemlerine devam ettim. Comment i�lemlerini iki k�s�ma b�ld�m;AddComment ve CommentList olarak.

Ders-26;
- Comment i�lemlerine devam ettim. Razor k�s�mlar�n� par�alayarak veritaban�ndan yorumar� getirmek i�in html tag ve 
view component kulland�m.

Ders-27;
- Identity i�lemlerine ba�lad�m. �lk olarak NuGet package, Asp.Net Core Identity ve EntityFramework.Identity 
paketlerini mvc, dal ve entity k�t�phanelerime indirdim. .Net s�r�mleri olan 7.0.13 kulland�m umar�m bir s�k�nt� 
ya�anmaz paket s�r�mleri ile ilgili.
- Identity kapsam�nda AppUser temelinde s�n�flar�m� olu�truup tekrar migration i�lemi yapt�m ve userrole olarak 
seed i�lemlerini sql taraf�nda yapt�m.

Ders-28;
- �ndirdi�imiz �ablon web sitesinde login ve register k�s�mlar� olmad���ndan ba�ka yerden login ve authorization
i�lemleri i�in 2 adet �ablon indirdim ve bunlar� i�lemlerime entegre ettim.
- Bu arada identity k�s�mlar�n� indirip migration yapt���m�z i�in identity ile ilgili identity benim vermedi�im
san�r�m best practice olarak birka� tablo daha eklemi� onun �st�nden devam edece�im.

Ders-29;
- Authorization ayarlar�n� yapmak maksad�yla Program.cs te baz� metotlar yazd�m. Model folder i�ine UserRegister
ile ilgili bir s�n�f olu�turdum ve girilen bilgileri validasyon i�lemlerini yazd�m.
- LOginController s�n�f�n� olu�turup crud i�lemleri ve di�er authorization i�lemleri i�in kodlar�m� yazd�m.

Ders-30/31;
- Authorization kapsam�nda SignIn ve SignOut sayfalar�m�z�n ayarlar�n� yapt�k. Authorization ayarlar�n� tekrar 
program.cs �zerinden g�ncelledik password i�in ve CustomIdentityValidator class olu�turup password ayarlar�n� 
IdentityErrorDescriber inherit ederek yapt�k.