# SİMPRA_HOMEWORK3

## Projeyi çalıştırmak için:
1. SimpraHomewroks.Apı -> appsettings.json -> MsSQL tanımlamasındaki ‘Server’ bilgisini kendiMsSQL server adı ile değiştiriniz. 
2. Package Manager Console -> Default Project -> SimpraHomework.Repository seçilir. 
3. Add-migration v1.1 veya EntityFramework6\Add-Migration initial komutu girilerek migration oluşturulur. 
4. Update-database komutu ile MsSQL’de ‘SimraHomework3Db’ ve tablolar oluşturulur.

![alt text](https://i.ibb.co/GFZ3N13/Connection.png)

## Proje detay ve içerikleri: 
1. Projenin Database’i  MsSQL kullanılılarak geliştirildi.
2. Projenin backend’i ‘Web API’ projesi olup, NLayer Architecture yapısına uygun olarak dizayn edildi.

![alt text](https://i.ibb.co/mN5sNVV/NLayer.jpg)

4. RESTAPI PRINCIPLES VE CRUD Operations kullanıldı. 
   Category Controller:
   
![alt text](https://i.ibb.co/CwT6WgV/Catgory-Controller.jpg)
   
   Product Controller:
   
![alt text](https://i.ibb.co/Yd3dHbN/Product-Controller.jpg)
   
6. Generic Repository Design Pattern ve Unit of Work Design Pattern uygulandı.
7. Fluent  Validation ve AutoMapper kullanıldı.
8. CustomResponse ve Middleware kullanıldı.
9. SOLID Prensipleri.
10. Include ile Category'si aynı olan Productlar listelendi 

![alt text](https://i.ibb.co/jH9T6dS/Includefor-Category.jpg)

11.Include ile Productlar categoryleri ile listelendi ve 2 tane Where sorgusu kullanıldı.
    
![alt text](https://i.ibb.co/S5sxk6m/Includefor-Product.jpg)
    
        
## Kullanılan Teknolojiler: 
1. IDE : Visual Studio 2022 
2. DB: MsSQL Languages: C#, 
3. Frameworks: .NET 6, ASP.NetCore, EntityFramework6, EFCore/SqlServer/, DependencyInjection Abstractions 
  
