using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_PlayerInfo_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<PlayerData> player_1List = new List<PlayerData>();
            List<PlayerData> player_2List = new  List<PlayerData>();

            PlayerData playerInstance = new PlayerData();
            playerInstance.PlayerNo = 23;
            playerInstance.PlayerName = "Ronaldo";
            playerInstance.PlayerGoals = 400;
            playerInstance.Countries = Countries.Brazil;

            playerInstance.Clubs = new List<Clubs>();
            playerInstance.Clubs.Add(Clubs.ManchesterUnited);
            playerInstance.Clubs.Add(Clubs.Juventus);
            playerInstance.Clubs.Add(Clubs.InterMilan);
            playerInstance.Clubs.Add(Clubs.RealMadrid);


            PlayerData playerInstance2 = new PlayerData();
            playerInstance2.PlayerNo = 44;
            playerInstance2.PlayerName = "Neymar";
            playerInstance2.PlayerGoals = 200;
            playerInstance2.Countries = Countries.Cambodia;

            playerInstance2.Clubs = new List<Clubs>();
            playerInstance2.Clubs.Add(Clubs.Arsenal);
            playerInstance2.Clubs.Add(Clubs.ASRoma);
            playerInstance2.Clubs.Add(Clubs.TottenhamHotspur);

            PlayerData playerInstance3 = new PlayerData();
            playerInstance3.PlayerNo = 88;
            playerInstance3.PlayerName = "Messi";
            playerInstance3.PlayerGoals = 900;
            playerInstance3.Countries = Countries.Brazil;

            playerInstance3. Clubs = new List<Clubs>();
            playerInstance3.Clubs.Add(Clubs.Arsenal);
            playerInstance3.Clubs.Add(Clubs.ASRoma);
            playerInstance3.Clubs.Add(Clubs.NewcastleUnited);

            
            player_1List.Add(playerInstance);
            
            player_2List.Add(playerInstance2);
            player_2List.Add(playerInstance3);

            Console.WriteLine("First List");
            Console.WriteLine("*********************");
            ShowPlayerInformation(player_1List);

            Console.WriteLine("Second List");
            Console.WriteLine("*********************");
            ShowPlayerInformation(player_2List);

        }

        public static void ShowPlayerInformation(List<PlayerData> playerInformation) 
        {
            foreach (var item in playerInformation)
            {
                Console.WriteLine("Player No                :  " +item.PlayerNo);
                Console.WriteLine("Player Name              :  " +item.PlayerName);
                Console.WriteLine("Player Country           :  " +item.Countries);
                Console.WriteLine("Player Goals             :  " +item.PlayerGoals);

                if (!(playerInformation == null))
                {
                    if (playerInformation.Count > 0)
                    {
                        Console.Write("Clubs are                :  ");
                        foreach (var clubs in item.Clubs)
                        {
                            Console.Write(clubs+" , ");

                        }

                    }
                }
                Console.WriteLine("\n------------------------------\n");
               
            }
        }
    }

    class PlayerData 
    {
        private int playerNo;

        public int PlayerNo
        {
            get { return playerNo; }
            set { playerNo = value; }
        }

        private string playerName;

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        private int playerGoals;

        public int PlayerGoals
        {
            get { return playerGoals; }
            set { playerGoals = value; }
        }
        private Countries countries;

        public Countries Countries
        {
            get { return countries; }
            set { countries = value; }
        }
        private List<Clubs> clubs;

        public List<Clubs> Clubs
        {
            get { return clubs; }
            set { clubs = value; }
        }

    }

    enum Clubs
    {
        RealMadrid,
        Barcelona,
        ManchesterUnited,
        Chelsea,
        Arsenal,
        NewcastleUnited,
        Everton,
        Schalke,
        InterMilan,
        ASRoma,
        TottenhamHotspur,
        AtleticoMadrid,
        BorussiaDortmund,
        ManchesterCity,
        Juventus,
        ParisSaintGermain,
        ACMilan,
        Liverpool,
        BayernMunich

    }

    enum Countries
    {
        Afghanistan,
        Albania,
        Algeria,
        Angola,
        Argentina,
        Australia,
        Austria,
        Bahamas,
        Bahrain,
        Bangladesh,
        Belarus,
        Belgium,
        Bolivia,
        Botswana,
        Brazil,
        Brunei,
        Bulgaria,
        BurkinaFaso,
        Burundi,
        Cambodia,
        Cameroon,
        Canada,
        Chad,
        Chile,
        China,
        Colombia,
       
    }
}
