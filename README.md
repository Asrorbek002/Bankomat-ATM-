# 🏦 Bankomat (ATM) - C# Konsol Dasturi

Bu loyiha C# tilida yozilgan oddiy va interaktiv Bankomat (ATM) simulyatsiyasidir. Dastur konsol oynasida ishlaydi va foydalanuvchiga o'z hisobini boshqarish imkonini beradi. Kod o'qishga qulay qilib yozilgan bo'lib, C# dasturlash asoslarini (tsikllar, shart operatorlari, metodlar va xatoliklarni ushlash) o'rganish uchun ajoyib namuna hisoblanadi.

## 📺 Dastur qanday ishlaydi? (Demo)

<img width="667" height="487" alt="Анимация" src="https://github.com/user-attachments/assets/e7e97788-01ec-41a8-91bd-8556b3de854e" />

![Bankomat Demo](demo.gif)

## ✨ Imkoniyatlari (Features)

* **🔒 PIN kod orqali himoya:** Tizimga kirish uchun to'g'ri PIN kod kiritish talab qilinadi (maksimal 3 marta urinish imkoniyati mavjud).
* **💰 Balansni tekshirish:** Joriy hisobingizdagi mablag'ni ko'rish imkoniyati.
* **💵 Pul yechish:** Hisobdan pul yechish. Dastur hisobda yetarli mablag' bor-yo'qligini va manfiy/nol qiymat kiritilmaganligini avtomatik tekshiradi.
* **📥 Pul qo'shish:** Tizim orqali virtual hisobga pul kiritish.
* **📜 Amaliyotlar tarixi:** Dastur ishga tushgandan so'ng bajarilgan barcha tranzaksiyalar (balans tekshirish, pul qo'shish/yechish) tarixini ko'rish.
* **🛡️ Xatoliklarni ushlash (Exception Handling):** Foydalanuvchi raqam o'rniga harf yoki boshqa belgi kiritganda dastur qotib qolmaydi, balki ogohlantirish berib, qayta urinishni so'raydi.
* **🧹 Toza interfeys:** Har bir amaldan so'ng konsol oynasi tozalanib, foydalanuvchiga faqat kerakli ma'lumotlar ko'rsatiladi.

## 🚀 Dasturni ishga tushirish

1. Ushbu loyihani kompyuteringizga yuklab oling (Clone).
2. Loyihani C# kod muharririda (Visual Studio, Visual Studio Code yoki Rider) oching.
3. Dasturni ishga tushirish tugmasini (`Run` yoki `F5`) bosing.
4. Konsol oynasi ochilgandan so'ng, tizimga kirish uchun standart PIN kodni kiriting.

### 🔑 Standart ma'lumotlar (Testing uchun)
* **Standart PIN kod:** `1234`
* **Boshlang'ich balans:** `1000,50 so'm`

## 🛠️ Texnologiyalar va Tushunchalar

Ushbu dasturni yaratishda quyidagi C# tushunchalaridan foydalanildi:
* **O'zgaruvchilar va Ma'lumot turlari:** `int`, `decimal`, `bool`
* **Kolleksiyalar:** `List<string>` (amaliyotlar tarixini saqlash uchun)
* **Tsikllar:** `while` (menyuni takrorlash uchun), `foreach` (tarixni o'qish uchun)
* **Shart operatorlari:** `if/else`, `switch-case`
* **Xatoliklarni boshqarish:** `try-catch` (Noto'g'ri formatni ushlash uchun)
* **Konsol komandalari:** `Console.Clear()`, `Console.ReadLine()`

---
*Ushbu loyiha dasturlash asoslarini o'rganish va amaliyot qilish maqsadida yaratilgan.*
