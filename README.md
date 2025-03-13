<table>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/6d6a4ef1-0cef-4c3f-ba03-898dcf94ee3b" width="50"/></td>
    <td><h1>FÜBİS - Şehir İçi Bisiklet Kiralama Otomasyonu</h1></td>
  </tr>
</table>


## 📌 Proje Açıklaması  
FÜBİS, **şehir içi ulaşım, kurum içi kullanım ve turistik geziler** için geliştirilmiş **bisiklet kiralama otomasyonu**dur.    

### 🛠 Kullanılan Teknolojiler  
- **C# Windows Form** → Kullanıcı dostu UI/UX tasarımı  
- **MySQL** → Veritabanı yönetimi  
- **MVC & N-Tier Mimari** → Ölçeklenebilir ve sürdürülebilir yapı
- **Kimler Kullanabilir?** Bireysel & Kurumsal Kullanıcılar
- **Kullanım Alanı:** Şehir içi ulaşım, kurumsal & turistik bisiklet kiralama

---

## 🚀 Özellikler  

### 🎛 Moderatör Paneli  
✅ İlçelere **bisiklet ve teknik ekip atama**  
✅ İlçelerdeki tüm bisikletlerin durumlarını takip edebilme  

### 🛠 Teknik Personel Paneli  
✅ Görevli olduğu ilçedeki **bisikletleri listeleme**  
✅ **Bisiklet bakım işlemleri** (Bakım başlatma/bakım bitirme)  
✅ Bakımda olan bisikletlerin **isMaintenance** durumunun güncellenmesi  

### 🚲 Bisiklet Kiralama Süreci  
✅ **Kullanıcı Kaydı:** Kullanıcı kaydolduğunda **mail servisi** ile **sanal kart numarası** gönderilir  
✅ **Bakiye Yükleme:** Kullanıcılar, kart numaralarıyla bakiye yükleyebilir  
✅ **Bisiklet Kiralama:**  
   - Kullanıcı, 1-5 saat aralığında bisiklet kiralayabilir  
   - **isAvailable** ve **isMaintenance** durumuna göre uygun bisiklet bildirilir ve atanır
✅ **Bisiklet Teslimi:** Kullanıcılar, kiraladıkları bisikleti sistem üzerinden kart numaralarıyla teslim edebilir  

### 🔒 Güvenlik Önlemleri  
✅ **Mail doğrulama sistemi** (Kullanıcı kayıt olurken sanal kart numarası e-posta ile gönderilir)  
✅ **Ödeme Güvenliği:**  
   - Kullanıcı, ödeme yaparken kart numarasını girer
   - **Mail doğrulama kodu** ile ek güvenlik sağlanır 

---


## 📂 Proje Mimarisi (MVC & N-Tier)  
FÜBİS, **MVC & N-Tier mimari** ile geliştirilmiştir ve aşağıdaki katmanları içermektedir:  

```plaintext
📂 Fübis
├── 📁 View         # Kullanıcı etkileşimleri (Windows Form UI)
├── 📁 Service      # İş kuralları, validasyonlar
├── 📁 Repository   # MySQL bağlantıları ve sorgular
├── 📁 Model        # Veri modelleri
├── 📁 Resources    # UI kaynakları
```

---
## 📷 Uygulama İçi Ekran Görüntüleri  
<table>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/bbc37705-16a0-4cf4-9449-4ae9849b074c" width="500"/></td>
    <td><img src="https://github.com/user-attachments/assets/c6bec865-5b1e-4c21-8152-7e328b54022f" width="500"/></td>
  </tr>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/02f09e63-f0fe-42e8-88f1-f96ffe77b08e" width="500"/></td>
    <td><img src="https://github.com/user-attachments/assets/9b65aed1-4554-4c91-8d05-6168fb5e107c" width="500"/></td>
  </tr>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/1eb80e2d-98b8-4de6-899e-9a1b49ef7f7f" width="500"/></td>
    <td><img src="https://github.com/user-attachments/assets/196c6511-bebc-4395-b228-4e7bf53e3543" width="500"/></td>
  </tr>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/e757d3c4-f295-41ec-9547-04c79663000a" width="500"/></td>
    <td><img src="https://github.com/user-attachments/assets/4dcd40c8-dcc2-41a5-bcc7-74180f965c3b" width="500"/></td>
  </tr>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/b4053092-7592-44ca-89f9-c38bc438b6d7" width="500"/></td>
    <td><img src="https://github.com/user-attachments/assets/74f00e30-5f1c-4362-837c-22c1dfe4fbf6" width="500"/></td>
  </tr>
</table>
