📦 Kargo Takip & Yönetim Sistemi (Backend Altyapısı)
Bu proje, bir kargo firmasının yönetim panelini ve bu panele veri sağlayan API katmanını simüle etmek amacıyla geliştirilmiştir. Proje, sadece bir arayüz çalışması değil; veritabanı, servis katmanı ve istemci arasındaki veri akışını yöneten tam kapsamlı bir Backend çalışmasıdır.

🚀 Proje Hakkında
Projenin temel odak noktası, ASP.NET Core 5.0 mimarisi üzerinde Web API kullanarak verileri merkezi bir sistemden yönetmek ve bu verileri Web UI katmanında dinamik olarak listelemektir. Sistem, "Sistem Genel Ayarları" gibi yönetimsel verilerin SQL veritabanından çekilmesi ve işlenmesi üzerine kurgulanmıştır.

🛠️ Teknik Özellikler ve Mimari
Proje, sürdürülebilirlik ve test edilebilirlik için N-Tier (Katmanlı) Mimari ile inşa edilmiştir:

API Katmanı: Verileri JSON formatında sunan, Route yapılandırmalarıyla özelleştirilmiş servis katmanı.

Web UI Katmanı: API'den gelen verileri HttpClient ile tüketen ve kullanıcıya sunan yönetim paneli.

Business & Data Layers: İş mantığının yönetildiği ve Entity Framework Core ile veritabanı işlemlerinin (CRUD) yürütüldüğü katmanlar.

Kullanılan Teknolojiler
Dil: C#

Framework: ASP.NET Core 5.0

Veritabanı: MS SQL Server

ORM: Entity Framework Core (Repository Pattern)

Arayüz: AdminLTE 3 / Bootstrap 4
