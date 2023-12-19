using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataForGamesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "Description", "Platform", "Price", "Title", "Trailer" },
                values: new object[,]
                {
                    { 1, 10, "Metroid Prime: Remastered is a remastered version of the classic first-person adventure game that takes you to the mysterious world of Tallon IV. Explore the ruins of an ancient civilization, fight deadly enemies, and uncover the secrets of the Space Pirates and the mysterious substance called Phazon.", "Nintendo Switch", 59.990000000000002, "Metroid Prime: Remastered", "https://youtu.be/e9OQOJC1QII?si=Zm1DS9OKcPnXkXFU" },
                    { 2, 10, "Resident Evil 4 is a survival horror game that follows Leon S. Kennedy, a US agent sent to rescue the president's daughter from a sinister cult in a rural village in Spain. Experience the thrill of combat with a variety of weapons and enemies, and the horror of the infected villagers and monstrous creatures.", "PC, PS4, Xbox One, Nintendo Switch", 19.989999999999998, "Resident Evil 4", "https://youtu.be/E69tKrfEQag?si=xLLTZ9Ii4nHVsZpN" },
                    { 3, 9, "The Medium is a psychological horror game that lets you explore two realities at the same time. You play as Marianne, a medium who can travel to the spirit world and use her psychic abilities to solve mysteries and uncover dark secrets. The game features a dual-reality gameplay system, a rich and atmospheric world, and an original soundtrack composed by Akira Yamaoka and Arkadiusz Reikowski.", "PC, Xbox Series X/S", 49.990000000000002, "The Medium", "https://youtu.be/ve5QM0d9fP4?si=9yO7S9bVcbjVowiw" },
                    { 4, 9, "Outlast 3 is a first-person survival horror game that puts you in the shoes of a journalist who investigates a remote cult in the Arizona desert. You have no weapons, only a camera and your wits to survive the horrors that await you. The game features a realistic and immersive environment, a dynamic day-night cycle, and a terrifying story that will keep you on the edge of your seat.", "PC, PS5, Xbox Series X/S", 29.989999999999998, "Outlast 3", "https://youtu.be/U4ggIsu_cBU?si=WnhXyzsRVkjQPFoG" },
                    { 5, 9, "Silent Hill: Rebirth is a reboot of the iconic horror franchise that takes you back to the foggy town of Silent Hill. You play as James Sunderland, a man who receives a letter from his dead wife, asking him to meet her in their special place. As you explore the town, you will encounter twisted creatures, dark secrets, and your own inner demons. The game features a psychological horror gameplay, a branching storyline, and a haunting soundtrack by Akira Yamaoka.", "PC, PS5, Xbox Series X/S", 59.990000000000002, "Silent Hill: Rebirth", "https://youtu.be/9b4iOhWswYM?si=19aXKioBAYC8iFal" },
                    { 6, 9, "The Evil Within 3 is a third-person survival horror game that continues the story of Sebastian Castellanos, a detective who is haunted by his past and the horrors of STEM, a twisted reality created by a mysterious organization. You will face new enemies, traps, and challenges as you unravel the secrets behind STEM and your own destiny. The game features a visceral and cinematic gameplay, a rich and immersive world, and a thrilling and unpredictable story.", "PC, PS5, Xbox Series X/S", 59.990000000000002, "The Evil Within 3", "https://youtu.be/ivtb4dXtv1s?si=nWcIVbJsx_uUDTJd" },
                    { 7, 9, "Dying Light 2 is an open-world action RPG that lets you experience the post-apocalyptic world of the infected. You play as Aiden Caldwell, a survivor who has exceptional parkour skills and a powerful combat system. You can explore the vast and dynamic city, interact with various factions, and shape the world with your choices. The game features a day-night cycle, a seamless co-op mode, and a creative crafting system.", "PC, PS4, PS5, Xbox One, Xbox Series X/S", 59.990000000000002, "Dying Light 2", "https://youtu.be/2MD4gTitmzw?si=hXclw_Fpyy6FqifL" },
                    { 8, 8, "The Witness 2 is a puzzle adventure game that takes you to a mysterious island full of secrets and challenges. You will explore the island, solve puzzles, and discover the truth behind the island and yourself. The game features a beautiful and immersive world, a non-linear and open-ended gameplay, and a variety of puzzles that test your logic and perception.", "PC, PS5, Xbox Series X/S, Nintendo Switch", 39.990000000000002, "The Witness 2", "https://youtu.be/ul7kNFD6noU?si=eIl5StMM0IDzdLpB" },
                    { 9, 8, "Portal 3 is a first-person puzzle platformer that lets you use a portal gun to create portals between two points in space. You will use the portals to overcome obstacles, avoid hazards, and outsmart the AI that controls the facility. The game features a witty and humorous story, a co-op mode, and a level editor that allows you to create and share your own puzzles.", "PC, PS5, Xbox Series X/S", 59.990000000000002, "Portal 3", "https://youtu.be/ku9r27TX2xs?si=pSQIgFxuUroFz-8H" },
                    { 10, 8, "Tetris Effect 2 is a puzzle game that combines the classic gameplay of Tetris with stunning visuals and music. You will experience the Tetris effect, a phenomenon where you see Tetris blocks in your mind even when you are not playing. The game features a variety of modes, a VR support, and a multiplayer mode that allows you to play with or against other players.", "PC, PS4, PS5, Xbox One, Xbox Series X/S, Nintendo Switch", 29.989999999999998, "Tetris Effect 2", "https://youtu.be/PFVL6t8IHE8?si=mWfw_AvrmT1-M-cT" },
                    { 11, 8, "The Talos Principle 2 is a philosophical puzzle game that explores the nature of humanity, consciousness, and free will. You play as a robot who awakens in a mysterious world full of ancient ruins and advanced technology. You will solve puzzles, collect clues, and make choices that will determine your fate. The game features a rich and immersive world, a branching storyline, and a voice cast that includes Elijah Wood and James Urbaniak.", "PC, PS5, Xbox Series X/S", 49.990000000000002, "The Talos Principle 2", "https://youtu.be/9ivatJM-9oA?si=KSOF3iZq2TGqMVoS" },
                    { 12, 8, "Chess Ultra 2 is a chess game that offers a realistic and immersive chess experience. You can play chess against the AI, online players, or your friends. You can also customize your chess pieces, boards, and environments. The game features a 4K graphics, a VR support, and a tutorial mode that teaches you the basics and advanced strategies of chess.", "PC, PS4, PS5, Xbox One, Xbox Series X/S, Nintendo Switch", 19.989999999999998, "Chess Ultra 2", "https://youtu.be/cCRTRsQ2W1U?si=IIyghmHeULPfY0FR" },
                    { 13, 7, "FIFA 23 is a soccer simulation game that lets you play as your favorite teams and players from around the world. You can compete in various modes, such as career, ultimate team, volta, and champions league. The game features a realistic and responsive gameplay, a stunning graphics, and a dynamic commentary.", "PC, PS4, PS5, Xbox One, Xbox Series X/S, Nintendo Switch", 59.990000000000002, "FIFA 23", "https://youtu.be/0tIW1X2dv0c?si=9WCaJeYjk6iuYONJ" },
                    { 14, 7, "PES 2023 is a soccer simulation game that offers a realistic and immersive soccer experience. You can play as your favorite teams and players from around the world. You can also create your own team and customize your players, kits, and stadiums. The game features a fluid and adaptive gameplay, a stunning graphics, and a realistic physics.", "PC, PS4, PS5, Xbox One, Xbox Series X/S", 59.990000000000002, "PES 2023", "https://youtu.be/nce2U6ZcGPI?si=_lZVe1-FYeObSqwm" },
                    { 15, 7, "Need for Speed Most Wanted is a racing game that lets you drive the most wanted cars in the world. You can race against the police, your rivals, or your friends. You can also customize your cars, challenge other players, and explore the open world. The game features a fast and furious gameplay, a realistic and dynamic world, and a social and competitive online mode.", "PC, PS4, PS5, Xbox One, Xbox Series X/S", 59.990000000000002, "Need for Speed Most Wanted", "https://youtu.be/DEmRkNnCvLU?si=G1AUIpvP36CKsjOt" },
                    { 16, 7, "Rocket League is a sports game that combines soccer and rocket-powered cars. You can play solo or with your friends in various modes, such as casual, competitive, rumble, dropshot, and hoops. You can also customize your cars, unlock new items, and join tournaments. The game features a fun and addictive gameplay, a colorful and vibrant graphics, and a cross-platform support.", "PC, PS4, PS5, Xbox One, Xbox Series X/S, Nintendo Switch", 19.989999999999998, "Rocket League", "https://youtu.be/SgSX3gOrj60?si=uET9O2N-M313KhcK" },
                    { 17, 7, "Gran Turismo 7 is a racing simulation game that offers a realistic and immersive driving experience. You can drive over 400 cars from various manufacturers, brands, and eras. You can also race on over 100 tracks from around the world, including the legendary Nürburgring. The game features a stunning graphics, a realistic physics, and a VR support.", "PS5", 69.989999999999995, "Gran Turismo 7", "https://youtu.be/1tBUsXIkG1A?si=g0GqSxLHXyfvPbO1" },
                    { 18, 7, "Forza Motorsport 8 is a racing simulation game that lets you experience the thrill of motorsport. You can drive over 700 cars from various categories, such as GT, Formula 1, NASCAR, and more. You can also race on over 200 tracks from around the world, including the iconic Indianapolis Motor Speedway. The game features a stunning graphics, a realistic physics, and a dynamic weather and time system.", "Xbox Series X/S, PC", 69.989999999999995, "Forza Motorsport 8", "https://youtu.be/yJumrR_bbg0?si=fHmiuysbuMWvMtne" },
                    { 19, 7, "NBA 2K24 is a basketball simulation game that lets you play as your favorite NBA teams and players. You can compete in various modes, such as career, my team, my park, and my league. The game features a realistic and responsive gameplay, a stunning graphics, and a dynamic commentary.", "PC, PS4, PS5, Xbox One, Xbox Series X/S, Nintendo Switch", 69.989999999999995, "NBA 2K24", "https://youtu.be/OJS1BVniz5c?si=LEs2mtn03lGWFTf7" },
                    { 20, 7, "Madden NFL 24 is a football simulation game that lets you play as your favorite NFL teams and players. You can compete in various modes, such as franchise, ultimate team, superstar KO, and face of the franchise. The game features a realistic and responsive gameplay, a stunning graphics, and a dynamic commentary.", "PC, PS4, PS5, Xbox One, Xbox Series X/S", 69.989999999999995, "Madden NFL 24", "https://youtu.be/UVZ0IIeW2mw?si=VjgGeEMMeHEp2Gnd" },
                    { 21, 6, "Brain Age: Switch Up Your Brain is a brain training game that helps you improve your mental skills and cognitive abilities. You can play various exercises, such as math, memory, logic, and more. You can also challenge your friends and family in multiplayer mode. The game features a fun and interactive gameplay, a personalized feedback, and a voice recognition system.", "Nintendo Switch", 29.989999999999998, "Brain Age: Switch Up Your Brain", "https://youtu.be/Bg13HWedwyk?si=RVqUmr-a3XWqE63w" },
                    { 22, 6, "Civilization VII is a turn-based strategy game that lets you build and lead your own civilization from the ancient times to the future. You can choose from various leaders, cultures, and ideologies. You can also explore the world, research technologies, build wonders, wage wars, and engage in diplomacy. The game features a rich and immersive gameplay, a stunning graphics, and a dynamic world.", "PC, PS5, Xbox Series X/S", 59.990000000000002, "Civilization VII", "https://youtu.be/FYTtl8LC_vg?si=ZnQ5_9sD7n7fcDZ4" },
                    { 23, 6, "Kerbal Space Program 2 is a space simulation game that lets you create and manage your own space program. You can design, build, and launch rockets, satellites, space stations, and more. You can also explore the solar system, colonize planets, and discover new technologies. The game features a realistic and physics-based gameplay, a creative and sandbox mode, and a multiplayer mode that allows you to cooperate or compete with other players.", "PC, PS4, PS5, Xbox One, Xbox Series X/S", 59.990000000000002, "Kerbal Space Program 2", "https://youtu.be/P_nj6wW6Gsc?si=4H5oecZGGXMlcMdi" },
                    { 24, 6, "Minecraft: Education Edition is a game-based learning platform that helps students and teachers explore, create, and collaborate in a virtual world. You can use Minecraft to learn about various subjects, such as math, science, history, and art. You can also access various lessons, worlds, and resources that are designed for education. The game features a fun and engaging gameplay, a cross-platform support, and a classroom mode that allows teachers to manage and monitor students.", "PC, iOS, Android, Chromebook", 14.99, "Minecraft: Education Edition", "https://youtu.be/5QYqmTSJWRo?si=Cfs3fRN0jc5bJ5Cn" },
                    { 25, 6, "SimCity 6 is a city-building simulation game that lets you create and manage your own city. You can plan, design, and build your city from the ground up. You can also deal with various challenges, such as traffic, pollution, crime, and disasters. The game features a realistic and dynamic gameplay, a stunning graphics, and a multiplayer mode that allows you to share and visit other cities.", "PC, PS5, Xbox Series X/S", 59.990000000000002, "SimCity 6", "https://youtu.be/Z5fJL_WpItI?si=Virdf9MdHH01_v-x" },
                    { 26, 5, "Animal Crossing: New Horizons 2 is a life simulation game that lets you create and customize your own island paradise. You can decorate your home, grow crops, craft items, and interact with various animal villagers. You can also visit other islands, invite friends, and enjoy seasonal events. The game features a relaxing and charming gameplay, a colorful and vibrant graphics, and a cross-platform support.", "Nintendo Switch", 59.990000000000002, "Animal Crossing: New Horizons 2", "https://youtu.be/InDJvcWtTCw?si=z5CojiHuegGLk284" },
                    { 27, 5, "Stardew Valley 2 is a farming simulation game that lets you escape to the countryside and start a new life. You can farm, fish, mine, cook, and craft. You can also befriend the locals, romance a partner, and start a family. You can also explore the mysterious caves, forests, and islands. The game features a relaxing and addictive gameplay, a pixelated and retro graphics, and a multiplayer mode that allows you to play with up to three friends.", "PC, PS4, PS5, Xbox One, Xbox Series X/S, Nintendo Switch, iOS, Android", 19.989999999999998, "Stardew Valley 2", "https://youtu.be/ASlkM-mf1zk?si=VSoI3Y7zWZgNc89F" },
                    { 28, 5, "Fall Guys: Ultimate Knockout 2 is a party game that lets you compete in a series of hilarious and chaotic mini-games. You can play as a colorful and cute bean-shaped character and try to survive the obstacles, traps, and other players. You can also customize your character, unlock new outfits, and join teams. The game features a fun and frantic gameplay, a bright and cheerful graphics, and a cross-platform support.", "PC, PS4, PS5, Xbox One, Xbox Series X/S, Nintendo Switch", 19.989999999999998, "Fall Guys: Ultimate Knockout 2", "https://youtu.be/DDz8smFK3QI?si=1eYvUcFXTNXvUt0D" },
                    { 29, 5, "Among Us 2 is a social deduction game that lets you play as a crewmate or an impostor in a spaceship. You can play with up to 15 players online or locally. As a crewmate, you have to complete tasks and find the impostor. As an impostor, you have to kill the crewmates and sabotage the ship. The game features a suspenseful and thrilling gameplay, a cartoonish and simple graphics, and a cross-platform support.", "PC, iOS, Android", 4.9900000000000002, "Among Us 2", "https://youtu.be/PjPSrd1HB8s?si=wN7lqNhpaXfmPlcM" },
                    { 30, 5, "Super Mario Party 2 is a party game that lets you play as your favorite Mario characters and compete in various mini-games. You can play with up to four players online or locally. You can also choose from different modes, such as board game, rhythm, and puzzle. The game features a fun and exciting gameplay, a colorful and lively graphics, and a cross-platform support.", "Nintendo Switch", 59.990000000000002, "Super Mario Party 2", "https://youtu.be/my-jYVD_gmA?si=MoODRYPnGPOMvTl3" },
                    { 31, 4, "Age of Empires IV is a real-time strategy game that lets you relive the epic battles of history. You can choose from various civilizations, such as Mongols, Chinese, English, and French. You can also build your empire, research technologies, train units, and wage wars. The game features a realistic and immersive gameplay, a stunning graphics, and a campaign mode that tells the stories of the great leaders and empires.", "PC", 59.990000000000002, "Age of Empires IV", "https://youtu.be/5TnynE3PuDE?si=P4fREnIYPRFNXCdH" },
                    { 32, 4, "XCOM 3 is a turn-based strategy game that lets you lead the resistance against an alien invasion. You can command your squad of soldiers, scientists, and engineers. You can also research alien technologies, build facilities, and engage in tactical combat. The game features a challenging and strategic gameplay, a rich and diverse world, and a permadeath system that makes every decision matter.", "PC, PS5, Xbox Series X/S", 59.990000000000002, "XCOM 3", "https://youtu.be/aZnpl3hWfVM?si=fnt6NC-qV44NRFS5" },
                    { 33, 4, "Total War: Warhammer III is a strategy game that combines the turn-based empire building of Total War with the real-time battles of Warhammer. You can choose from various factions, such as Kislev, Cathay, Khorne, and Tzeentch. You can also explore the world, recruit legendary heroes, and fight epic wars. The game features a massive and detailed gameplay, a stunning graphics, and a multiplayer mode that allows you to cooperate or compete with other players.", "PC", 59.990000000000002, "Total War: Warhammer III", "https://youtu.be/HAr7yUlM0Po?si=zde_XuccRjLm75Ty" },
                    { 34, 4, "Crusader Kings IV is a grand strategy game that lets you create your own medieval dynasty. You can play as any historical or fictional character, from a king to a peasant. You can also shape your character, manage your realm, expand your influence, and deal with various events, such as wars, plagues, and intrigues. The game features a deep and complex gameplay, a dynamic and emergent world, and a modding support that allows you to create and share your own scenarios.", "PC", 49.990000000000002, "Crusader Kings IV", "https://youtu.be/sD5GsZaF39k?si=fQqwiGyvrJC0Dq7s" },
                    { 35, 4, "StarCraft III is a sci-fi strategy game that lets you play as one of the three races: Terran, Zerg, or Protoss. You can build your base, gather resources, train units, and wage wars. You can also follow the story of the legendary heroes, such as Jim Raynor, Sarah Kerrigan, and Artanis. The game features a fast and competitive gameplay, a stunning graphics, and a multiplayer mode that allows you to play with or against other players.", "PC", 59.990000000000002, "StarCraft III", "https://youtu.be/MVbeoSPqRs4?si=tZz2JJ1P_nILupib" },
                    { 36, 3, "Valorant is a character-based 5v5 tactical shooter set on the global stage. Outwit, outplay, and outshine your competition with tactical abilities, precise gunplay, and adaptive teamwork. The game features a diverse and balanced gameplay, a stylish and colorful graphics, and a competitive and ranked mode that tests your skills and strategies.", "PC", 0.0, "Valorant", "https://youtu.be/e_E9W2vsRbQ?si=2ASg49FtAy8NZfEd" },
                    { 37, 3, "Counter-Strike 2 is a first-person shooter that pits two teams of terrorists and counter-terrorists against each other. You can play various modes, such as bomb defusal, hostage rescue, and deathmatch. You can also buy and customize your weapons, communicate with your teammates, and complete objectives. The game features a realistic and intense gameplay, a realistic and dynamic world, and a cross-platform support.", "PC, PS5, Xbox Series X/S", 29.989999999999998, "Counter-Strike 2", "https://youtu.be/kDDnvAr6gGI?si=r8tNmJENBpiEgJSj" },
                    { 38, 3, "Apex Legends is a battle royale shooter that lets you play as one of the legends, each with their own unique abilities and personality. You can team up with two other players and compete with 60 other players in a massive map. You can also loot weapons, items, and vehicles, and use them to survive and win. The game features a fast and fluid gameplay, a stunning graphics, and a cross-platform support.", "PC, PS4, PS5, Xbox One, Xbox Series X/S, Nintendo Switch", 0.0, "Apex Legends", "https://youtu.be/Ix-6DAcuPcg?si=9583M3hyoGJl8IM-" },
                    { 39, 3, "Call of Duty Warzone is a free-to-play battle royale shooter that lets you play as a soldier in the Call of Duty universe. You can play solo or with your friends in various modes, such as battle royale, plunder, and rebirth. You can also customize your loadout, use killstreaks, and revive your teammates. The game features a realistic and immersive gameplay, a stunning graphics, and a cross-platform support.", "PC, PS4, PS5, Xbox One, Xbox Series X/S", 0.0, "Call of Duty Warzone", "https://youtu.be/0E44DClsX5Q?si=v4NaJqQfTehNNtiT" },
                    { 40, 3, "Halo Infinite is a sci-fi shooter that lets you play as the Master Chief, a legendary Spartan soldier who fights against the alien Covenant. You can explore the Halo ring, a massive and mysterious world full of secrets and dangers. You can also use various weapons, vehicles, and equipment to combat your enemies. The game features a epic and cinematic gameplay, a stunning graphics, and a multiplayer mode that allows you to play with or against other players.", "PC, Xbox One, Xbox Series X/S", 69.989999999999995, "Halo Infinite", "https://youtu.be/PyMlV5_HRWk?si=2UtquXPRLuvMiZhp" },
                    { 41, 3, "Destiny 2 is a sci-fi shooter that lets you play as a Guardian, a protector of the last city on Earth. You can choose from various classes, such as Titan, Hunter, and Warlock. You can also customize your weapons, armor, and abilities. You can also explore the solar system, fight against various enemies, and join forces with other players. The game features a rich and immersive gameplay, a stunning graphics, and a cross-platform support.", "PC, PS4, PS5, Xbox One, Xbox Series X/S, Stadia", 0.0, "Destiny 2", "https://youtu.be/Ehl6aWUiA4Y?si=AgOjZRu1w21LHQgy" },
                    { 42, 2, "Metroid Prime: Remastered is a remastered version of the classic first-person adventure game that takes you to the mysterious world of Tallon IV. Explore the ruins of an ancient civilization, fight deadly enemies, and uncover the secrets of the Space Pirates and the mysterious substance called Phazon.", "Nintendo Switch", 59.990000000000002, "Metroid Prime: Remastered", "https://youtu.be/e9OQOJC1QII?si=D0ok2ppT2UsHv0tq" },
                    { 43, 2, "Starfield is a sci-fi RPG that lets you create your own character and explore the galaxy. You can travel to various planets, star systems, and space stations. You can also customize your spaceship, engage in combat, and interact with various factions and aliens. The game features a vast and immersive gameplay, a stunning graphics, and a modding support.", "PC, Xbox Series X/S", 69.989999999999995, "Starfield", "https://youtu.be/kfYEiTdsyas?si=fK8oWdk-gXqPNlQ-" },
                    { 44, 2, "Star Wars Jedi: Survivor is a sci-fi action game that follows the story of a Jedi who survived the Order 66 and the rise of the Empire. You play as Cal Kestis, a former Padawan who is hiding his identity and powers. You will use your lightsaber, force abilities, and droid companion to fight against the Inquisitors, stormtroopers, and other enemies. The game features a cinematic and thrilling gameplay, a rich and diverse world, and a original soundtrack.", "PC, PS5, Xbox Series X/S", 59.990000000000002, "Star Wars Jedi: Survivor", "https://youtu.be/VRaobDJjiec?si=ZQWV-Wh0Hao2ggUe" },
                    { 45, 1, "Zelda: Tears of the Kingdom is a fantasy action-adventure game that lets you play as Link, a young hero who must save the kingdom of Hyrule from a dark and evil force. You can explore the vast and beautiful world, solve puzzles, collect items, and fight enemies. You can also use various weapons, tools, and abilities, such as the Master Sword, the Sheikah Slate, and the Champion's Powers. The game features a stunning and immersive gameplay, a breathtaking graphics, and a dynamic weather and time system.", "Nintendo Switch", 69.989999999999995, "Zelda: Tears of the Kingdom", "https://youtu.be/uHGShqcAHlQ?si=riJ5u8cW52_qYFL3" },
                    { 46, 1, "Spider-Man 2 is a superhero action game that lets you play as Spider-Man, a web-slinging hero who protects New York City from various threats. You can swing through the city, fight against villains, and save the citizens. You can also use various suits, gadgets, and skills, such as the Spider-Sense, the Web-Shooters, and the Venom Blast. The game features a realistic and dynamic gameplay, a stunning graphics, and a captivating story.", "PS5", 69.989999999999995, "Spider-Man 2", "https://youtu.be/nq1M_Wc4FIc?si=PUf2wD0jlIdRhxEQ" },
                    { 47, 1, "Street Fighter 6 is a fighting game that lets you play as one of the legendary fighters from the Street Fighter series. You can choose from various characters, such as Ryu, Chun-Li, Ken, and Akuma. You can also use various moves, combos, and special attacks, such as the Hadoken, the Shoryuken, and the Raging Demon. The game features a fast and furious gameplay, a stunning graphics, and a multiplayer mode that allows you to play with or against other players.", "PC, PS5, Xbox Series X/S", 59.990000000000002, "Street Fighter 6", "https://youtu.be/1INU3FOJsTw?si=MDTRXPFfzH9yrI8j" },
                    { 48, 1, "Final Fantasy 16 is a fantasy RPG that lets you play as Clive Rosfield, a young knight who is the protector of his brother Joshua, the Dominant of the Phoenix. You will embark on a journey to face the dark and twisted fate that awaits you. You will use various weapons, magic, and summons to combat your enemies. The game features a epic and dramatic gameplay, a stunning graphics, and a original soundtrack.", "PS5", 69.989999999999995, "Final Fantasy 16", "https://youtu.be/aPT26Dd3OzE?si=Sehz3mvz9i6gIOTw" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 48);
        }
    }
}
