using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Originally made by Sietse Dijks
// Releasedate: 18-01-2014
// Current version: 1.5
// Last changes by: Michiel Pot and Alex van Pelt
// Change Date: 09-01-2015

namespace TextAdventureCS
{
    class Program
    {
        // Define the directions available to the player.
        // Refactored by Michiel and Alex
        const string MOVE_NORTH = "Go North";
        const string MOVE_WEST = "Go West";
        const string MOVE_SOUTH = "Go South";
        const string MOVE_EAST = "Go East";
        
        // Cluster the directions for validation purposes.
        // Refactored by Michiel and Alex
        static List<string> validDirections = new List<string> {
            MOVE_NORTH, 
            MOVE_WEST, 
            MOVE_SOUTH, 
            MOVE_EAST        
        };

        // Refactored by Michiel and Alex
        const string ACTION_SEARCH = "Search";
        const string ACTION_FIGHT = "Fight";
        const string ACTION_RUN = "Run";
        const string ACTION_QUIT = "Exit";
        const string ACTION_BOSS = "Boss fight";
        const string ACTION_INN = "Go to the inn";
        const string ACTION_INV = "Show inventory";
        const string ACTION_STATS = "Show stats";
        const string ACTION_TREASURE = "Take the treasure";
        const string ACTION_HEAL = "Use a potion";

        static void Main(string[] args)
        {
            // General initializations to prevent magic numbers
            int mapwidth = 13;
            int mapheight = 13;
            int ystartpos = 2;
            int xstartpos = 2;
            
            // Welcome the player
            Console.WriteLine("Welcome to a textbased adventure");
            Console.WriteLine("Before you can start your journey, you will have to enter your name.");

            string name = null;
            string input = null;

            // Check for the correct name
            // Refactored from do - while to improve readability by Michiel and Alex
            while(input != "Y") 
            {
                if( input == null || input == "N" )
                {
                    do 
                    { 
                    Console.WriteLine("Please enter your name and press enter:");
                    name = Console.ReadLine();
                    }
                    while (name == "");
                }

                Console.WriteLine("Your name is {0}",name);
                Console.WriteLine("Is this correct? (y/n)");
                input = Console.ReadLine();
                input = input.ToUpper();
            }           

            // Make the player and monsters
            Player player = new Player(name, 100, 1, 1); 
            Bandit bandit = new Bandit("Bandit");
            Spider spider = new Spider("Giant spider");
            Skeleton skeleton = new Skeleton("Skeleton");
            Skeleton1 skeleton1 = new Skeleton1("Skeleton");
            Skeleton2 skeleton2 = new Skeleton2("Skeleton");
            Kraken kraken = new Kraken("Kraken");
            Bchief bchief = new Bchief("Bandit chief");
            DwarfKing dking = new DwarfKing("Ðurin");
            Zealot zealot = new Zealot("Zealot");
            Troll troll = new Troll("Troll");
            Snake snake = new Snake("Snake");
            
            //Welcome the player
            Welcome(ref player);

            // Initialize the map
            Map map = new Map(mapwidth, mapheight, xstartpos, ystartpos, ref player);
            // Put the locations with their items on the map
            InitMap(ref map);
            // Start the game
            Start(ref map, ref player, ref bandit, ref spider, ref skeleton, ref skeleton1, 
                ref skeleton2, ref kraken, ref bchief, ref dking, ref zealot, ref troll, ref snake);
            // End the program
            Quit();
        }
 
        static void Welcome(ref Player player)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the world of Valenwood");
            Console.WriteLine("You are a graverobber named {0}.", player.GetName());
            Console.WriteLine("While staying in an Inn, you overheard a story about the grave of an old ");
            Console.WriteLine("Mountain Dwarf King, said to be riddled with gold and other treasures.");
            Console.WriteLine("You decide to go and search for his grave, located deep within the tomb");
            Console.WriteLine("of Dunbarrow.");

            // Added new line to improve readability.
            Console.WriteLine();

            player.ShowInventory();
            Console.WriteLine("You exit the Inn, located in the town of Mana");
            Console.WriteLine("After asking around a little, you decide to start going.");
            Console.WriteLine("Press a key to continue..");
            Console.ReadKey();
        }

        static void InitMap(ref Map map)
        {
            // Add locations with their coordinates to this list.
            Forest forest = new Forest("Woodhearth");
            map.AddLocation(forest, 3, 2);
            map.AddLocation(forest, 4, 2);
            map.AddLocation(forest, 1, 4);
            Cliff cliff = new Cliff("The Hanger");
            map.AddLocation(cliff, 1, 5);
            Church church = new Church("Church of Stendarr");
            map.AddLocation(church, 3, 4);
            Swamp swamp = new Swamp("Bog");
            map.AddLocation(swamp, 4, 1);
            Town town = new Town("Mana");
            map.AddLocation(town, 2, 2);
            Ravine ravine = new Ravine("High pass");
            map.AddLocation(ravine, 1, 2);
            Lake lake = new Lake("Black Lake");
            map.AddLocation(lake, 0, 2);
            Tomb tomb = new Tomb("Dunbarrow");
            map.AddLocation(tomb, 4, 3);
            Road road = new Road("Road");
            map.AddLocation(road, 2, 1);
            map.AddLocation(road, 2, 0);
            map.AddLocation(road, 2, 3);
            map.AddLocation(road, 2, 4);
            Castle castle = new Castle("Dragonstar");
            map.AddLocation(castle, 1, 0);
            CastleArmory castleArmory = new CastleArmory("Dragonstar armory");
            map.AddLocation(castleArmory, 0, 0);
            TombHall tombHall = new TombHall("Tombhall1");
            map.AddLocation(tombHall, 5, 3);
            map.AddLocation(tombHall, 8, 1);
            TombHall1 tombHall1 = new TombHall1("Tombhall2");
            map.AddLocation(tombHall1, 7, 5);
            map.AddLocation(tombHall1, 9, 2);
            TombHall2 tombHall2 = new TombHall2("Tombhall3");
            map.AddLocation(tombHall2, 7, 2);
            map.AddLocation(tombHall2, 9, 3);
            TombRoom tombRoom = new TombRoom("Tombroom1");
            map.AddLocation(tombRoom, 6, 3);
            TombRoom1 tombRoom1 = new TombRoom1("Tombroom2");
            map.AddLocation(tombRoom1, 5, 4);
            map.AddLocation(tombRoom1, 7, 4);
            map.AddLocation(tombRoom1, 7, 1);
            TombRoom2 tombRoom2 = new TombRoom2("Tombroom3");
            map.AddLocation(tombRoom2, 5, 5);
            map.AddLocation(tombRoom2, 6, 2);
            map.AddLocation(tombRoom2, 9, 1);
            TombRoom3 tombroom3 = new TombRoom3("Tombroom4");
            map.AddLocation(tombRoom, 6, 5);
            map.AddLocation(tombRoom, 6, 1);
            map.AddLocation(tombRoom, 10, 3);            
            TombTreasure tombTreasure = new TombTreasure("TombTreasureRoom");
            map.AddLocation(tombTreasure, 11, 3);
            TombTreasure1 tombTreasure1 = new TombTreasure1("TombTreasureRoom1");
            map.AddLocation(tombTreasure1, 12, 3);
        }

        static void Start(ref Map map, ref Player player, ref Bandit bandit, ref Spider spider, ref Skeleton skeleton, 
            ref Skeleton1 skeleton1, ref Skeleton2 skeleton2, ref Kraken kraken, ref Bchief bchief, ref DwarfKing dking,
            ref Zealot zealot, ref Troll troll, ref Snake snake)            
        {
            List<string> menuItems = new List<string>();
            int choice;

            // Refactored by Michiel and Alex
            do
            {
                Console.Clear();
                map.GetLocation().Description();
                choice = ShowMenu(map, ref menuItems, ref player);
                
                if ( choice != menuItems.Count() )
                {
                    if ( validDirections.Contains( menuItems[choice] ) )
                    {
                        map.Move( menuItems[choice] );
                    }
                    
                    switch ( menuItems[choice] )
                    {       
                        case ACTION_HEAL:

                            player.HealPlayer(player);
                            player.CheckHealth(player);

                            break;
                        case ACTION_TREASURE:                            
                            Console.WriteLine("You return to Mana with your spoils and live a happy life");
                            Console.WriteLine("The game is now technically over, but feel free to wander around.");
                            Console.WriteLine("");
                            Console.WriteLine("Thanks for playing!");
                            Console.WriteLine("Made by: Thom Martens, Kevin Rademacher and Bas Overvoorde");
                            Console.ReadKey();
                            break;

                        case ACTION_STATS:
                            player.ShowStats(player);
                            Console.ReadKey();
                            break;
                        
                        case ACTION_INV:
                            player.ShowInventory();
                            Console.ReadKey();
                        break;

                        case ACTION_SEARCH:
                            Console.Clear();

                            Dictionary<string, Objects> list = map.GetLocation().GetItems();
                            Objects[] obj = list.Values.ToArray();
                            for (int i = 0; i < obj.Count(); i++)
                            {
                                if (obj[i].GetAcquirable())
                                {
                                    player.PickupItem(obj[i]);
                                }
                                Console.ReadKey();
                            }
                            player.HasStrBuff(player);
                            player.HasArmBuff(player);
                        break;

                        case ACTION_FIGHT:
                                                
                        map.GetLocation().hasEnemy = true;

                        //church fight
                        if (map.GetLocation().GetName() == "Church of Stendarr")
                        {
                            Console.WriteLine("You encounter a {0}!", zealot.GetName());
                            Console.WriteLine("Health:{0}/{1}", zealot.health, zealot.maxhealth);
                            Console.WriteLine("Strenght:{0}", zealot.GetStr());
                            // Console.WriteLine("Thoughness: {0}", zealot.GetThough());
                            Console.WriteLine("Examine: {0}", zealot.Description());
                            Console.ReadKey();

                            if (zealot.health > 0)
                            {
                                Console.WriteLine("The {0} hits you with his sword!", zealot.GetName());
                                player.TakeHit(zealot.GetStr() - player.GetThough());
                                zealot.health = zealot.health -= player.GetStr();
                                Console.WriteLine("You strike the {0} with your weapon.", zealot.GetName());
                                Console.WriteLine("You deal {0} damage", player.GetStr());
                                if (zealot.health > 0)
                                {
                                    Console.WriteLine("The {0} has {1} health left.", zealot.GetName(), zealot.health);
                                }
                                else if (zealot.health <= 0)
                                {
                                    zealot.health = 0;
                                    Console.WriteLine("The {0} has {1} health left", zealot.GetName(), zealot.health);
                                }
                                Console.ReadKey();
                            }

                            if (zealot.health <= 0)
                            {
                                Console.WriteLine("The {0} is dead.", zealot.GetName());
                                map.GetLocation().hasEnemy = false;
                                Console.ReadKey();
                            }
                        }
                       
                        if (map.GetLocation().GetName() == "Bog")
                        {
                            Console.WriteLine("You encounter a {0}!", snake.GetName());
                            Console.WriteLine("Health:{0}/{1}", snake.health, snake.maxhealth);
                            Console.WriteLine("Strenght:{0}", snake.GetStr());
                           // Console.WriteLine("Thoughness: {0}", zealot.GetThough());
                            Console.WriteLine("Examine: {0}", snake.Description());
                            Console.ReadKey();

                            if (snake.health > 0)
                            {
                                Console.WriteLine("The {0} tries to bite you!", snake.GetName());
                                player.TakeHit(snake.GetStr() - player.GetThough());
                                snake.health = snake.health -= player.GetStr() ;
                                Console.WriteLine("You strike the {0} with your weapon.", snake.GetName());
                                Console.WriteLine("You deal {0} damage", player.GetStr());
                                if (snake.health > 0)
                                {
                                    Console.WriteLine("The {0} has {1} health left.", snake.GetName(), snake.health);
                                }
                                else if (snake.health <= 0)
                                {
                                    snake.health = 0;
                                    Console.WriteLine("The {0} has {1} health left", snake.GetName(), snake.health);
                                }
                                Console.ReadKey();
                            }

                            if (snake.health <= 0)
                            {
                                Console.WriteLine("The {0} is dead.", snake.GetName());
                                map.GetLocation().hasEnemy = false;
                                Console.ReadKey();
                            }
                        }


                        if (map.GetLocation().GetName() == "Dragonstar")
                        {
                            Console.WriteLine("You encounter a {0}!", bandit.GetName());
                            Console.WriteLine("Health:{0}/{1}", bandit.health, bandit.maxhealth);
                            Console.WriteLine("Strenght:{0}", bandit.GetStr());
                            //Console.WriteLine("Thoughness: {0}", bandit.GetThough());
                            Console.WriteLine("Examine: {0}", bandit.Description());
                            Console.ReadKey();

                            if (bandit.health > 0)
                            {
                                Console.WriteLine("The {0} hits you with his sword!", bandit.GetName());
                                player.TakeHit(bandit.GetStr() - player.GetThough());
                                bandit.health = bandit.health -= player.GetStr();
                                Console.WriteLine("You strike the {0} with your weapon.", bandit.GetName());
                                if (bandit.health > 0)
                                {
                                    Console.WriteLine("The {0} has {1} health left.", bandit.GetName(), bandit.health);
                                }
                                else if (bandit.health <= 0)
                                {
                                    bandit.health = 0;
                                    Console.WriteLine("The {0} has {1} health left", bandit.GetName(), bandit.health);
                                }
                                Console.ReadKey();
                            }

                            if (bandit.health <= 0)
                            {
                                Console.WriteLine("The {0} is dead.", bandit.GetName());
                                map.GetLocation().hasEnemy = false;
                                Console.ReadKey();
                            }
                        }
                            //forest fight
                        if (map.GetLocation().GetName() == "Woodhearth")
                        {
                            Console.WriteLine("You encounter a {0}!", spider.GetName());
                            Console.WriteLine("Health:{0}/{1}", spider.health, spider.maxhealth);
                            Console.WriteLine("Strenght:{0}", spider.GetStr());
                            //Console.WriteLine("Thoughness: {0}", spider.GetThough());
                            Console.WriteLine("Examine: {0}", spider.Description());
                            Console.ReadKey();

                            if (spider.health > 0)
                            {
                                Console.WriteLine("The {0} hits you with his huge fangs!", spider.GetName());
                                player.TakeHit(spider.GetStr() - player.GetThough());
                                spider.health = spider.health - player.GetStr();
                                Console.WriteLine("You strike the {0} with your weapon.", spider.GetName());
                                if (spider.health > 0)
                                {
                                    Console.WriteLine("The {0} has {1} health left.", spider.GetName(), spider.health);
                                }
                                else if (spider.health <= 0)
                                {
                                    spider.health = 0;
                                    Console.WriteLine("The {0} has {1} health left", spider.GetName(), spider.health);
                                }

                                Console.ReadKey();
                            }

                            if (spider.health <= 0)
                            {
                                spider.health = 0;
                                Console.WriteLine("The {0} is dead.", spider.GetName());
                                map.GetLocation().hasEnemy = false;
                                Console.ReadKey();
                            }
                        }
                            //tombroom fight

                        if (map.GetLocation().GetName() == "Tombroom1")
                        {
                            Console.WriteLine("You encounter a {0}!", skeleton.GetName());                           
                            Console.WriteLine("Health:{0}/{1}", skeleton.health, skeleton.maxhealth);
                            Console.WriteLine("Strenght:{0}", skeleton.GetStr());
                            //Console.WriteLine("Thoughness: {0}", skeleton.GetThough());
                            Console.WriteLine("Examine: {0}", skeleton.Description());
                            Console.ReadKey();

                            if (skeleton.health > 0)
                            {
                                Console.WriteLine("The {0} hits you with his Giant Axe!", skeleton.GetName());
                                player.TakeHit(skeleton.GetStr() - player.GetThough());
                                skeleton.health = skeleton.health -= player.GetStr();
                                Console.WriteLine("You strike the {0} with your weapon.", skeleton.GetName());
                                if (skeleton.health > 0)
                                {
                                    Console.WriteLine("The {0} has {1} health left.", skeleton.GetName(), skeleton.health);
                                }
                                else if (skeleton.health <= 0)
                                {
                                    skeleton.health = 0;
                                    Console.WriteLine("The {0} has {1} health left", skeleton.GetName(), skeleton.health);
                                }
                                Console.ReadKey();
                            }

                            if (skeleton.health <= 0)
                            {
                                Console.WriteLine("The {0} is dead.", skeleton.GetName());
                                map.GetLocation().hasEnemy = false;
                                Console.ReadKey();
                            }
                        }
                            //tombroom1 fight

                        if (map.GetLocation().GetName() == "Tombroom2")
                        {
                            Console.WriteLine("You encounter a {0}!", skeleton1.GetName());
                            Console.WriteLine("Health:{0}/{1}", skeleton1.health, skeleton1.maxhealth);
                            Console.WriteLine("Strenght:{0}", skeleton1.GetStr());
                            //Console.WriteLine("Thoughness: {0}", skeleton1.GetThough());
                            Console.WriteLine("Examine: {0}", skeleton1.Description());
                            Console.ReadKey();
                            if (skeleton1.health > 0)
                            {
                                Console.WriteLine("The {0} shoots at you with his bow!", skeleton1.GetName());
                                player.TakeHit(skeleton1.GetStr() - player.GetThough());
                                skeleton1.health = skeleton1.health -= player.GetStr();
                                Console.WriteLine("You strike the {0} with your weapon.", skeleton1.GetName());
                                if (skeleton1.health > 0)
                                {
                                    Console.WriteLine("The {0} has {1} health left.", skeleton1.GetName(), skeleton1.health);
                                }
                                else if (skeleton1.health <= 0)
                                {
                                    skeleton1.health = 0;
                                    Console.WriteLine("The {0} has {1} health left", skeleton1.GetName(), skeleton1.health);
                                }
                                Console.ReadKey();
                            }
                            if (skeleton1.health <= 0)
                            {
                                Console.WriteLine("The {0} is dead.", skeleton1.GetName());
                                map.GetLocation().hasEnemy = false;
                                Console.ReadKey();
                            }
                        }
                        //tombroom2 fight
                        if (map.GetLocation().GetName() == "Tombroom3")
                        {
                            Console.WriteLine("You encounter a {0}!", skeleton2.GetName());
                            Console.WriteLine("Health:{0}/{1}", skeleton2.health, skeleton2.maxhealth);
                            Console.WriteLine("Strenght:{0}", skeleton2.GetStr());
                            //Console.WriteLine("Thoughness: {0}", skeleton2.GetThough());
                            Console.WriteLine("Examine: {0}", skeleton2.Description());
                            Console.ReadKey();
                            if (skeleton2.health > 0)
                            {
                                Console.WriteLine("The {0} strikes you with his sword!", skeleton2.GetName());
                                player.TakeHit(skeleton2.GetStr() - player.GetThough());
                                skeleton2.health = skeleton2.health -= player.GetStr();
                                Console.WriteLine("You strike the {0} with your weapon.", skeleton2.GetName());
                                if (skeleton2.health > 0)
                                {
                                    Console.WriteLine("The {0} has {1} health left.", skeleton2.GetName(), skeleton2.health);
                                }
                                else if (skeleton2.health <= 0)
                                {
                                    skeleton2.health = 0;
                                    Console.WriteLine("The {0} has {1} health left", skeleton2.GetName(), skeleton2.health);
                                }
                                Console.ReadKey();
                            }
                            if (skeleton2.health <= 0)
                            {
                                Console.WriteLine("The {0} is dead.", skeleton2.GetName());
                                map.GetLocation().hasEnemy = false;
                                Console.ReadKey();
                            }
                        }
                        //tombroom 3 fight
                        if (map.GetLocation().GetName() == "Tombroom4")
                        {
                            Console.WriteLine("You encounter a {0}!", skeleton.GetName());
                            Console.WriteLine("Health:{0}/{1}", skeleton.health, skeleton.maxhealth);
                            Console.WriteLine("Strenght:{0}", skeleton.GetStr());
                            //Console.WriteLine("Thoughness: {0}", skeleton.GetThough());
                            Console.WriteLine("Examine: {0}", skeleton.Description());
                            Console.ReadKey();

                            if (skeleton.health > 0)
                            {
                                Console.WriteLine("The {0} hits you with his Giant Axe!", skeleton.GetName());
                                player.TakeHit(skeleton.GetStr() - player.GetThough());
                                skeleton.health = skeleton.health -= player.GetStr();
                                Console.WriteLine("You strike the {0} with your weapon.", skeleton.GetName());
                                if (skeleton.health > 0)
                                {
                                    Console.WriteLine("The {0} has {1} health left.", skeleton.GetName(), skeleton.health);
                                }
                                else if (skeleton.health <= 0)
                                {
                                    skeleton.health = 0;
                                    Console.WriteLine("The {0} has {1} health left", skeleton.GetName(), skeleton.health);
                                }
                                Console.ReadKey();
                            }

                            if (skeleton.health <= 0)
                            {
                                Console.WriteLine("The {0} is dead.", skeleton.GetName());
                                map.GetLocation().hasEnemy = false;
                                Console.ReadKey();
                            }
                        }
                            //troll fight
                        if (map.GetLocation().GetName() == "The Hanger")
                        {
                            Console.WriteLine("You encounter a {0}!", troll.GetName());
                            Console.WriteLine("Health:{0}/{1}", troll.health, troll.maxhealth);
                            Console.WriteLine("Strenght:{0}", troll.GetStr());
                            //Console.WriteLine("Thoughness: {0}", spider.GetThough());
                            Console.WriteLine("Examine: {0}", troll.Description());
                            Console.ReadKey();

                            if (troll.health > 0)
                            {
                                Console.WriteLine("The {0} hits you with his giant club!", troll.GetName());
                                player.TakeHit(troll.GetStr() - player.GetThough());
                                troll.health = troll.health - player.GetStr();
                                Console.WriteLine("You strike the {0} with your weapon.", troll.GetName());
                                if (troll.health > 0)
                                {
                                    Console.WriteLine("The {0} has {1} health left.", troll.GetName(), troll.health);
                                }
                                else if (troll.health <= 0)
                                {
                                    troll.health = 0;
                                    Console.WriteLine("The {0} has {1} health left", troll.GetName(), troll.health);
                                }

                                Console.ReadKey();
                            }

                            if (troll.health <= 0)
                            {
                                troll.health = 0;
                                Console.WriteLine("The {0} is dead.", troll.GetName());
                                map.GetLocation().hasEnemy = false;
                                Console.ReadKey();
                            }
                        }
                        break;

                        case ACTION_RUN:
                        map.Run();
                        Console.WriteLine("You run away to {0}", map.GetLocation().GetName());
                        Console.ReadKey();
                        break;

                        case ACTION_BOSS:

                        map.GetLocation().hasBossEnemy = true;
                            //kraken boss
                        if (map.GetLocation().GetName() == "Black Lake")
                        {
                            Console.WriteLine("You encounter a {0}!", kraken.GetName());
                            Console.WriteLine("Health:{0}/{1}", kraken.health, kraken.maxhealth);
                            Console.WriteLine("Strenght:{0}", kraken.GetStr());
                            //Console.WriteLine("Thoughness: {0}", kraken.GetThough());
                            Console.WriteLine("Examine: {0}", kraken.Description());
                            Console.ReadKey();
                            if (kraken.health > 0)
                            {
                                Console.WriteLine("The {0} strikes you with his tentacles!", kraken.GetName());
                                player.TakeHit(kraken.GetStr() - player.GetThough());
                                kraken.health = kraken.health -= player.GetStr();
                                Console.WriteLine("You strike the {0} with your weapon.", kraken.GetName());
                                if (kraken.health > 0)
                                {
                                    Console.WriteLine("The {0} has {1} health left.", kraken.GetName(), kraken.health);
                                }
                                else if (kraken.health <= 0)
                                {
                                    kraken.health = 0;
                                    Console.WriteLine("The {0} has {1} health left", kraken.GetName(), kraken.health);
                                }
                                Console.ReadKey();
                            }
                            if (kraken.health <= 0)
                            {
                                Console.WriteLine("The {0} is dead.", kraken.GetName());
                                map.GetLocation().hasBossEnemy = false;
                                Console.ReadKey();
                            }
                        }
                            //chief bandit
                        if (map.GetLocation().GetName() == "Dragonstar armory")
                        {
                            Console.WriteLine("You encounter the {0}!", bchief.GetName());
                            Console.WriteLine("Health:{0}/{1}", bchief.health, bchief.maxhealth);
                            Console.WriteLine("Strenght:{0}", bchief.GetStr());
                            //Console.WriteLine("Thoughness: {0}", bchief.GetThough());
                            Console.WriteLine("Examine: {0}", bchief.Description());
                            Console.ReadKey();
                            if (bchief.health > 0)
                            {
                                Console.WriteLine("The {0} strikes you with his basterdsword!", bchief.GetName());
                                player.TakeHit(bchief.GetStr() - player.GetThough());
                                bchief.health = bchief.health -= player.GetStr();
                                Console.WriteLine("You strike the {0} with your weapon.", bchief.GetName());
                                Console.WriteLine("The {0} has {1} health left.", bchief.GetName(), bchief.health);
                                Console.ReadKey();
                            }
                            if (bchief.health <= 0)
                            {
                                Console.WriteLine("The {0} is dead.", bchief.GetName());
                                map.GetLocation().hasBossEnemy = false;
                                Console.ReadKey();
                            }
                        }
                            //dwarf king fight
                        if (map.GetLocation().GetName() == "TombTreasureRoom")
                        {
                            Console.WriteLine("You encounter {0}!", dking.GetName());
                            Console.WriteLine("Health:{0}/{1}", dking.health, dking.maxhealth);
                            Console.WriteLine("Strenght:{0}", dking.GetStr());
                            //Console.WriteLine("Thoughness: {0}", dking.GetThough());
                            Console.WriteLine("Examine: {0}", dking.Description());
                            Console.ReadKey();
                            if (dking.health > 0)
                            {
                                Console.WriteLine("The {0} strikes you with his Axe!", dking.GetName());
                                player.TakeHit(dking.GetStr() - player.GetThough());
                                dking.health = dking.health -= player.GetStr();
                                Console.WriteLine("You strike the {0} with your weapon.", dking.GetName());
                                Console.WriteLine("The {0} has {1} health left.", dking.GetName(), dking.health);
                                Console.ReadKey();
                            }
                            if (dking.health <= 0)
                            {
                                Console.WriteLine("The {0} is dead.", dking.GetName());
                                map.GetLocation().hasBossEnemy = false;
                                Console.ReadKey();
                            }
                        }
                        break;

                        case ACTION_INN:
                        player.SetHealth();
                        Console.WriteLine("You have been healed!");
                        Console.ReadKey();
                        break;
                    }
                }
            } 
            // When the choice is equal to the total item it means exit has been chosen.
            while ( choice < menuItems.Count() - 1);
        }

        // This Method builds the menu
        static int ShowMenu(Map map, ref List<string> menu, ref Player player)
        {
            int choice;
            string input;

            menu.Clear();
            if (!map.GetLocation().hasBossEnemy == false || map.GetLocation().hasEnemy == false)
            {
                ShowDirections(map, ref menu);
            
                if (map.GetLocation().CheckForItems())
                {
                    bool acquirableitems = false;
                    Dictionary<string, Objects> list = map.GetLocation().GetItems();
                    Objects[] obj = list.Values.ToArray();
                    for (int i = 0; i < obj.Count(); i++)
                    {
                        if (obj[i].GetAcquirable())
                            acquirableitems = true;
                    }
                    if (acquirableitems)
                        menu.Add(ACTION_SEARCH);
                }
            }

            if (map.GetLocation().HasEnemy())
            {
                menu.Add( ACTION_FIGHT );
                menu.Add( ACTION_RUN );
            }
            if (map.GetLocation().HasBossEnemy())
            {
                menu.Add(ACTION_BOSS);
            }
            if (map.GetLocation().HasInn())
            {
                menu.Add(ACTION_INN);
            }
            if (map.GetLocation().HasTreasure())
            {
                menu.Add(ACTION_TREASURE);
            }

            if (player.HasObject("Strong Health Potion") == true || player.HasObject("Weak Health Potion") == true)
            {
                menu.Add(ACTION_HEAL);
            }
            menu.Add(ACTION_STATS);
            menu.Add(ACTION_INV);
            menu.Add( ACTION_QUIT );

            do
            {
                for (int i = 0; i < menu.Count(); i++)
                {
                    Console.WriteLine("{0} - {1}", i + 1, menu[i]);
                }
                Console.WriteLine("Please enter your choice: 1 - {0}", menu.Count());
                input = Console.ReadLine();
            } while (!int.TryParse(input, out choice) || (choice > menu.Count() || choice < 0));

            //return choice
            return ( choice - 1 );
        }
        static void ShowDirections(Map map, ref List<string> items)
        {
            map.AllowedDirections();

            if (map.GetNorth() == 1)
                items.Add( MOVE_NORTH );
            if (map.GetEast() == 1)
                items.Add( MOVE_EAST );
            if (map.GetSouth() == 1)
                items.Add( MOVE_SOUTH );
            if (map.GetWest() == 1)
                items.Add( MOVE_WEST );
        }
        static void Quit()
        {
            Console.Clear();
            Console.WriteLine("Thank you for playing and have a nice day!");
            Console.WriteLine("Press a key to exit...");
            Console.ReadKey();
        }        
    }
}