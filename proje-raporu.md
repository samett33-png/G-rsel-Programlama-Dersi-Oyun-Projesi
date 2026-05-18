# Proje Raporu

## Oyunun Adı
Basit Flappy Bird Oyunu

---

## Oyunun Amacı
Bu projede amaç, klasik Flappy Bird mantığında çalışan basit bir 2D oyun geliştirmektir. Oyuncu kuş karakterini kontrol ederek engellerin arasından geçmeye çalışır. Oyun refleks ve zamanlama becerisine dayalıdır.

---

## Nasıl Oynanır?
Oyuncu, mouse sol tıkı ile kuşu yukarı doğru zıplatır. Borular arasından geçerek mümkün olduğunca yüksek skor elde etmeye çalışır. Borulara veya yere çarpıldığında oyun sona erer.

### Kontroller
- Sol Mouse Tuşu → Zıplama

---

## Kullanılan Unity Bileşenleri

| Bileşen | Kullanım Amacı |
|------|------|
| Rigidbody2D | Kuşun fiziksel hareketlerini sağlamak |
| BoxCollider2D | Çarpışma kontrolü yapmak |
| Sprite Renderer | Oyun görsellerini ekrana çizdirmek |
| Camera | Oyun görüntüsünü sağlamak |
| Prefab System | Boruların tekrar üretimini sağlamak |
| Transform | Nesnelerin konum, dönüş ve ölçek işlemleri |

---

## Kullanılan C# Scriptleri

| Script Adı | Görevi |
|------|------|
| Birdy.cs | Kuşun zıplama, düşme ve dönüş mekaniklerini yönetir |
| Move.cs | Arka plan ve boruların hareketini sağlar |
| Spawner.cs | Boruları rastgele ve belirli aralıklarla üretir |

---

## Oyun Mekanikleri

- Rastgele boru üretim sistemi
- Çarpışma kontrol sistemi
- Skor sistemi
- Fizik tabanlı zıplama mekaniği
- Sonsuz oyun döngüsü

---

## Karşılaşılan Zorluklar

Geliştirme sürecinde kuşun zıplama fiziğinin dengelenmesi, boruların doğru aralıklarla spawn edilmesi ve çarpışma sisteminin hatasız çalışması gibi problemler yaşanmıştır. Bu sorunlar Unity fizik ayarları ve script optimizasyonları ile çözülmüştür.

---

## Sonuç
Bu proje sayesinde Unity 2D oyun geliştirme mantığı, fizik sistemleri, prefab kullanımı ve C# script yapısı öğrenilmiştir.
