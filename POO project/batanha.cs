using System;
using System.Collections.Generic;
using System.Text;

namespace POO_project
{
    class batanha
        {

        // Receber ambos os objetos de cada guerreiro

        public static void StartFight(guerreiro guerreiro1,
                guerreiro guerreiro2)
            {
                // Faz um loop que faz com que cada guerreiro tenha a sua oportunidade de atacar/defender e que acabe quando alguem morrer

                while (true)
                {
                    if (GetAttackResult(guerreiro1, guerreiro2) == "Acabou o jogo")
                    {
                        Console.WriteLine("Acabou o jogo");
                        break;
                    }

                    if (GetAttackResult(guerreiro2, guerreiro1) == "Acabou o jogo")
                    {
                        Console.WriteLine("Acabou o jogo");
                        break;
                    }
                }
            }

            // Aqui aceita ambos os guerreiros
            public static string GetAttackResult(guerreiro guerreiroA,
                guerreiro guerreiroB)
            {
                // Calcula quando um ataca e quando defendem
                double warAAttkAmt = guerreiroA.Attack();
                double warBBlkAmt = guerreiroB.Block();

                // Subtrair o bloque do ataque
                double dmg2WarB = warAAttkAmt - warBBlkAmt;

                // Se alguém causou dano - retira da vida do inimigo
                if (dmg2WarB > 0)
                {
                guerreiroB.Health = guerreiroB.Health - dmg2WarB;
                }
                else dmg2WarB = 0;

                // Escreve quem atacou e o dano e que tirou
                Console.WriteLine("{0} atacou o {1} e tirou {2} vida",
                    guerreiroA.Name, guerreiroB.Name, dmg2WarB);

                // Escrever a quanto de vida o defensor ficou
                Console.WriteLine("{0} tem {1} vida\n",
                    guerreiroB.Name, guerreiroB.Health);

                //Verifica de a vida de algum dos guerreiros foi para baixo do 0, se sim manda encerrar o loop
                if (guerreiroB.Health <= 0)
                {
                    Console.WriteLine("{0} morreu e o {1} Ganhou!\n",
                        guerreiroB.Name, guerreiroA.Name);

                    return "Acabou o jogo";
                }
                else return "Voltar a combater";
            }
        }
}
