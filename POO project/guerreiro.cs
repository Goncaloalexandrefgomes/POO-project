using System;
using System.Collections.Generic;
using System.Text;

namespace POO_project
{
    class guerreiro
    {
        // Define cada propriada de ambos os guerreiros
        public string Name { get; set; } = "Guerreiro";
        public double Health { get; set; } = 0;
        public double AttkMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        // Isto faz com que o vencedor/dano causado/blocks de cada um nao seja sempre o mesmo 
        Random rnd = new Random();


        public guerreiro(string name = "Warrior",
            double health = 0,
            double attkMax = 0,
            double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttkMax = attkMax;
            BlockMax = blockMax;
        }

        // Gere um valor aleatorio do ataque apartir de 1
        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }

        // Gere um valor aleatorio do bloqueio apartir de 1
        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }

    }
}