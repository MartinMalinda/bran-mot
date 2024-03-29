﻿using System;
namespace Workshop.Models
{
    public class Greeting
    {
        public long ID { get; set; }
        public string Content { get; set; } = "Hello World!";
        public string[] hellos { get; private set; }  = {"Mirëdita", "Ahalan", "Parev", "Zdravei", "Nei Ho", "Dobrý den", "Ahoj", "Goddag", "Goede dag, Hallo", "Hello", "Saluton", "Hei", "Bonjour",
                "Guten Tag", "Gia'sou", "Aloha", "Shalom", "Namaste", "Namaste", "Jó napot", "Halló", "Helló", "Góðan daginn", "Halo", "Aksunai", "Qanuipit", "Dia dhuit",
                "Salve", "Ciao", "Kon-nichiwa", "An-nyong Ha-se-yo", "Salvëte", "Ni hao", "Dzien' dobry", "Olá", "Bunã ziua", "Zdravstvuyte", "Hola", "Jambo", "Hujambo", "Hej",
                "Sa-wat-dee", "Merhaba", "Selam", "Vitayu", "Xin chào", "Hylo", "Sut Mae", "Sholem Aleychem", "Sawubona"};

        public Greeting()
        {
            this.ID = Controllers.RestController.CallCount;
        }

        public Greeting(string name)
        {
            this.ID = Controllers.RestController.CallCount;
            this.Content = name;
        }

        public string ChooseLanguage()
        {
            return hellos[new Random().Next(hellos.Length - 1)];
        }
    }
}
