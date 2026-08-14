using System;
using System.Collections.Generic;

class Program
{
    static decimal balans = 1000.50m;          
    static int togriPin = 1234;                 
    static List<string> tarix = new List<string>(); 

    static void Main()
    {
        Console.WriteLine("=== BANKOMATGA XUSH KELIBSIZ ===");

        int urinishlar = 3;
        bool ruxsat = false; 

        while (urinishlar > 0)
        {
            Console.Write("PIN kodni kiriting: ");
            try
            {
                int kiritilganPin = Convert.ToInt32(Console.ReadLine());

                if (kiritilganPin == togriPin) 
                {
                    ruxsat = true;
                    Console.Clear();
                    break; 
                    
                }
                else
                {
                    urinishlar--;
                    Console.Clear();
                    Console.WriteLine($"Noto'g'ri PIN. Qayta kiriting.Sizda {urinishlar} ta urinish qoldi. \n");
                    
                }
            }
            catch (FormatException) 
            {
                Console.WriteLine("XATOLIK: PIN kod faqat raqamlardan iborat bo'lishi kerak!\n");
            }
        }

        if (!ruxsat)
        {
            Console.WriteLine("Karta bloklandi! Dastur to'xtatildi.");
            return; 
        }

        bool ishlamoqda = true;

        
        while (ishlamoqda)
        {
            Console.Clear();

            Console.WriteLine("\n--- MENYU ---");
            Console.WriteLine("1. Balansni ko'rish");
            Console.WriteLine("2. Pul yechish");
            Console.WriteLine("3. Pul qo'shish");
            Console.WriteLine("4. Amaliyotlar tarixi");
            Console.WriteLine("5. Chiqish");
            Console.Write("Tanlovingizni kiriting (1-5): ");

            try
            {
                int tanlov = Convert.ToInt32(Console.ReadLine());

                switch (tanlov)
                {
                    case 1:
                        Console.Clear(); // <-- OLDIN EKRANNI TOZALAYMIZ
                        BalansniKorish(); // <-- KEYIN BALANSNI CHIQARAMIZ
                        Console.WriteLine("\nMenyuga qaytish uchun 'Enter' ni bosing...");
                        Console.ReadLine(); // <-- ENTER KUTAMIZ
                        break;
                    case 2:
                        Console.Clear();
                        PulYechish();
                        Console.WriteLine("\nMenyuga qaytish uchun 'Enter' ni bosing...");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        PulQoshish();
                        Console.WriteLine("\nMenyuga qaytish uchun 'Enter' ni bosing...");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        TarixniKorish();
                        Console.WriteLine("\nMenyuga qaytish uchun 'Enter' ni bosing...");
                        Console.ReadLine();
                        break;
                    case 5:
                        ishlamoqda = false;
                        Console.Clear();
                        Console.WriteLine("Xizmatingizdan xursandmiz. Xayr!");
                        break;
                    default:
                        Console.WriteLine("Noto'g'ri tanlov! Faqat 1-5 raqamlaridan foydalaning.");
                        Console.ReadLine();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("XATOLIK: Menyuni tanlash uchun faqat raqam kiriting!");
                Console.ReadLine();
            }
        }
        // ...
    }
            

    static void BalansniKorish()
    {
        Console.WriteLine($"\n[ JORIY BALANS ]: {balans} so'm");
        tarix.Add("Balans tekshirildi.");
    }

    static void PulYechish()
    {
        Console.Write("Yechmoqchi bo'lgan summangizni kiriting: ");
        try
        {
            decimal summa = Convert.ToDecimal(Console.ReadLine());

            if (summa <= 0)
            {
                Console.WriteLine("Xato! Nol yoki manfiy pul kiritish mumkin emas.");
            }
            else if (summa > balans)
            {
                Console.WriteLine("Xato! Hisobingizda yetarli mablag' yo'q.");
            }
            else
            {
                balans = balans - summa;
                Console.WriteLine($"\n[ MUVAFFAQIYAT ]: {summa} so'm yechib olindi.");
                tarix.Add($"- {summa} so'm yechildi."); 
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("XATOLIK: Summani faqat raqamlarda kiriting!");
        }
    }

    static void PulQoshish()
    {
        Console.Write("Hisobga qo'shmoqchi bo'lgan summangizni kiriting: ");
        try
        {
            decimal summa = Convert.ToDecimal(Console.ReadLine());

            if (summa <= 0)
            {
                Console.WriteLine("Xato! Nol yoki manfiy pul kiritish mumkin emas.");
            }
            else
            {
                balans = balans + summa;
                Console.WriteLine($"\n[ MUVAFFAQIYAT ]: Hisobingizga {summa} so'm qo'shildi.");
                tarix.Add($"+ {summa} so'm qo'shildi.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("XATOLIK: Summani faqat raqamlarda kiriting!");
        }
    }

    static void TarixniKorish()
    {
        Console.WriteLine("\n--- AMALIYOTLAR TARIXI ---");
        if (tarix.Count == 0)
        {
            Console.WriteLine("Hali hech qanday amaliyot bajarilmadi.");
        }
        else
        {
            foreach (string amal in tarix)
            {
                Console.WriteLine(amal);
            }
        }
    }
}