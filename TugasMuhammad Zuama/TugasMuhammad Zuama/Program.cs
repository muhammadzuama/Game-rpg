using System;
using usersystem;

class gameplay
{
    public static void Main(string[] args)
    {
        Random Godzila_attack = new Random();
        int Godzila = 150;
        Console.Write("Username = ");
        string username = Console.ReadLine();
        Player p1 = new Player(username);
        Console.WriteLine("[1] ASSASSIN |Kekuatan = 40 |Pertahanan = 60|nyawa = 100 |");
        Console.WriteLine("[2] TANK     |Kekuatan = 30 |Pertahanan = 70|nyawa = 120 |");
        Console.WriteLine("[3] MAGE     |Kekuatan = 90 |Pertahanan = 20|nyawa = 80  |");
        Console.Write("Pilih Role = ");
        int Pilih = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if (Pilih == 1)
        {
            Assashin p1_role = new Assashin(p1);
            while (true)
            {
                Console.WriteLine("Serang Monster Itu !!!!!!");
                Console.WriteLine("[1].Serangan Normal [2]." + p1_role.nama_skil_1 + " [3]." + p1_role.nama_skill_2 + " : ");
                int attack_type = Convert.ToInt32(Console.ReadLine());
                p1_role.defend(Godzila_attack.Next(1, 50));
                Godzila -= p1_role.Menyerang(attack_type);
                Console.WriteLine("Sisa darah musuh = " + Godzila);
                if (Godzila <= 0)
                {
                    Console.WriteLine(" YOU WINN !!!!");
                    System.Environment.Exit(1);
                }
                if (!p1_role.ALive())
                {
                    Console.WriteLine("GAME OVER!!!");
                    System.Environment.Exit(1);
                }
            }
        }
        else if (Pilih == 2)
        {
            Tank p1_role = new Tank(p1);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("[1].Serangan Normal [2]." + p1_role.nama_skil_1 + " [3]." + p1_role.nama_skill_2 + " : ");
                int attack_type = Convert.ToInt32(Console.ReadLine());
                p1_role.Menyerang(attack_type);
                p1_role.defend(Godzila_attack.Next(1, 40));
                Godzila -= p1_role.Menyerang(attack_type);
                Console.WriteLine("Sisa darah musuh = " + Godzila);
                if (Godzila <= 0)
                {
                    Console.WriteLine(" YOU WINN !!!!");
                    System.Environment.Exit(1);
                }

                if (!p1_role.ALive())
                {
                    System.Environment.Exit(1);
                    Console.WriteLine("GAME OVER!!!");
                }
            }
        }
        else if (Pilih == 3)
        {
            Mage p1_role = new Mage(p1);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("[1].Serangan Normal [2]." + p1_role.nama_skil_1 + " [3]." + p1_role.nama_skill_2 + " : ");
                int attack_type = Convert.ToInt32(Console.ReadLine());
                p1_role.Menyerang(attack_type);
                p1_role.defend(Godzila_attack.Next(1, 15));
                Godzila -= p1_role.Menyerang(attack_type);
                Console.WriteLine("Sisa darah musuh = " + Godzila);
                if (Godzila <= 0)
                {
                    Console.WriteLine(" YOU WINN !!!!");
                    System.Environment.Exit(1);
                }
                if (!p1_role.ALive())
                {
                    Console.WriteLine("GAME OVER!!!");
                    System.Environment.Exit(1);
                }
            }
        }
    }
}
