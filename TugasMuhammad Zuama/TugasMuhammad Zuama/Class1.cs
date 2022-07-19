using System;

namespace usersystem
{
    class Player
    {
        internal string username;

        public Player(string _username)
        {
            this.username = _username;
        }

    }

    class Role
    {
        internal string nama_skil_1, nama_skill_2;
        protected int skill1_damage, skill2_damage;
        internal int Kekuatan, Pertahanan, nyawa;
    }

    class Assashin : Role
    {
        int attack_stack, total_damage;
        Player user;
        public Assashin(Player _user)
        {
            base.Kekuatan = 40;
            base.Pertahanan = 60;
            base.nyawa = 100;


            this.user = _user;
            base.nama_skil_1 = "Pedang Emas";
            base.skill1_damage = 50;
            base.nama_skill_2 = "Pedang Petir";
            base.skill2_damage =80 ;
        }

        public int Menyerang(int type_attack)

        {
            if (type_attack == 1)
            {
                Console.WriteLine("Normal Attack - Jumlah Damage: " + base.Kekuatan);
                this.total_damage = base.Kekuatan;
            }
            else if (type_attack == 2)
            {
                Console.WriteLine(this.nama_skil_1 + " - Jumlah Damage: " + this.nama_skil_1);
                this.total_damage = this.skill1_damage;
            }
            else if (type_attack == 3)
            {
                Console.WriteLine(this.nama_skill_2 + " - Jumlah Damage: " + this.nama_skill_2);
                this.total_damage = this.skill2_damage;
            }

            if (attack_stack == 10)
            {
                int extra_damage = Convert.ToInt32(Math.Ceiling(total_damage * 0.1));
                Console.WriteLine("Extra Attack - Damage Dealt: " + extra_damage);
                attack_stack = 0;
            }
            this.attack_stack += 1;
            return this.total_damage;
        }

        public void defend(int attack_received)
        {
            int tmp_attack = base.Pertahanan - attack_received;
            base.nyawa -= tmp_attack;
            Console.WriteLine("Keras Damage: " + tmp_attack + " Sisa Nyawa: " + base.nyawa + "\n\n");
        }

        public bool ALive()
        {
            if (base.nyawa < 0)
                return false;
            else
                return true;
        }
    }

    class Tank : Role
    {
        int attack_stack, total_damage;
        Player user;
        public Tank(Player _user)
        {
            base.Kekuatan = 30;
            base.Pertahanan = 70;
            base.nyawa = 120;

            this.user = _user;
            base.nama_skil_1 = "Pukulan Topan";
            base.skill1_damage = 50;
            base.nama_skill_2 = "Pukulan Petir";
            base.skill2_damage = 80;
        }

        public int Menyerang(int type_attack)

        {
            if (type_attack == 1)
            {
                Console.WriteLine("Normal Attack - Jumlah Damage: " + base.Kekuatan);
                this.total_damage = base.Kekuatan;
            }
            else if (type_attack == 2)
            {
                Console.WriteLine(this.nama_skil_1 + " - Jumlah Damage: " + this.nama_skil_1);
                this.total_damage = this.skill1_damage;
            }
            else if (type_attack == 3)
            {
                Console.WriteLine(this.nama_skill_2 + " - Jumlah Damage: " + this.nama_skill_2);
                this.total_damage = this.skill2_damage;
            }

            if (attack_stack == 10)
            {
                int extra_damage = Convert.ToInt32(Math.Ceiling(total_damage * 0.1));
                Console.WriteLine("Extra Attack - Damage Dealt: " + extra_damage);
                attack_stack = 0;
            }
            this.attack_stack += 1;
            return this.total_damage;
        }
        public void defend(int attack_received)
        {
            int tmp_attack = base.Pertahanan - attack_received;
            base.nyawa -= tmp_attack;
            Console.WriteLine("Keras Damage: " + tmp_attack + " Sisa Nyawa: " + base.nyawa + "\n\n");
        }
        public bool ALive()
        {
            if (base.nyawa < 0)
                return false;
            else
                return true;
        }
    }


    class Mage : Role
    {
        int attack_stack, total_damage;
        Player user;
        public Mage(Player _user)
        {
            base.Kekuatan = 40;
            base.Pertahanan = 60;
            base.nyawa = 100;


            this.user = _user;
            base.nama_skil_1 = "Sihir Air";
            base.skill1_damage = 50;
            base.nama_skill_2 = "Sihir Petir";
            base.skill2_damage = 70;
        }

        public int Menyerang(int type_attack)

        {
            if (type_attack == 1)
            {
                Console.WriteLine("Normal Attack - Damage Dealt: " + base.Kekuatan);
                this.total_damage += base.Kekuatan;
            }
            else if (type_attack == 2)
            {
                Console.WriteLine(this.nama_skil_1 + " - Damage Dealt: " + this.nama_skil_1);
                this.total_damage += this.skill1_damage;
            }
            else if (type_attack == 3)
            {
                Console.WriteLine(this.nama_skill_2 + " - Damage Dealt: " + this.nama_skill_2);
                this.total_damage += this.skill2_damage;
            }

            if (attack_stack == 10)
            {
                int extra_damage = Convert.ToInt32(Math.Ceiling(total_damage * 0.1));
                Console.WriteLine("Extra Attack - Damage Dealt: " + extra_damage);
                attack_stack = 0;
            }
            this.attack_stack += 1;
            return this.total_damage;
        }

        public void defend(int attack_received)
        {
            int tmp_attack = base.Pertahanan - attack_received;
            base.nyawa -= tmp_attack;
            Console.WriteLine("keras damage : " + tmp_attack + " sisa nyawa : " + base.nyawa + "\n\n");
        }

        public bool ALive()
        {
            if (base.nyawa < 0)
                return false;
            else
                return true;
        }
    }

    class musuh
    {
        internal string nama_skil_1, nama_skill_2;
        protected int skill1_damage, skill2_damage;
        internal int Kekuatan, Pertahanan, nyawa;
    }
    class godzila: musuh
    {
        int attack_stack, total_damage;
        Player user;
        public godzila(Player _user)
        {
            base.Kekuatan = 40;
            base.Pertahanan = 60;
            base.nyawa = 100;


            base.nama_skil_1 = "Pedang Emas";
            base.skill1_damage = 50;
            base.nama_skill_2 = "Pedang Petir";
            base.skill2_damage = 80;
        }
    }



}

