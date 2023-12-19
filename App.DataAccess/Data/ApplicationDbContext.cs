using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action/Adventure" },
                new Category { Id = 2, Name = "SciFi" },
                new Category { Id = 3, Name = "Shooter" },
                new Category { Id = 4, Name = "Strategy" },
                new Category { Id = 5, Name = "Casual" },
                new Category { Id = 6, Name = "Educational" },
                new Category { Id = 7, Name = "Sports/Racing" },
                new Category { Id = 8, Name = "Puzzle/Board" },
                new Category { Id = 9, Name = "Horror" },
                new Category { Id = 10, Name = "Classics/Retros" }
                );

            modelBuilder.Entity<Game>().HasData(
                  new Game
                  {
                      Id = 1,
                      Title = "Metroid Prime: Remastered",
                      Price = 59.99,
                      Description = "Metroid Prime: Remastered is a remastered version of the classic first-person adventure game that takes you to the mysterious world of Tallon IV. Explore the ruins of an ancient civilization, fight deadly enemies, and uncover the secrets of the Space Pirates and the mysterious substance called Phazon.",
                      Platform = "Nintendo Switch",
                      Trailer = "https://youtu.be/e9OQOJC1QII?si=Zm1DS9OKcPnXkXFU",
                      CategoryId = 10,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/MetroidPrimeRemastered.png"
                  },

                  new Game
                  {
                      Id = 2,
                      Title = "Resident Evil 4",
                      Price = 19.99,
                      Description = "Resident Evil 4 is a survival horror game that follows Leon S. Kennedy, a US agent sent to rescue the president's daughter from a sinister cult in a rural village in Spain. Experience the thrill of combat with a variety of weapons and enemies, and the horror of the infected villagers and monstrous creatures.",
                      Platform = "PC, PS4, Xbox One, Nintendo Switch",
                      Trailer = "https://youtu.be/E69tKrfEQag?si=xLLTZ9Ii4nHVsZpN",
                      CategoryId = 10,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/ResidentEvil4.png"
                  },

                  new Game
                  {
                      Id = 3,
                      Title = "The Medium",
                      Price = 49.99,
                      Description = "The Medium is a psychological horror game that lets you explore two realities at the same time. You play as Marianne, a medium who can travel to the spirit world and use her psychic abilities to solve mysteries and uncover dark secrets. The game features a dual-reality gameplay system, a rich and atmospheric world, and an original soundtrack composed by Akira Yamaoka and Arkadiusz Reikowski.",
                      Platform = "PC, Xbox Series X/S",
                      Trailer = "https://youtu.be/ve5QM0d9fP4?si=9yO7S9bVcbjVowiw",
                      CategoryId = 9,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/TheMedium.png"
                  },
                  new Game
                  {
                      Id = 4,
                      Title = "Outlast 3",
                      Price = 29.99,
                      Description = "Outlast 3 is a first-person survival horror game that puts you in the shoes of a journalist who investigates a remote cult in the Arizona desert. You have no weapons, only a camera and your wits to survive the horrors that await you. The game features a realistic and immersive environment, a dynamic day-night cycle, and a terrifying story that will keep you on the edge of your seat.",
                      Platform = "PC, PS5, Xbox Series X/S",
                      Trailer = "https://youtu.be/U4ggIsu_cBU?si=WnhXyzsRVkjQPFoG",
                      CategoryId = 9,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/Outlast3.png"
                  },

                  new Game
                  {
                      Id = 5,
                      Title = "Silent Hill: Rebirth",
                      Price = 59.99,
                      Description = "Silent Hill: Rebirth is a reboot of the iconic horror franchise that takes you back to the foggy town of Silent Hill. You play as James Sunderland, a man who receives a letter from his dead wife, asking him to meet her in their special place. As you explore the town, you will encounter twisted creatures, dark secrets, and your own inner demons. The game features a psychological horror gameplay, a branching storyline, and a haunting soundtrack by Akira Yamaoka.",
                      Platform = "PC, PS5, Xbox Series X/S",
                      Trailer = "https://youtu.be/9b4iOhWswYM?si=19aXKioBAYC8iFal",
                      CategoryId = 9,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/SilentHillRebirth.png"
                  },

                  new Game
                  {
                      Id = 6,
                      Title = "The Evil Within 3",
                      Price = 59.99,
                      Description = "The Evil Within 3 is a third-person survival horror game that continues the story of Sebastian Castellanos, a detective who is haunted by his past and the horrors of STEM, a twisted reality created by a mysterious organization. You will face new enemies, traps, and challenges as you unravel the secrets behind STEM and your own destiny. The game features a visceral and cinematic gameplay, a rich and immersive world, and a thrilling and unpredictable story.",
                      Platform = "PC, PS5, Xbox Series X/S",
                      Trailer = "https://youtu.be/ivtb4dXtv1s?si=nWcIVbJsx_uUDTJd",
                      CategoryId = 9,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/TheEvilWithin3.png"
                  },

                  new Game
                  {
                      Id = 7,
                      Title = "Dying Light 2",
                      Price = 59.99,
                      Description = "Dying Light 2 is an open-world action RPG that lets you experience the post-apocalyptic world of the infected. You play as Aiden Caldwell, a survivor who has exceptional parkour skills and a powerful combat system. You can explore the vast and dynamic city, interact with various factions, and shape the world with your choices. The game features a day-night cycle, a seamless co-op mode, and a creative crafting system.",
                      Platform = "PC, PS4, PS5, Xbox One, Xbox Series X/S",
                      Trailer = "https://youtu.be/2MD4gTitmzw?si=hXclw_Fpyy6FqifL",
                      CategoryId = 9,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/DyingLight2.png"
                  },
                  new Game
                  {
                      Id = 8,
                      Title = "The Witness 2",
                      Price = 39.99,
                      Description = "The Witness 2 is a puzzle adventure game that takes you to a mysterious island full of secrets and challenges. You will explore the island, solve puzzles, and discover the truth behind the island and yourself. The game features a beautiful and immersive world, a non-linear and open-ended gameplay, and a variety of puzzles that test your logic and perception.",
                      Platform = "PC, PS5, Xbox Series X/S, Nintendo Switch",
                      Trailer = "https://youtu.be/ul7kNFD6noU?si=eIl5StMM0IDzdLpB",
                      CategoryId = 8,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/TheWitness.png"
                  },

                  new Game
                  {
                      Id = 9,
                      Title = "Portal 3",
                      Price = 59.99,
                      Description = "Portal 3 is a first-person puzzle platformer that lets you use a portal gun to create portals between two points in space. You will use the portals to overcome obstacles, avoid hazards, and outsmart the AI that controls the facility. The game features a witty and humorous story, a co-op mode, and a level editor that allows you to create and share your own puzzles.",
                      Platform = "PC, PS5, Xbox Series X/S",
                      Trailer = "https://youtu.be/ku9r27TX2xs?si=pSQIgFxuUroFz-8H",
                      CategoryId = 8,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/Portal3.png"
                  },

                  new Game
                  {
                      Id = 10,
                      Title = "Tetris Effect 2",
                      Price = 29.99,
                      Description = "Tetris Effect 2 is a puzzle game that combines the classic gameplay of Tetris with stunning visuals and music. You will experience the Tetris effect, a phenomenon where you see Tetris blocks in your mind even when you are not playing. The game features a variety of modes, a VR support, and a multiplayer mode that allows you to play with or against other players.",
                      Platform = "PC, PS4, PS5, Xbox One, Xbox Series X/S, Nintendo Switch",
                      Trailer = "https://youtu.be/PFVL6t8IHE8?si=mWfw_AvrmT1-M-cT",
                      CategoryId = 8,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/TetrisEffect2.png"
                  },

                  new Game
                  {
                      Id = 11,
                      Title = "The Talos Principle 2",
                      Price = 49.99,
                      Description = "The Talos Principle 2 is a philosophical puzzle game that explores the nature of humanity, consciousness, and free will. You play as a robot who awakens in a mysterious world full of ancient ruins and advanced technology. You will solve puzzles, collect clues, and make choices that will determine your fate. The game features a rich and immersive world, a branching storyline, and a voice cast that includes Elijah Wood and James Urbaniak.",
                      Platform = "PC, PS5, Xbox Series X/S",
                      Trailer = "https://youtu.be/9ivatJM-9oA?si=KSOF3iZq2TGqMVoS",
                      CategoryId = 8,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/TheTalosPrinciple2.png"
                  },

                  new Game
                  {
                      Id = 12,
                      Title = "Chess Ultra 2",
                      Price = 19.99,
                      Description = "Chess Ultra 2 is a chess game that offers a realistic and immersive chess experience. You can play chess against the AI, online players, or your friends. You can also customize your chess pieces, boards, and environments. The game features a 4K graphics, a VR support, and a tutorial mode that teaches you the basics and advanced strategies of chess.",
                      Platform = "PC, PS4, PS5, Xbox One, Xbox Series X/S, Nintendo Switch",
                      Trailer = "https://youtu.be/cCRTRsQ2W1U?si=IIyghmHeULPfY0FR",
                      CategoryId = 8,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/ChessUltra2.png"
                  },

                  new Game
                  {
                      Id = 13,
                      Title = "FIFA 23",
                      Price = 59.99,
                      Description = "FIFA 23 is a soccer simulation game that lets you play as your favorite teams and players from around the world. You can compete in various modes, such as career, ultimate team, volta, and champions league. The game features a realistic and responsive gameplay, a stunning graphics, and a dynamic commentary.",
                      Platform = "PC, PS4, PS5, Xbox One, Xbox Series X/S, Nintendo Switch",
                      Trailer = "https://youtu.be/0tIW1X2dv0c?si=9WCaJeYjk6iuYONJ",
                      CategoryId = 7,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/FIFA23.png"
                  },

                  new Game
                  {
                      Id = 14,
                      Title = "PES 2023",
                      Price = 59.99,
                      Description = "PES 2023 is a soccer simulation game that offers a realistic and immersive soccer experience. You can play as your favorite teams and players from around the world. You can also create your own team and customize your players, kits, and stadiums. The game features a fluid and adaptive gameplay, a stunning graphics, and a realistic physics.",
                      Platform = "PC, PS4, PS5, Xbox One, Xbox Series X/S",
                      Trailer = "https://youtu.be/nce2U6ZcGPI?si=_lZVe1-FYeObSqwm",
                      CategoryId = 7,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/PES23.png"
                  },

                  new Game
                  {
                      Id = 15,
                      Title = "Need for Speed Most Wanted",
                      Price = 59.99,
                      Description = "Need for Speed Most Wanted is a racing game that lets you drive the most wanted cars in the world. You can race against the police, your rivals, or your friends. You can also customize your cars, challenge other players, and explore the open world. The game features a fast and furious gameplay, a realistic and dynamic world, and a social and competitive online mode.",
                      Platform = "PC, PS4, PS5, Xbox One, Xbox Series X/S",
                      Trailer = "https://youtu.be/DEmRkNnCvLU?si=G1AUIpvP36CKsjOt",
                      CategoryId = 7,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/NeedforSpeedMostWanted.png"
                  },

                  new Game
                  {
                      Id = 16,
                      Title = "Rocket League",
                      Price = 19.99,
                      Description = "Rocket League is a sports game that combines soccer and rocket-powered cars. You can play solo or with your friends in various modes, such as casual, competitive, rumble, dropshot, and hoops. You can also customize your cars, unlock new items, and join tournaments. The game features a fun and addictive gameplay, a colorful and vibrant graphics, and a cross-platform support.",
                      Platform = "PC, PS4, PS5, Xbox One, Xbox Series X/S, Nintendo Switch",
                      Trailer = "https://youtu.be/SgSX3gOrj60?si=uET9O2N-M313KhcK",
                      CategoryId = 7,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/RocketLeague.png"
                  },

                  new Game
                  {
                      Id = 17,
                      Title = "Gran Turismo 7",
                      Price = 69.99,
                      Description = "Gran Turismo 7 is a racing simulation game that offers a realistic and immersive driving experience. You can drive over 400 cars from various manufacturers, brands, and eras. You can also race on over 100 tracks from around the world, including the legendary Nürburgring. The game features a stunning graphics, a realistic physics, and a VR support.",
                      Platform = "PS5",
                      Trailer = "https://youtu.be/1tBUsXIkG1A?si=g0GqSxLHXyfvPbO1",
                      CategoryId = 7,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/GranTurismo7.png"
                  },

                  new Game
                  {
                      Id = 18,
                      Title = "Forza Motorsport 8",
                      Price = 69.99,
                      Description = "Forza Motorsport 8 is a racing simulation game that lets you experience the thrill of motorsport. You can drive over 700 cars from various categories, such as GT, Formula 1, NASCAR, and more. You can also race on over 200 tracks from around the world, including the iconic Indianapolis Motor Speedway. The game features a stunning graphics, a realistic physics, and a dynamic weather and time system.",
                      Platform = "Xbox Series X/S, PC",
                      Trailer = "https://youtu.be/yJumrR_bbg0?si=fHmiuysbuMWvMtne",
                      CategoryId = 7,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/ForzaMotorsport8.png"
                  },

                  new Game
                  {
                      Id = 19,
                      Title = "NBA 2K24",
                      Price = 69.99,
                      Description = "NBA 2K24 is a basketball simulation game that lets you play as your favorite NBA teams and players. You can compete in various modes, such as career, my team, my park, and my league. The game features a realistic and responsive gameplay, a stunning graphics, and a dynamic commentary.",
                      Platform = "PC, PS4, PS5, Xbox One, Xbox Series X/S, Nintendo Switch",
                      Trailer = "https://youtu.be/OJS1BVniz5c?si=LEs2mtn03lGWFTf7",
                      CategoryId = 7,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/NBA2K24.png"
                  },

                  new Game
                  {
                      Id = 20,
                      Title = "Madden NFL 24",
                      Price = 69.99,
                      Description = "Madden NFL 24 is a football simulation game that lets you play as your favorite NFL teams and players. You can compete in various modes, such as franchise, ultimate team, superstar KO, and face of the franchise. The game features a realistic and responsive gameplay, a stunning graphics, and a dynamic commentary.",
                      Platform = "PC, PS4, PS5, Xbox One, Xbox Series X/S",
                      Trailer = "https://youtu.be/UVZ0IIeW2mw?si=VjgGeEMMeHEp2Gnd",
                      CategoryId = 7,
                      ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/MaddenNFL24.png"
                  },
                new Game
                {
                    Id = 21,
                    Title = "Brain Age: Switch Up Your Brain",
                    Price = 29.99,
                    Description = "Brain Age: Switch Up Your Brain is a brain training game that helps you improve your mental skills and cognitive abilities. You can play various exercises, such as math, memory, logic, and more. You can also challenge your friends and family in multiplayer mode. The game features a fun and interactive gameplay, a personalized feedback, and a voice recognition system.",
                    Platform = "Nintendo Switch",
                    Trailer = "https://youtu.be/Bg13HWedwyk?si=RVqUmr-a3XWqE63w",
                    CategoryId = 6,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/BrainAgeSwitchUpYourBrain.png"
                },

                new Game
                {
                    Id = 22,
                    Title = "Civilization VII",
                    Price = 59.99,
                    Description = "Civilization VII is a turn-based strategy game that lets you build and lead your own civilization from the ancient times to the future. You can choose from various leaders, cultures, and ideologies. You can also explore the world, research technologies, build wonders, wage wars, and engage in diplomacy. The game features a rich and immersive gameplay, a stunning graphics, and a dynamic world.",
                    Platform = "PC, PS5, Xbox Series X/S",
                    Trailer = "https://youtu.be/FYTtl8LC_vg?si=ZnQ5_9sD7n7fcDZ4",
                    CategoryId = 6,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/CivilizationVII.png"
                },

                new Game
                {
                    Id = 23,
                    Title = "Kerbal Space Program 2",
                    Price = 59.99,
                    Description = "Kerbal Space Program 2 is a space simulation game that lets you create and manage your own space program. You can design, build, and launch rockets, satellites, space stations, and more. You can also explore the solar system, colonize planets, and discover new technologies. The game features a realistic and physics-based gameplay, a creative and sandbox mode, and a multiplayer mode that allows you to cooperate or compete with other players.",
                    Platform = "PC, PS4, PS5, Xbox One, Xbox Series X/S",
                    Trailer = "https://youtu.be/P_nj6wW6Gsc?si=4H5oecZGGXMlcMdi",
                    CategoryId = 6,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/KerbalSpaceProgram2.png"
                },

                new Game
                {
                    Id = 24,
                    Title = "Minecraft: Education Edition",
                    Price = 14.99,
                    Description = "Minecraft: Education Edition is a game-based learning platform that helps students and teachers explore, create, and collaborate in a virtual world. You can use Minecraft to learn about various subjects, such as math, science, history, and art. You can also access various lessons, worlds, and resources that are designed for education. The game features a fun and engaging gameplay, a cross-platform support, and a classroom mode that allows teachers to manage and monitor students.",
                    Platform = "PC, iOS, Android, Chromebook",
                    Trailer = "https://youtu.be/5QYqmTSJWRo?si=Cfs3fRN0jc5bJ5Cn",
                    CategoryId = 6,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/MinecraftEducationEdition.png"
                },

                new Game
                {
                    Id = 25,
                    Title = "SimCity 6",
                    Price = 59.99,
                    Description = "SimCity 6 is a city-building simulation game that lets you create and manage your own city. You can plan, design, and build your city from the ground up. You can also deal with various challenges, such as traffic, pollution, crime, and disasters. The game features a realistic and dynamic gameplay, a stunning graphics, and a multiplayer mode that allows you to share and visit other cities.",
                    Platform = "PC, PS5, Xbox Series X/S",
                    Trailer = "https://youtu.be/Z5fJL_WpItI?si=Virdf9MdHH01_v-x",
                    CategoryId = 6,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/SimCity6.png"
                },

                new Game
                {
                    Id = 26,
                    Title = "Animal Crossing: New Horizons 2",
                    Price = 59.99,
                    Description = "Animal Crossing: New Horizons 2 is a life simulation game that lets you create and customize your own island paradise. You can decorate your home, grow crops, craft items, and interact with various animal villagers. You can also visit other islands, invite friends, and enjoy seasonal events. The game features a relaxing and charming gameplay, a colorful and vibrant graphics, and a cross-platform support.",
                    Platform = "Nintendo Switch",
                    Trailer = "https://youtu.be/InDJvcWtTCw?si=z5CojiHuegGLk284",
                    CategoryId = 5,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/AnimalCrossingNewHorizons2.png"
                },

                new Game
                {
                    Id = 27,
                    Title = "Stardew Valley 2",
                    Price = 19.99,
                    Description = "Stardew Valley 2 is a farming simulation game that lets you escape to the countryside and start a new life. You can farm, fish, mine, cook, and craft. You can also befriend the locals, romance a partner, and start a family. You can also explore the mysterious caves, forests, and islands. The game features a relaxing and addictive gameplay, a pixelated and retro graphics, and a multiplayer mode that allows you to play with up to three friends.",
                    Platform = "PC, PS4, PS5, Xbox One, Xbox Series X/S, Nintendo Switch, iOS, Android",
                    Trailer = "https://youtu.be/ASlkM-mf1zk?si=VSoI3Y7zWZgNc89F",
                    CategoryId = 5,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/StardewValley.png"
                },

                new Game
                {
                    Id = 28,
                    Title = "Fall Guys: Ultimate Knockout 2",
                    Price = 19.99,
                    Description = "Fall Guys: Ultimate Knockout 2 is a party game that lets you compete in a series of hilarious and chaotic mini-games. You can play as a colorful and cute bean-shaped character and try to survive the obstacles, traps, and other players. You can also customize your character, unlock new outfits, and join teams. The game features a fun and frantic gameplay, a bright and cheerful graphics, and a cross-platform support.",
                    Platform = "PC, PS4, PS5, Xbox One, Xbox Series X/S, Nintendo Switch",
                    Trailer = "https://youtu.be/DDz8smFK3QI?si=1eYvUcFXTNXvUt0D",
                    CategoryId = 5,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/FallGuysUltimateKnockout.png"
                },

                new Game
                {
                    Id = 29,
                    Title = "Among Us 2",
                    Price = 4.99,
                    Description = "Among Us 2 is a social deduction game that lets you play as a crewmate or an impostor in a spaceship. You can play with up to 15 players online or locally. As a crewmate, you have to complete tasks and find the impostor. As an impostor, you have to kill the crewmates and sabotage the ship. The game features a suspenseful and thrilling gameplay, a cartoonish and simple graphics, and a cross-platform support.",
                    Platform = "PC, iOS, Android",
                    Trailer = "https://youtu.be/PjPSrd1HB8s?si=wN7lqNhpaXfmPlcM",
                    CategoryId = 5,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/AmongUs.png"
                },

                new Game
                {
                    Id = 30,
                    Title = "Super Mario Party 2",
                    Price = 59.99,
                    Description = "Super Mario Party 2 is a party game that lets you play as your favorite Mario characters and compete in various mini-games. You can play with up to four players online or locally. You can also choose from different modes, such as board game, rhythm, and puzzle. The game features a fun and exciting gameplay, a colorful and lively graphics, and a cross-platform support.",
                    Platform = "Nintendo Switch",
                    Trailer = "https://youtu.be/my-jYVD_gmA?si=MoODRYPnGPOMvTl3",
                    CategoryId = 5,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/SuperMarioParty2.png"
                },
                new Game
                {
                    Id = 31,
                    Title = "Age of Empires IV",
                    Price = 59.99,
                    Description = "Age of Empires IV is a real-time strategy game that lets you relive the epic battles of history. You can choose from various civilizations, such as Mongols, Chinese, English, and French. You can also build your empire, research technologies, train units, and wage wars. The game features a realistic and immersive gameplay, a stunning graphics, and a campaign mode that tells the stories of the great leaders and empires.",
                    Platform = "PC",
                    Trailer = "https://youtu.be/5TnynE3PuDE?si=P4fREnIYPRFNXCdH",
                    CategoryId = 4,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/AgeofEmpiresV.png"
                },

                new Game
                {
                    Id = 32,
                    Title = "XCOM 3",
                    Price = 59.99,
                    Description = "XCOM 3 is a turn-based strategy game that lets you lead the resistance against an alien invasion. You can command your squad of soldiers, scientists, and engineers. You can also research alien technologies, build facilities, and engage in tactical combat. The game features a challenging and strategic gameplay, a rich and diverse world, and a permadeath system that makes every decision matter.",
                    Platform = "PC, PS5, Xbox Series X/S",
                    Trailer = "https://youtu.be/aZnpl3hWfVM?si=fnt6NC-qV44NRFS5",
                    CategoryId = 4,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/XCOM3.png"
                },

                new Game
                {
                    Id = 33,
                    Title = "Total War: Warhammer III",
                    Price = 59.99,
                    Description = "Total War: Warhammer III is a strategy game that combines the turn-based empire building of Total War with the real-time battles of Warhammer. You can choose from various factions, such as Kislev, Cathay, Khorne, and Tzeentch. You can also explore the world, recruit legendary heroes, and fight epic wars. The game features a massive and detailed gameplay, a stunning graphics, and a multiplayer mode that allows you to cooperate or compete with other players.",
                    Platform = "PC",
                    Trailer = "https://youtu.be/HAr7yUlM0Po?si=zde_XuccRjLm75Ty",
                    CategoryId = 4,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/TotalWarWarhammerIII.png"
                },

                new Game
                {
                    Id = 34,
                    Title = "Crusader Kings IV",
                    Price = 49.99,
                    Description = "Crusader Kings IV is a grand strategy game that lets you create your own medieval dynasty. You can play as any historical or fictional character, from a king to a peasant. You can also shape your character, manage your realm, expand your influence, and deal with various events, such as wars, plagues, and intrigues. The game features a deep and complex gameplay, a dynamic and emergent world, and a modding support that allows you to create and share your own scenarios.",
                    Platform = "PC",
                    Trailer = "https://youtu.be/sD5GsZaF39k?si=fQqwiGyvrJC0Dq7s",
                    CategoryId = 4,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/CrusaderKingsIV.png"
                },

                new Game
                {
                    Id = 35,
                    Title = "StarCraft III",
                    Price = 59.99,
                    Description = "StarCraft III is a sci-fi strategy game that lets you play as one of the three races: Terran, Zerg, or Protoss. You can build your base, gather resources, train units, and wage wars. You can also follow the story of the legendary heroes, such as Jim Raynor, Sarah Kerrigan, and Artanis. The game features a fast and competitive gameplay, a stunning graphics, and a multiplayer mode that allows you to play with or against other players.",
                    Platform = "PC",
                    Trailer = "https://youtu.be/MVbeoSPqRs4?si=tZz2JJ1P_nILupib",
                    CategoryId = 4,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/StarCraftIII.png"
                },

                new Game
                {
                    Id = 36,
                    Title = "Valorant",
                    Price = 0.00,
                    Description = "Valorant is a character-based 5v5 tactical shooter set on the global stage. Outwit, outplay, and outshine your competition with tactical abilities, precise gunplay, and adaptive teamwork. The game features a diverse and balanced gameplay, a stylish and colorful graphics, and a competitive and ranked mode that tests your skills and strategies.",
                    Platform = "PC",
                    Trailer = "https://youtu.be/e_E9W2vsRbQ?si=2ASg49FtAy8NZfEd",
                    CategoryId = 3,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/Valorant.png"
                },

                new Game
                {
                    Id = 37,
                    Title = "Counter-Strike 2",
                    Price = 29.99,
                    Description = "Counter-Strike 2 is a first-person shooter that pits two teams of terrorists and counter-terrorists against each other. You can play various modes, such as bomb defusal, hostage rescue, and deathmatch. You can also buy and customize your weapons, communicate with your teammates, and complete objectives. The game features a realistic and intense gameplay, a realistic and dynamic world, and a cross-platform support.",
                    Platform = "PC, PS5, Xbox Series X/S",
                    Trailer = "https://youtu.be/kDDnvAr6gGI?si=r8tNmJENBpiEgJSj",
                    CategoryId = 3,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/CounterStrike2.png"
                },

                new Game
                {
                    Id = 38,
                    Title = "Apex Legends",
                    Price = 0.00,
                    Description = "Apex Legends is a battle royale shooter that lets you play as one of the legends, each with their own unique abilities and personality. You can team up with two other players and compete with 60 other players in a massive map. You can also loot weapons, items, and vehicles, and use them to survive and win. The game features a fast and fluid gameplay, a stunning graphics, and a cross-platform support.",
                    Platform = "PC, PS4, PS5, Xbox One, Xbox Series X/S, Nintendo Switch",
                    Trailer = "https://youtu.be/Ix-6DAcuPcg?si=9583M3hyoGJl8IM-",
                    CategoryId = 3,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/ApexLegends.png"
                },

                new Game
                {
                    Id = 39,
                    Title = "Call of Duty Warzone",
                    Price = 0.00,
                    Description = "Call of Duty Warzone is a free-to-play battle royale shooter that lets you play as a soldier in the Call of Duty universe. You can play solo or with your friends in various modes, such as battle royale, plunder, and rebirth. You can also customize your loadout, use killstreaks, and revive your teammates. The game features a realistic and immersive gameplay, a stunning graphics, and a cross-platform support.",
                    Platform = "PC, PS4, PS5, Xbox One, Xbox Series X/S",
                    Trailer = "https://youtu.be/0E44DClsX5Q?si=v4NaJqQfTehNNtiT",
                    CategoryId = 3,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/CallofDutyWarzone.png"
                },

                new Game
                {
                    Id = 40,
                    Title = "Halo Infinite",
                    Price = 69.99,
                    Description = "Halo Infinite is a sci-fi shooter that lets you play as the Master Chief, a legendary Spartan soldier who fights against the alien Covenant. You can explore the Halo ring, a massive and mysterious world full of secrets and dangers. You can also use various weapons, vehicles, and equipment to combat your enemies. The game features a epic and cinematic gameplay, a stunning graphics, and a multiplayer mode that allows you to play with or against other players.",
                    Platform = "PC, Xbox One, Xbox Series X/S",
                    Trailer = "https://youtu.be/PyMlV5_HRWk?si=2UtquXPRLuvMiZhp",
                    CategoryId = 3,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/HaloInfinite.png"
                },

                new Game
                {
                    Id = 41,
                    Title = "Destiny 2",
                    Price = 0.00,
                    Description = "Destiny 2 is a sci-fi shooter that lets you play as a Guardian, a protector of the last city on Earth. You can choose from various classes, such as Titan, Hunter, and Warlock. You can also customize your weapons, armor, and abilities. You can also explore the solar system, fight against various enemies, and join forces with other players. The game features a rich and immersive gameplay, a stunning graphics, and a cross-platform support.",
                    Platform = "PC, PS4, PS5, Xbox One, Xbox Series X/S, Stadia",
                    Trailer = "https://youtu.be/Ehl6aWUiA4Y?si=AgOjZRu1w21LHQgy",
                    CategoryId = 3,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/Destiny2.png"
                },

                new Game
                {
                    Id = 42,
                    Title = "Starfield",
                    Price = 69.99,
                    Description = "Starfield is a sci-fi RPG that lets you create your own character and explore the galaxy. You can travel to various planets, star systems, and space stations. You can also customize your spaceship, engage in combat, and interact with various factions and aliens. The game features a vast and immersive gameplay, a stunning graphics, and a modding support.",
                    Platform = "PC, Xbox Series X/S",
                    Trailer = "https://youtu.be/kfYEiTdsyas?si=fK8oWdk-gXqPNlQ-",
                    CategoryId = 2,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/Starfield.png"
                },

                new Game
                {
                    Id = 43,
                    Title = "Star Wars Jedi: Survivor",
                    Price = 59.99,
                    Description = "Star Wars Jedi: Survivor is a sci-fi action game that follows the story of a Jedi who survived the Order 66 and the rise of the Empire. You play as Cal Kestis, a former Padawan who is hiding his identity and powers. You will use your lightsaber, force abilities, and droid companion to fight against the Inquisitors, stormtroopers, and other enemies. The game features a cinematic and thrilling gameplay, a rich and diverse world, and a original soundtrack.",
                    Platform = "PC, PS5, Xbox Series X/S",
                    Trailer = "https://youtu.be/VRaobDJjiec?si=ZQWV-Wh0Hao2ggUe",
                    CategoryId = 2,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/StarWarsJediSurvivor.png"
                },

                new Game
                {
                    Id = 44,
                    Title = "Zelda: Tears of the Kingdom",
                    Price = 69.99,
                    Description = "Zelda: Tears of the Kingdom is a fantasy action-adventure game that lets you play as Link, a young hero who must save the kingdom of Hyrule from a dark and evil force. You can explore the vast and beautiful world, solve puzzles, collect items, and fight enemies. You can also use various weapons, tools, and abilities, such as the Master Sword, the Sheikah Slate, and the Champion's Powers. The game features a stunning and immersive gameplay, a breathtaking graphics, and a dynamic weather and time system.",
                    Platform = "Nintendo Switch",
                    Trailer = "https://youtu.be/uHGShqcAHlQ?si=riJ5u8cW52_qYFL3",
                    CategoryId = 1,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/ZeldaTearsoftheKingdom.png"
                },

                new Game
                {
                    Id = 45,
                    Title = "Spider-Man 2",
                    Price = 69.99,
                    Description = "Spider-Man 2 is a superhero action game that lets you play as Spider-Man, a web-slinging hero who protects New York City from various threats. You can swing through the city, fight against villains, and save the citizens. You can also use various suits, gadgets, and skills, such as the Spider-Sense, the Web-Shooters, and the Venom Blast. The game features a realistic and dynamic gameplay, a stunning graphics, and a captivating story.",
                    Platform = "PS5",
                    Trailer = "https://youtu.be/nq1M_Wc4FIc?si=PUf2wD0jlIdRhxEQ",
                    CategoryId = 1,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/SpiderMan2.png"
                },

                new Game
                {
                    Id = 46,
                    Title = "Street Fighter 6",
                    Price = 59.99,
                    Description = "Street Fighter 6 is a fighting game that lets you play as one of the legendary fighters from the Street Fighter series. You can choose from various characters, such as Ryu, Chun-Li, Ken, and Akuma. You can also use various moves, combos, and special attacks, such as the Hadoken, the Shoryuken, and the Raging Demon. The game features a fast and furious gameplay, a stunning graphics, and a multiplayer mode that allows you to play with or against other players.",
                    Platform = "PC, PS5, Xbox Series X/S",
                    Trailer = "https://youtu.be/1INU3FOJsTw?si=MDTRXPFfzH9yrI8j",
                    CategoryId = 1,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/StreetFighter6.png"
                },

                new Game
                {
                    Id = 47,
                    Title = "Final Fantasy 16",
                    Price = 69.99,
                    Description = "Final Fantasy 16 is a fantasy RPG that lets you play as Clive Rosfield, a young knight who is the protector of his brother Joshua, the Dominant of the Phoenix. You will embark on a journey to face the dark and twisted fate that awaits you. You will use various weapons, magic, and summons to combat your enemies. The game features a epic and dramatic gameplay, a stunning graphics, and a original soundtrack.",
                    Platform = "PS5",
                    Trailer = "https://youtu.be/aPT26Dd3OzE?si=Sehz3mvz9i6gIOTw",
                    CategoryId = 1,
                    ImageURL = "https://gamsstation.blob.core.windows.net/gamsstation/FinalFantasy16.png"

                });



        }
    }
}
