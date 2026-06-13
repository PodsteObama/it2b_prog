class Program 
{ 
    static void Main() { //uvod
        Console.WriteLine("=== WELCOME TO CICHNARENA! ==="); 
        Console.Write("Enter your trainer name: "); 
        string playerName = Console.ReadLine(); 
        Console.Write("Enter enemy trainer name: "); 
        string enemyName = Console.ReadLine();

        #region Setup

        // utoky
        Attack ohnivyKod = new Attack( "Ohnivy Kod", 9); 
        Attack horlavyServer = new Attack( "Horlavy Server", 17); 
        Attack linuxOtazka = new Attack( "Linux Otazka", 8); 
        Attack linuxTest = new Attack( "Linux Test", 15); 
        Attack iphone17 = new Attack( "iPhone 17", 7); 
        Attack poradaHejtmana = new Attack( "Porada Hejtmana", 13); 
   // cichnamoni
   Cichnamon ondra = new Cichnamon( "Ohnivy Ondrej", 55, 2, ohnivyKod, horlavyServer); 
        Cichnamon michalica = new Cichnamon( "Vodnik Michalica", 65, 1, linuxOtazka, linuxTest); 
        Cichnamon krejci = new Cichnamon( "Divoky Jan Krejci", 75, 0, iphone17, poradaHejtmana); 
        Console.WriteLine(); 
        Console.WriteLine("Choose your Cichnamon:"); 
        Console.WriteLine("1 - Ohnivy Ondrej"); 
        Console.WriteLine("2 - Vodnik Michalica"); 
        Console.WriteLine("3 - Divoky Jan Krejci"); 
        int choice = int.Parse(Console.ReadLine()); 
        Cichnamon playerCichna; 
        if (choice == 1) 
        {
            playerCichna = ondra; 
        } else if (choice == 2) 
        {
            playerCichna = michalica; 
        } else 
        {
            playerCichna = krejci; 
        } // vyber cichnamona
        Random random = new Random();  //vyber cichnamona pro nepritele
        int enemyChoice = random.Next(1, 4); 
        Cichnamon enemyCichna; 
        if (enemyChoice == 1) 
        { 
            enemyCichna = new Cichnamon( "Evil Ohnivy Ondrej", 55, 4, ohnivyKod, horlavyServer); 
        } else if (enemyChoice == 2) 
        {
            enemyCichna = new Cichnamon( "Evil Vodnik Michalica", 65, 3, linuxOtazka, linuxTest); 
        } else  { 
            enemyCichna = new Cichnamon( "Evil Divoky Jan Krejci", 75, 2, iphone17, poradaHejtmana); 
        } 
        Trainer player = new Trainer(playerName, playerCichna); 
        Trainer enemy = new Trainer(enemyName, enemyCichna); 
        Console.WriteLine();
        Console.WriteLine("Battle begins!");

        #endregion Setup


        bool playing = true; 


        while (playing) //
        {

            while (player.ActiveCichnamon.IsAlive() && enemy.ActiveCichnamon.IsAlive())
            { //loop main engine

                Console.WriteLine();
                Console.WriteLine("YOUR TURN");

                Console.WriteLine("----------------");
                Console.WriteLine("You: " + player.TrainerName + " lvl: " + player.Level) ;
                player.ActiveCichnamon.Info();
                Console.WriteLine("Enemy: " + enemy.TrainerName + " lvl: " + enemy.Level);
                Console.WriteLine("----------------");
                enemy.ActiveCichnamon.Info();

                Console.WriteLine("1 - Normal Attack");
                Console.WriteLine("2 - Special Attack");
                Console.WriteLine("3 - Heal");

                int action = int.Parse(Console.ReadLine());

                if (action == 1)
                {
                    player.ActiveCichnamon.UseNormAtk(enemy.ActiveCichnamon);
                }
                else if (action == 2)
                {
                    if (player.ActiveCichnamon.SpecialReady)
                    { 
                        player.ActiveCichnamon.UseSpecAtk(enemy.ActiveCichnamon);
                    }
                    else
                    {
                        Console.WriteLine("Special attack is on cooldown!");
                    }
                }
                else if (action == 3)
                {
                    if (!player.ActiveCichnamon.HealUsed)
                    {
                        player.ActiveCichnamon.Heal(20);
                        player.ActiveCichnamon.HealUsed = true;
                    }
                    else
                    {
                        Console.WriteLine("You already used healing!"); //same here jak special
                    }

                }
                if (!enemy.ActiveCichnamon.IsAlive())
                { //kontrola jestli zije nepritel
                    break; //ukonci loop, funkci, etc.
                }
                Console.WriteLine(); //nepritel
                Console.WriteLine("ENEMY'S TURN");

                int enemyAction = random.Next(1, 3);
                if (enemyAction == 1)
                {
                    enemy.ActiveCichnamon.UseNormAtk(player.ActiveCichnamon);
                }
                else
                {
                    if (enemy.ActiveCichnamon.SpecialReady)
                    {
                        enemy.ActiveCichnamon.UseSpecAtk(player.ActiveCichnamon);
                    }
                    else
                    {
                        enemy.ActiveCichnamon.UseNormAtk(player.ActiveCichnamon);
                    }
                }
            }

            Console.WriteLine(); 
            if (player.ActiveCichnamon.IsAlive())
            {
                Console.WriteLine("YOU WIN! You receive a kebab for your almighty battle in the CichnArena! And also you leveled up.");
                player.Level++;
                enemy.Level++;
                Console.WriteLine("You have reached level: " + player.Level);

                Console.WriteLine("Choose an upgrade: ");
                Console.WriteLine("1 - +15 max health \n 2 - +2 attack bonus \n 3 - Gamble?");

                #region Upgrade

                int upgrade = int.Parse(Console.ReadLine());

                if (upgrade == 1)
                {
                    player.ActiveCichnamon.MaxHealth += 15;
                }
                else if (upgrade == 2)
                {
                    player.ActiveCichnamon.ExtraAtk += 2;
                }
                else
                {
                    int playergamble = random.Next(1, 4);
                    if (playergamble == 1)
                    {
                        player.ActiveCichnamon.MaxHealth += 35;
                        Console.WriteLine("What a win! You received 35 more max health!");
                    }
                    else if (playergamble == 2)
                    {
                        player.ActiveCichnamon.ExtraAtk += 5;
                        Console.WriteLine("Boom! You gained +5 bonus attack!");
                    }
                    else if (playergamble == 3)
                    {
                        Console.WriteLine("Not today.. you didn't gain anything.");
                    }
                    else if (playergamble == 4)
                    {
                        player.ActiveCichnamon.MaxHealth -= 7;
                        player.ActiveCichnamon.ExtraAtk -= 1;
                        Console.WriteLine("Well this sucks. You lost 7 max health and 1 bonus attack.");
                    }
                }

                    Console.WriteLine("Stronger enemies ahead! (they level up)");
                    int enemyUpgrade = random.Next(1, 3);
                    if (enemyUpgrade == 1)
                    {
                        enemy.ActiveCichnamon.MaxHealth += 15;
                        Console.WriteLine("The enemy is more buffy!");
                    }
                    else if (enemyUpgrade == 2)
                    {
                        enemy.ActiveCichnamon.ExtraAtk += 2;
                        Console.WriteLine("The enemy is stronger!");
                    }
                    else if (enemyUpgrade == 3)
                    {
                        int enemygamble = random.Next(1, 3);
                        if (enemygamble == 1)
                        {
                            enemy.ActiveCichnamon.MaxHealth += 35;
                            Console.WriteLine("The enemies took vitamins. +35 max health");
                        }
                        else if (enemygamble == 2)
                        {
                            enemy.ActiveCichnamon.ExtraAtk += 5;
                            Console.WriteLine("Yup, the enemies found cricket's head. +5 bonus attack");
                        }
                        else if (enemygamble == 3)
                        {
                            Console.WriteLine("Welp that sucks for them! The enemies lost the gamble!");
                        }





                     

                    }

#endregion Upgrade

                player.ActiveCichnamon.Health = player.ActiveCichnamon.MaxHealth;
                enemy.ActiveCichnamon.Health = enemy.ActiveCichnamon.MaxHealth;
                player.ActiveCichnamon.HealUsed = false;
                enemy.ActiveCichnamon.HealUsed = false;
                player.ActiveCichnamon.SpecialReady = true;
                enemy.ActiveCichnamon.SpecialReady = true;

                player.ActiveCichnamon.Info();

                Console.WriteLine("Continue? 1 - Yes \n 2 - No");
                int Continue = int.Parse(Console.ReadLine());
                if (Continue == 2)
                {
                    playing = false;
                }
                else
                {
                    playing = true;
                    enemy.ActiveCichnamon.IsAlive();
                }
            }
                
            else
            {
                Console.WriteLine("YOU LOST! No kebab for you!!!! >:(");
                playing = false;
            }
                


        }
    }
}