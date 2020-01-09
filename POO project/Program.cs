using System;

namespace POO_project
{
    class Program
    {
        /*
        João ataca o Nhaça e tira 74 de vida
        Nhaça tem 69 vida
 
        Nhaça ataca o João e tira 6 de vida
        João tem 6 vida
 
        João ataca o Nhaça e tira 48 de vida
        Nhaça tem 21 vida
 
        Nhaça ataca o João e tira 48 de vida
        João tem -42 vida
 
        João morreu e o Nhaça Ganhou!!
 
        Acabou a batalha
        */

        static void Main(string[] args)
        {
            guerreiro Nhaça = new guerreiro("Nhaça", 1000, 120, 40);
            guerreiro João = new guerreiro("João", 1000, 120, 40);
 
            batanha.StartFight(Nhaça, João);

        }
        
    }
}
