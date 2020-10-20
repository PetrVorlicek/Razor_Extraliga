using System;
using System.Collections.Generic;
using System.Linq;
using EHL_Codecademy.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace EHL_Codecademy.Data
{
    public class DbInitializer
    {
        public static void Initialize(PlayerContext context)
        {
            //Ensure if db is created
            context.Database.EnsureCreated();
            if (context.Teams.Any())
            {
                return; // db has been seeded
            }

            //Seeding of a database
            try
            {
                //Teams
                var teams = new List<Team>
                {
                    new Team
                    {
                        //1
                        Name = "Bílí Tygři Liberec",
                        City = "Liberec",
                        ImgPath = "bilyTygri.png",
                        Wins = 30,
                        WinsOvertime = 5,
                        LossesOvertime = 2,
                        Losses = 15,
                        GoalsFor = 179,
                        GoalsAgainst = 131
                    },
                    new Team
                    {
                        //2
                        Name = "BK Mladá Boleslav",
                        City = "Mladá Boleslav",
                        ImgPath = "mladaBoleslav.png",
                        Wins = 22,
                        WinsOvertime = 10,
                        LossesOvertime = 6,
                        Losses = 14,
                        GoalsFor = 155,
                        GoalsAgainst = 124
                    },
                    new Team
                    {
                        //3
                        Name = "HC Dynamo Pardubice",
                        City = "Pardubice",
                        ImgPath = "dynamoPardubice.png",
                        Wins = 16,
                        WinsOvertime = 3,
                        LossesOvertime = 10,
                        Losses = 22,
                        GoalsFor = 121,
                        GoalsAgainst = 160
                    },
                    new Team
                    {
                        //4
                        Name = "HC Energie Karlovy Vary",
                        City = "Karlovy Vary",
                        ImgPath = "energieKarlovyVary.png",
                        Wins = 16,
                        WinsOvertime = 9,
                        LossesOvertime = 5,
                        Losses = 22,
                        GoalsFor = 174,
                        GoalsAgainst = 168
                    },
                    new Team
                    {
                        //5
                        Name = "HC Kometa Brno",
                        City = "Brno",
                        ImgPath = "kometaBrno.png",
                        Wins = 21,
                        WinsOvertime = 5,
                        LossesOvertime = 6,
                        Losses = 20,
                        GoalsFor = 143,
                        GoalsAgainst = 156
                    },
                    new Team
                    {
                        //6
                        Name = "HC Oceláři Třinec",
                        City = "Třinec",
                        ImgPath = "ocelariTrinec.png",
                        Wins = 27,
                        WinsOvertime = 4,
                        LossesOvertime = 4,
                        Losses = 17,
                        GoalsFor = 163,
                        GoalsAgainst = 125
                    },
                    new Team
                    {
                        //7
                        Name = "HC Olomouc",
                        City = "Olomouc",
                        ImgPath = "hcOlomouc.png",
                        Wins = 20,
                        WinsOvertime = 5,
                        LossesOvertime = 7,
                        Losses = 20,
                        GoalsFor = 123,
                        GoalsAgainst = 129
                    },
                    new Team
                    {
                        //8
                        Name = "HC Škoda Plzeň",
                        City = "Plzeň",
                        ImgPath = "skodaPlzen.png",
                        Wins = 27,
                        WinsOvertime = 2,
                        LossesOvertime = 7,
                        Losses = 16,
                        GoalsFor = 162,
                        GoalsAgainst = 142
                    },
                    new Team
                    {
                        //9
                        Name = "HC Sparta Praha",
                        City = "Praha",
                        ImgPath = "spartaPraha.png",
                        Wins = 21,
                        WinsOvertime = 14,
                        LossesOvertime = 1,
                        Losses = 16,
                        GoalsFor = 174,
                        GoalsAgainst = 145
                    },
                    new Team
                    {
                        //10
                        Name = "HC VERVA Litvínov",
                        City = "Litvínov",
                        ImgPath = "vervaLitvinov.png",
                        Wins = 16,
                        WinsOvertime = 3,
                        LossesOvertime = 9,
                        Losses = 24,
                        GoalsFor = 153,
                        GoalsAgainst = 173
                    },
                    new Team
                    {
                        //11
                        Name = "HC Vítkovice Ridera",
                        City = "Ostrava",
                        ImgPath = "vitkoviceRidera.png",
                        Wins = 14,
                        WinsOvertime = 8,
                        LossesOvertime = 5,
                        Losses = 25,
                        GoalsFor = 134,
                        GoalsAgainst = 175
                    },
                    new Team
                    {
                        //12
                        Name = "Mountfield HK",
                        City = "Hradec Králové",
                        ImgPath = "mountfieldHradecKralove.png",
                        Wins = 19,
                        WinsOvertime = 5,
                        LossesOvertime = 7,
                        Losses = 21,
                        GoalsFor = 130,
                        GoalsAgainst = 136
                    },
                    new Team
                    {
                        //13
                        Name = "PSG Berani Zlín",
                        City = "Zlín",
                        ImgPath = "beraniZlin.png",
                        Wins = 19,
                        WinsOvertime = 4,
                        LossesOvertime = 5,
                        Losses = 24,
                        GoalsFor = 151,
                        GoalsAgainst = 151
                    },
                    new Team
                    {
                        //14
                        Name = "Rytíři Kladno",
                        City = "Kladno",
                        ImgPath = "rytiriKladno.png",
                        Wins = 16,
                        WinsOvertime = 3,
                        LossesOvertime = 6,
                        Losses = 27,
                        GoalsFor = 130,
                        GoalsAgainst = 177
                    },

                };
                foreach(var team in teams)
                {
                    context.Teams.Add(team);
                }
                context.SaveChanges();

                //Players
                var players = new List<Player> 
                {
                    //Liberec
                    new Player
                    {
                        TeamID = 1,
                        PlayerNumber = 3,
                        Name = "Marek Schwarz",
                        ////Birthday = new DateTime(1986,4,1),
                        Position = "Brankář",
                        Stick = "Pravá",
                        Height = 180,
                        Weight = 86
                    },
                    new Player
                    {
                        TeamID = 1,
                        PlayerNumber = 35,
                        Name = "Justin William Peters",
                        ////Birthday = new DateTime(1986,8,30),
                        Position = "Brankář",
                        Stick = "Levá",
                        Height = 185,
                        Weight = 95
                    },
                    new Player
                    {
                        TeamID = 1,
                        PlayerNumber = 3,
                        Name = "Ronald Knot",
                        ////Birthday = new DateTime(1994,8,3),
                        Position = "Obránce",
                        Stick = "Pravá",
                        Height = 193,
                        Weight = 90
                    },
                    new Player
                    {
                        TeamID = 1,
                        PlayerNumber = 5,
                        Name = "Ladislav Šmíd",
                        ////Birthday = new DateTime(1986,2,1),
                        Position = "Obránce",
                        Stick = "Levá",
                        Height = 193,
                        Weight = 95
                    },
                    new Player
                    {
                        TeamID = 1,
                        PlayerNumber = 5,
                        Name = "Petr Kolmann",
                        ////Birthday = new DateTime(1988,9,20),
                        Position = "Obránce",
                        Stick = "Levá",
                        Height = 190,
                        Weight = 90
                    },
                    new Player
                    {
                        TeamID = 1,
                        PlayerNumber = 6,
                        Name = "Lukáš Derner",
                        ////Birthday = new DateTime(1983,8,24),
                        Position = "Obránce",
                        Stick = "Levá",
                        Height = 185,
                        Weight = 96
                    },
                    new Player
                    {
                        TeamID = 1,
                        PlayerNumber = 8,
                        Name = "Jan Šír",
                        ////Birthday = new DateTime(2000,1,26),
                        Position = "Útočník",
                        Stick = "Pravá",
                        Height = 187,
                        Weight = 88
                    },
                    new Player
                    {
                        TeamID = 1,
                        PlayerNumber = 9,
                        Name = "Ondřej Chrtek",
                        ////Birthday = new DateTime(1999,1,25),
                        Position = "Útočník",
                        Stick = "Levá",
                        Height = 185,
                        Weight = 75
                    },
                    new Player
                    {
                        TeamID = 1,
                        PlayerNumber = 14,
                        Name = "Adam Musil",
                        ////Birthday = new DateTime(1997,3,26),
                        Position = "Útočník",
                        Stick = "Pravá",
                        Height = 192,
                        Weight = 92
                    },
                    //MB
                    new Player
                    {
                        TeamID = 2,
                        PlayerNumber = 1,
                        Name = "Martin Michajlov",
                        ////Birthday = new DateTime(1994,2,2),
                        Position = "Brankář",
                        Stick = "Levá",
                        Height = 175,
                        Weight = 68
                    },
                    new Player
                    {
                        TeamID = 2,
                        PlayerNumber = 3,
                        Name = "Karel Klikorka",
                        ////Birthday = new DateTime(2001,11,30),
                        Position = "Obránce",
                        Stick = "Levá",
                        Height = 186,
                        Weight = 90
                    },
                    new Player
                    {
                        TeamID = 2,
                        PlayerNumber = 10,
                        Name = "Gabriel Szturc",
                        ////Birthday = new DateTime(2003,9,24),
                        Position = "Útočník",
                        Stick = "Levá",
                        Height = 179,
                        Weight = 78
                    },
                    //Pardubice
                    new Player
                    {
                        TeamID = 3,
                        PlayerNumber = 1,
                        Name = "Tomáš Vlk",
                        ////Birthday = new DateTime(2000,10,23),
                        Position = "Brankář",
                        Stick = "Levá",
                        Height = 186,
                        Weight = 78
                    },
                    new Player
                    {
                        TeamID = 3,
                        PlayerNumber = 2,
                        Name = "Juraj Mikuš",
                        ////Birthday = new DateTime(1988,11,30),
                        Position = "Obránce",
                        Stick = "Levá",
                        Height = 194,
                        Weight = 95
                    },
                    new Player
                    {
                        TeamID = 3,
                        PlayerNumber = 11,
                        Name = "Jan Kloz",
                        ////Birthday = new DateTime(1987,3,7),
                        Position = "Útočník",
                        Stick = "Levá",
                        Height = 176,
                        Weight = 82
                    },
                    //KV
                    new Player
                    {
                        TeamID = 4,
                        PlayerNumber = 1,
                        Name = "Jan Bednář",
                        ////Birthday = new DateTime(2002,8,26),
                        Position = "Brankář",
                        Stick = "Levá",
                        Height = 194,
                        Weight = 89
                    },
                    new Player
                    {
                        TeamID = 4,
                        PlayerNumber = 7,
                        Name = "Michal Plutnar",
                        ////Birthday = new DateTime(1994,2,21),
                        Position = "Obránce",
                        Stick = "Pravá",
                        Height = 186,
                        Weight = 76
                    },
                    new Player
                    {
                        TeamID = 4,
                        PlayerNumber = 5,
                        Name = "Tomáš Vondráček",
                        ////Birthday = new DateTime(1991,2,16),
                        Position = "Útočník",
                        Stick = "Levá",
                        Height = 190,
                        Weight = 95
                    },
                    //Brno
                    new Player
                    {
                        TeamID = 5,
                        PlayerNumber = 1,
                        Name = "Marek Čiliak",
                        ////Birthday = new DateTime(1990,4,2),
                        Position = "Brankář",
                        Stick = "Levá",
                        Height = 184,
                        Weight = 88
                    },
                    new Player
                    {
                        TeamID = 5,
                        PlayerNumber = 3,
                        Name = "Daniel Krenželok",
                        ////Birthday = new DateTime(1997,7,29),
                        Position = "Obránce",
                        Stick = "Levá",
                        Height = 191,
                        Weight = 85
                    },
                    new Player
                    {
                        TeamID = 5,
                        PlayerNumber = 8,
                        Name = "Jan Süss",
                        ////Birthday = new DateTime(1999,1,5),
                        Position = "Útočník",
                        Stick = "Levá",
                        Height = 185,
                        Weight = 81
                    },
                    //Třinec
                    new Player
                    {
                        TeamID = 6,
                        PlayerNumber = 30,
                        Name = "Jakub Štěpánek",
                        ////Birthday = new DateTime(1986,6,20),
                        Position = "Brankář",
                        Stick = "Levá",
                        Height = 188,
                        Weight = 80
                    },
                    new Player
                    {
                        TeamID = 6,
                        PlayerNumber = 4,
                        Name = "Ondřej Hrachovský",
                        ////Birthday = new DateTime(1998,1,3),
                        Position = "Obránce",
                        Stick = "Pravá",
                        Height = 191,
                        Weight = 82
                    },
                    new Player
                    {
                        TeamID = 6,
                        PlayerNumber = 8,
                        Name = "Aron Chmielewski",
                        ////Birthday = new DateTime(1991,10,9),
                        Position = "Útočník",
                        Stick = "Pravá",
                        Height = 188,
                        Weight = 87
                    },
                    //Olomouc
                    new Player
                    {
                        TeamID = 7,
                        PlayerNumber = 26,
                        Name = "Jan Lukáš",
                        ////Birthday = new DateTime(1993,6,2),
                        Position = "Brankář",
                        Stick = "Levá",
                        Height = 182,
                        Weight = 75
                    },
                    new Player
                    {
                        TeamID = 7,
                        PlayerNumber = 3,
                        Name = "David Škůrek",
                        ////Birthday = new DateTime(1993,8,6),
                        Position = "Obránce",
                        Stick = "Pravá",
                        Height = 196,
                        Weight = 111
                    },
                    new Player
                    {
                        TeamID = 7,
                        PlayerNumber = 4,
                        Name = "Michal Vodný",
                        //Birthday = new DateTime(1991,6,12),
                        Position = "Útočník",
                        Stick = "Pravá",
                        Height = 184,
                        Weight = 79
                    },
                    //Plzeň
                    new Player
                    {
                        TeamID = 8,
                        PlayerNumber = 29,
                        Name = "Marek Micka",
                        //Birthday = new DateTime(2001,9,22),
                        Position = "Brankář",
                        Stick = "Pravá",
                        Height = 191,
                        Weight = 82
                    },
                    new Player
                    {
                        TeamID = 8,
                        PlayerNumber = 3,
                        Name = "Michal Houdek",
                        //Birthday = new DateTime(2000,6,11),
                        Position = "Obránce",
                        Stick = "Levá",
                        Height = 193,
                        Weight = 95
                    },
                    new Player
                    {
                        TeamID = 8,
                        PlayerNumber = 9,
                        Name = "Miroslav Idrák",
                        //Birthday = new DateTime(1995,8,12),
                        Position = "Útočník",
                        Stick = "Levá",
                        Height = 175,
                        Weight = 72
                    },
                    //Sparta
                    new Player
                    {
                        TeamID = 9,
                        PlayerNumber = 30,
                        Name = "Adam Wolf",
                        //Birthday = new DateTime(1999,11,31),
                        Position = "Brankář",
                        Stick = "Levá",
                        Height = 190,
                        Weight = 95
                    },
                    new Player
                    {
                        TeamID = 9,
                        PlayerNumber = 5,
                        Name = "Jan Košťálek",
                        //Birthday = new DateTime(1995,2,17),
                        Position = "Obránce",
                        Stick = "Pravá",
                        Height = 183,
                        Weight = 81
                    },
                    new Player
                    {
                        TeamID = 9,
                        PlayerNumber = 10,
                        Name = "Lukáš Rousek",
                        //Birthday = new DateTime(1999,4,20),
                        Position = "Útočník",
                        Stick = "Levá",
                        Height = 180,
                        Weight = 75
                    },
                    //Litvínov
                    new Player
                    {
                        TeamID = 10,
                        PlayerNumber = 30,
                        Name = "David Honzík",
                        //Birthday = new DateTime(1993,8,9),
                        Position = "Brankář",
                        Stick = "Levá",
                        Height = 189,
                        Weight = 97
                    },
                    new Player
                    {
                        TeamID = 10,
                        PlayerNumber = 3,
                        Name = "Adam Jánošík",
                        //Birthday = new DateTime(1992,9,7),
                        Position = "Obránce",
                        Stick = "Levá",
                        Height = 180,
                        Weight = 80
                    },
                    new Player
                    {
                        TeamID = 10,
                        PlayerNumber = 5,
                        Name = "Michal Trávníček",
                        //Birthday = new DateTime(1980,3,14),
                        Position = "Útočník",
                        Stick = "Levá",
                        Height = 185,
                        Weight = 94
                    },
                    //Vítkovice
                    new Player
                    {
                        TeamID = 11,
                        PlayerNumber = 30,
                        Name = "Daniel Dolejš",
                        //Birthday = new DateTime(1994,7,4),
                        Position = "Brankář",
                        Stick = "Levá",
                        Height = 178,
                        Weight = 82
                    },
                    new Player
                    {
                        TeamID = 11,
                        PlayerNumber = 3,
                        Name = "Daniel Krenželok",
                        //Birthday = new DateTime(1997,7,29),
                        Position = "Obránce",
                        Stick = "Levá",
                        Height = 191,
                        Weight = 85
                    },
                    new Player
                    {
                        TeamID = 11,
                        PlayerNumber = 10,
                        Name = "Josef Baláž",
                        //Birthday = new DateTime(1999,9,26),
                        Position = "Útočník",
                        Stick = "Levá",
                        Height = 174,
                        Weight = 75
                    },
                    //HK
                    new Player
                    {
                        TeamID = 12,
                        PlayerNumber = 1,
                        Name = "Štěpán Lukeš",
                        //Birthday = new DateTime(1996,2,25),
                        Position = "Brankář",
                        Stick = "Pravá",
                        Height = 183,
                        Weight = 87
                    },
                    new Player
                    {
                        TeamID = 12,
                        PlayerNumber = 4,
                        Name = "Jakub Muška",
                        //Birthday = new DateTime(1999,3,5),
                        Position = "Obránce",
                        Stick = "Levá",
                        Height = 190,
                        Weight = 96
                    },
                    new Player
                    {
                        TeamID = 12,
                        PlayerNumber = 6,
                        Name = "Lukáš Cingel",
                        //Birthday = new DateTime(1992,6,10),
                        Position = "Útočník",
                        Stick = "Levá",
                        Height = 186,
                        Weight = 88
                    },
                    //Zlín
                    new Player
                    {
                        TeamID = 13,
                        PlayerNumber = 33,
                        Name = "Marek Čiliak",
                        //Birthday = new DateTime(1990,4,2),
                        Position = "Brankář",
                        Stick = "Levá",
                        Height = 184,
                        Weight = 88
                    },
                    new Player
                    {
                        TeamID = 13,
                        PlayerNumber = 7,
                        Name = "David Nosek",
                        //Birthday = new DateTime(1981,2,19),
                        Position = "Obránce",
                        Stick = "Pravá",
                        Height = 183,
                        Weight = 83
                    },
                    new Player
                    {
                        TeamID = 13,
                        PlayerNumber = 8,
                        Name = "Štěpán Fryšara",
                        //Birthday = new DateTime(1998,7,2),
                        Position = "Útočník",
                        Stick = "Levá",
                        Height = 178,
                        Weight = 77
                    },
                    //Kladno
                    new Player
                    {
                        TeamID = 14,
                        PlayerNumber = 1,
                        Name = "David Stahl",
                        //Birthday = new DateTime(1998,4,18),
                        Position = "Brankář",
                        Stick = "Levá",
                        Height = 178,
                        Weight = 75
                    },
                    new Player
                    {
                        TeamID = 14,
                        PlayerNumber = 3,
                        Name = "Ondřej Smetana",
                        //Birthday = new DateTime(1992,8,26),
                        Position = "Obránce",
                        Stick = "Levá",
                        Height = 193,
                        Weight = 106
                    },
                    new Player
                    {
                        TeamID = 14,
                        PlayerNumber = 8,
                        Name = "Antonín Melka",
                        //Birthday = new DateTime(1990,3,14),
                        Position = "Útočník",
                        Stick = "Levá",
                        Height = 178,
                        Weight = 80
                    },
                };
                foreach (var player in players)
                {
                    context.Players.Add(player);
                }
                context.SaveChanges();


            }
            catch
            {
                Console.WriteLine("Something went wrong.");
            }
        }
    }
}
