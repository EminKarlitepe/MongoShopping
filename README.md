# 🛍️ Modern E-Ticaret Platformu | ASP.NET Core MVC & MongoDB

Bu proje, **M&Y Akademi Danışmanlık** bünyesinde, **Murat Yücedağ** rehberliğinde geliştirilmiştir.
ASP.NET Core MVC mimarisi ve MongoDB NoSQL veritabanı kullanılarak oluşturulan bu uygulama, kullanıcıya sade ve işlevsel bir alışveriş deneyimi sunmayı amaçlar.

Kullanıcılar ürünleri detaylı şekilde inceleyebilir, kampanyaları slider üzerinden görebilir ve e-posta adresi ile özel indirim kuponları alabilir.
Yönetim paneli üzerinden ürünler, kategoriler ve kampanyalar kolayca kontrol edilebilir.

---

## 🚀 Öne Çıkan Özellikler

* 🛒 **MongoDB ile NoSQL veri yapısı**
* 📦 **Ürün, kategori ve slider yönetimi**
* 💬 **Basit e-posta gönderimi ile %20 kupon özelliği**
* 🔄 **Async/Await ile asenkron veri işlemleri**
* 🧱 **Reusable ViewComponent ve Partial View kullanımı**
* 📐 **Katmanlı mimari yapısı (Controller - Service - DTO - View)**

---

## 🔐 Yönetici Paneli Özellikleri

Yönetici paneli üzerinden şu işlemler kolaylıkla yapılabilir:

* ➕ Yeni ürün ekleme, düzenleme ve silme
* 📁 Kategori oluşturma ve güncelleme
* 🖼️ Slider görselleri ekleme ve sıralama
* 📊 İçerik yönetimi ve temel kontrol mekanizmaları

---

## 🧩 Proje Mimarisi

**Katmanlar:**

* 🎮 **Controller** → HTTP isteklerini alır, servis katmanları ile iletişim kurar
* 🧠 **Service** → İş mantığı burada yönetilir, MongoDB ile etkileşim sağlar
* 📤 **DTO** → Katmanlar arası veri taşıma için kullanılır
* 🖥️ **View** → Razor tabanlı kullanıcı arayüzleri
* 🧷 **ViewComponent / Partial View** → Ürün kartları, slider bileşenleri gibi tekrar kullanılabilir yapılar

---

## 🗃️ MongoDB Koleksiyonları

**🛍️ Products (Ürünler)**
`ProductId, ProductName, ProductPrice, ImageUrl, Status, StockCount, CategoryId, Description, Brand`

**🖼️ ProductImages (Ürün Görselleri)**
`ImageId, ImageUrl, ProductId`

**📂 Categories (Kategoriler)**
`CategoryId, CategoryName, ImageUrl`

**🎯 Sliders (Kampanyalar)**
`SectionId, SectionName, AnchorId, Order, Title, ImageUrl`

> Koleksiyonlar arasında bağlantı `ID` alanları ile kurulur (örn. `Product.CategoryId`).

---

## ✉️ E-Posta Kupon Sistemi

* Kullanıcılar yalnızca e-posta adresi girerek **%20 indirim kuponu** içeren bir mail alır
* 📩 Mail gönderimi `IMailService` arayüzü aracılığıyla gerçekleştirilir
* 📬 Gmail SMTP üzerinden gönderim sağlanır
* ⚠️ Gönderilen kupon sabittir ve sistemde kayıt tutulmaz
* 🗂️ Henüz `Subscriber` koleksiyonu bulunmamaktadır, aboneler MongoDB’ye kaydedilmemektedir

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji              | Açıklama                       |
| ---------------------- | ------------------------------ |
| ASP.NET Core MVC       | Web uygulama çatısı            |
| MongoDB                | NoSQL veritabanı               |
| Bootstrap 5            | Modern ve responsive tasarım   |
| C# 10                  | Backend geliştirme dili        |
| JavaScript (Fetch API) | Dinamik veri işlemleri         |
| LINQ                   | Veri sorgulama                 |
| DTO Pattern            | Katmanlar arası veri aktarımı  |
| Async/Await            | Performanslı asenkron süreçler |
| Gmail SMTP             | Mail ile kupon gönderimi       |

---

## 🖼️ Proje Görselleri
![Main](https://github.com/user-attachments/assets/6a07fe98-4d41-4d98-baff-cd3c1aa92f4b)
![Category](https://github.com/user-attachments/assets/585457b2-7e85-405a-b07b-9fb1df7e7ded)
![Product](https://github.com/user-attachments/assets/8d04173e-adfb-4b92-9403-5cbc1938f369)
![Kupon](https://github.com/user-attachments/assets/1e783598-9180-41ad-9eba-6b02a3666e4d)
![mail](https://github.com/user-attachments/assets/95b68614-2958-4998-80e8-6e31457ae1a7)
![AdminCategory](https://github.com/user-attachments/assets/8d4a6a5c-d069-4842-8df0-a0a596547bc3)
![AdminProduct1](https://github.com/user-attachments/assets/c9a22c4a-afbc-4393-9f75-e9a8122e02af)
![AdminSlider](https://github.com/user-attachments/assets/1436a9cc-3479-43b1-ae47-f06fe6c8d665)
