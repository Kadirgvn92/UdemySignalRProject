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


Ders-11;

- Daha sonra DataAccessLayer projemde EntityFramework folder içine EF..Dal olarak class'larýmýzý yazýp 
Repository folder içinde oluþturduðumuz Generic classýmýzý ve I..Dal interfaci inherit yaptýk.

Ders-12;

- BusinessLayer projemde Concrete folder içine AboutManager yazýp crud operasyonlarýný yazdýk 
- Daha sonra Abstract folder içine IGenericService adý altýnda yine þablon olarak kullanabileeðimiz Crud
operasyonlarý yazdýk ve bu folder içine diðer entitylerimizi I....Service olarak yazýp IGenericService 
inherit ettik.
- Bu projede dependency ýnjection uygulamalý gördüm AboutManager class'ýna IAboutService inherit ettikten sonra 
IAboutDal _aboutDal olarak field oluþturduktan sonra AboutManager constructor oluþturup IAboutDal aboutDal 
parametresi verdikten sonra içine _aboutDal = aboutDal; yazarak dependency Injection yapmýþ oluyoruz.

Ders-13;

- BusinessLayer projeme FluentValidation ve ASP.NETCore NuGet package yükledik.
- Daha sonra BusinessLayer projeme ValidationRules olarak folder açtým sonra AboutValidator olarak class oluþturduktan 
sonra içine AbstractValidator classýný inherit ettim ki bu class Validator'den gelmekte sonra bazý methodlar yazarak
validasyonlarý sýnýrlamaya çalýþtým.
- Controller kýsmýna gelerek bir tane DefaultController oluþturduk
- View kýsmýna bir tane default view ekledik.

Ders-14;

- Daha sonra W3 Template sitesinden Travel Agency ile ilgili bir projeyi indirip wwwroot kýsmýna attýk 
- O projeye ait Index sayfasýndaki Layout'u Shared kýsmýndas yeni bir Layout açarak buraya kopyaladýk ve js. 
dosya yollarýný klasörümüzdeki js yolunu verdik. 
- Daha sonra Default kýsmýndaki Index sayfasýna renderbody yaparak main sectionlarý buraya attýk 
 

Ders-15;
- diðer kalan header, footer, navbar, script dosyalarýný partial olarak viewlara kaydettik ki Shared üzerindeki
Layout üzerinde daha rahat çalýþalým diye.
- TraversalCore projesine yeni bir folder ekliyoruz "ViewComponents" olarak ve Default olarak tekrar klasör açýyoruz
- içine  "_SliderPartial.cs"  koyarak slider parçasýný buraya koyuyoru bu þekilde adým adým diðer 
bölümleride parçalayarak daha kullanýþlý bir yapý elde edeceðiz 

Ders-16;
- Daha sonra Destination tablosuna giderek seed iþlemini sql üzerinde yapýyoruz.
- Diðer index kýsmýndaki parçalar için yani sectionlar için yine ViewComponents folder içine Default folder içine
sýrasýyla _PopularDestinations, _Statistics ve _Feature classlarý ekledik. Bunlarýn baðlantýsýný içine girerek
hem Businesslayer tarafýyla inherit ettik hemde EfFeatureDal olarak newledik.
- View parçalama iþlemlerinin en sonu olarak Testimonial kýsmýný üst satýrda yapýlan iþlemleri yaparak ayýrdýktan 
sonra cshtml kýsmýnda gerekli kodlarý yazarak foreach döngüsüyle veritabanýmýzda yarattýðýmýz seed datalarý 
sitemize getirmiþ olduk

Ders-17;

- Destination Default sayfasýna veritbanaýna girdiðimiz deðerleri foreach kulllanarak razor sayfamýza ekledik.
- Statictic sayfasýnýda oluþturduk mainden parçalayarak layout olarak 
- FeatureManager oluþturduk ve Feature sayfasýný parçalayarak layout olarak aldýk.

Ders-18;
- Feature Database kýsmýna seed verilerimizi yazdýk ve denemelerini yaptýk
- Viewbag olarak db'den aldýðýmýz verleri sayfamýza aktardýk.
- ViewComponente subabout ve testimonial kýsýmlarýný ekleyerek onlarýda parçaladýk

Ders-19;
- Testimonail manager ekleyip kodlarýmý yazýp Testimonail veritabanýnda oluþturduðum seed datayý sayfama 
aktardým. 
- Footer kýsmýnýda düzenledim. 

Ders-20;
- Sayfanýn ücretli tam halini indirip proejmi yeni taslaða göre hazýrladým.

Ders-21;
- Ücretli tam taslaðýný revize etmeye devam ettim. ve DestintionDetails kýsýmda detaylarý yazdým

Ders-22;
- DestinationDetails kýsmýna devam ettim, destination Ef class'ýma birkaç sütun ekleyip tekrar migration iþlemi
yaptým. Manager kýsmýndan GetByID methodunu ekledik crud iþlemlerin altýna böylece ýd ile destination bulup
iþlem yapabileceðiz
- Destination cshtml kýsmýný veritabtanýndan veri çekerek foreach ile view sayfamýza entegre ettik böylece
veritabanýna girilen turlar bu sayfada otomatik çýkacak

Ders-23;
- Comment kýsmýný yapmaya baþladým. Ýlk önce entitiy kýsmýndan bir tablo yapmak için comment class oluþturdum
deðerlerini içine yazdým ve destination kýsýmlarýnda kullanacaðým için des. class içine de comment baðlantýsý yaptým
ayný þekilde comment class içine destination sütunu oluþturarak des. baðlantýsýný yaptým.
- DAL kýsmýndan contextten comment tablomu ekledim.
- Son deðiþiklikleri yaptýktan sonra comment için migration iþlemini yaptým.
- COmment seed iþlemlerini sql üzerinden yaptým ve view kýsmýnda comment verileini sayfaya yansýtmak için model ve 
foreach kullandým.

Ders-24;
- Comment iþlemlerine devam ettim. CommentManager ile crud iþlemleri kapsamýnda inherit yaptýktan sonra filterleme iþlemi
için metot yazdým.

Ders-25;
- Comment iþlemlerine devam ettim. Comment iþlemlerini iki kýsýma böldüm;AddComment ve CommentList olarak.

Ders-26;
- Comment iþlemlerine devam ettim. Razor kýsýmlarýný parçalayarak veritabanýndan yorumarý getirmek için html tag ve 
view component kullandým.

Ders-27;
- Identity iþlemlerine baþladým. Ýlk olarak NuGet package, Asp.Net Core Identity ve EntityFramework.Identity 
paketlerini mvc, dal ve entity kütüphanelerime indirdim. .Net sürümleri olan 7.0.13 kullandým umarým bir sýkýntý 
yaþanmaz paket sürümleri ile ilgili.
- Identity kapsamýnda AppUser temelinde sýnýflarýmý oluþtruup tekrar migration iþlemi yaptým ve userrole olarak 
seed iþlemlerini sql tarafýnda yaptým.

Ders-28;
- Ýndirdiðimiz þablon web sitesinde login ve register kýsýmlarý olmadýðýndan baþka yerden login ve authorization
iþlemleri için 2 adet þablon indirdim ve bunlarý iþlemlerime entegre ettim.
- Bu arada identity kýsýmlarýný indirip migration yaptýðýmýz için identity ile ilgili identity benim vermediðim
sanýrým best practice olarak birkaç tablo daha eklemiþ onun üstünden devam edeceðim.

Ders-29;
- Authorization ayarlarýný yapmak maksadýyla Program.cs te bazý metotlar yazdým. Model folder içine UserRegister
ile ilgili bir sýnýf oluþturdum ve girilen bilgileri validasyon iþlemlerini yazdým.
- LOginController sýnýfýný oluþturup crud iþlemleri ve diðer authorization iþlemleri için kodlarýmý yazdým.

Ders-30/31;
- Authorization kapsamýnda SignIn ve SignOut sayfalarýmýzýn ayarlarýný yaptýk. Authorization ayarlarýný tekrar 
program.cs üzerinden güncelledik password için ve CustomIdentityValidator class oluþturup password ayarlarýný 
IdentityErrorDescriber inherit ederek yaptýk.