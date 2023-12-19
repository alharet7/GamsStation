using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/MetroidPrimeRemastered.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/ResidentEvil4.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/TheMedium.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/Outlast3.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/SilentHillRebirth.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/TheEvilWithin3.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/DyingLight2.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/TheWitness.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/Portal3.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/TetrisEffect2.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/TheTalosPrinciple2.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/ChessUltra2.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/FIFA23.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/PES23.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/NeedforSpeedMostWanted.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/RocketLeague.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/GranTurismo7.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/ForzaMotorsport8.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/NBA2K24.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/MaddenNFL24.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/BrainAgeSwitchUpYourBrain.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/CivilizationVII.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/KerbalSpaceProgram2.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/MinecraftEducationEdition.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/SimCity6.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/AnimalCrossingNewHorizons2.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/StardewValley.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/FallGuysUltimateKnockout.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/AmongUs.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/SuperMarioParty2.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/AgeofEmpiresV.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/XCOM3.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/TotalWarWarhammerIII.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/CrusaderKingsIV.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/StarCraftIII.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/Valorant.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/CounterStrike2.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/ApexLegends.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/CallofDutyWarzone.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 40,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/HaloInfinite.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageURL",
                value: "https://gamsstation.blob.core.windows.net/gamsstation/Destiny2.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "ImageURL", "Platform", "Price", "Title", "Trailer" },
                values: new object[] { "Starfield is a sci-fi RPG that lets you create your own character and explore the galaxy. You can travel to various planets, star systems, and space stations. You can also customize your spaceship, engage in combat, and interact with various factions and aliens. The game features a vast and immersive gameplay, a stunning graphics, and a modding support.", "https://gamsstation.blob.core.windows.net/gamsstation/Starfield.png", "PC, Xbox Series X/S", 69.989999999999995, "Starfield", "https://youtu.be/kfYEiTdsyas?si=fK8oWdk-gXqPNlQ-" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "ImageURL", "Platform", "Price", "Title", "Trailer" },
                values: new object[] { "Star Wars Jedi: Survivor is a sci-fi action game that follows the story of a Jedi who survived the Order 66 and the rise of the Empire. You play as Cal Kestis, a former Padawan who is hiding his identity and powers. You will use your lightsaber, force abilities, and droid companion to fight against the Inquisitors, stormtroopers, and other enemies. The game features a cinematic and thrilling gameplay, a rich and diverse world, and a original soundtrack.", "https://gamsstation.blob.core.windows.net/gamsstation/StarWarsJediSurvivor.png", "PC, PS5, Xbox Series X/S", 59.990000000000002, "Star Wars Jedi: Survivor", "https://youtu.be/VRaobDJjiec?si=ZQWV-Wh0Hao2ggUe" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Platform", "Price", "Title", "Trailer" },
                values: new object[] { 1, "Zelda: Tears of the Kingdom is a fantasy action-adventure game that lets you play as Link, a young hero who must save the kingdom of Hyrule from a dark and evil force. You can explore the vast and beautiful world, solve puzzles, collect items, and fight enemies. You can also use various weapons, tools, and abilities, such as the Master Sword, the Sheikah Slate, and the Champion's Powers. The game features a stunning and immersive gameplay, a breathtaking graphics, and a dynamic weather and time system.", "https://gamsstation.blob.core.windows.net/gamsstation/ZeldaTearsoftheKingdom.png", "Nintendo Switch", 69.989999999999995, "Zelda: Tears of the Kingdom", "https://youtu.be/uHGShqcAHlQ?si=riJ5u8cW52_qYFL3" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "ImageURL", "Platform", "Title", "Trailer" },
                values: new object[] { "Spider-Man 2 is a superhero action game that lets you play as Spider-Man, a web-slinging hero who protects New York City from various threats. You can swing through the city, fight against villains, and save the citizens. You can also use various suits, gadgets, and skills, such as the Spider-Sense, the Web-Shooters, and the Venom Blast. The game features a realistic and dynamic gameplay, a stunning graphics, and a captivating story.", "https://gamsstation.blob.core.windows.net/gamsstation/SpiderMan2.png", "PS5", "Spider-Man 2", "https://youtu.be/nq1M_Wc4FIc?si=PUf2wD0jlIdRhxEQ" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "ImageURL", "Platform", "Price", "Title", "Trailer" },
                values: new object[] { "Street Fighter 6 is a fighting game that lets you play as one of the legendary fighters from the Street Fighter series. You can choose from various characters, such as Ryu, Chun-Li, Ken, and Akuma. You can also use various moves, combos, and special attacks, such as the Hadoken, the Shoryuken, and the Raging Demon. The game features a fast and furious gameplay, a stunning graphics, and a multiplayer mode that allows you to play with or against other players.", "https://gamsstation.blob.core.windows.net/gamsstation/StreetFighter6.png", "PC, PS5, Xbox Series X/S", 59.990000000000002, "Street Fighter 6", "https://youtu.be/1INU3FOJsTw?si=MDTRXPFfzH9yrI8j" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "ImageURL", "Platform", "Price", "Title", "Trailer" },
                values: new object[] { "Final Fantasy 16 is a fantasy RPG that lets you play as Clive Rosfield, a young knight who is the protector of his brother Joshua, the Dominant of the Phoenix. You will embark on a journey to face the dark and twisted fate that awaits you. You will use various weapons, magic, and summons to combat your enemies. The game features a epic and dramatic gameplay, a stunning graphics, and a original soundtrack.", "https://gamsstation.blob.core.windows.net/gamsstation/FinalFantasy16.png", "PS5", 69.989999999999995, "Final Fantasy 16", "https://youtu.be/aPT26Dd3OzE?si=Sehz3mvz9i6gIOTw" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 40,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "ImageURL", "Platform", "Price", "Title", "Trailer" },
                values: new object[] { "Metroid Prime: Remastered is a remastered version of the classic first-person adventure game that takes you to the mysterious world of Tallon IV. Explore the ruins of an ancient civilization, fight deadly enemies, and uncover the secrets of the Space Pirates and the mysterious substance called Phazon.", "", "Nintendo Switch", 59.990000000000002, "Metroid Prime: Remastered", "https://youtu.be/e9OQOJC1QII?si=D0ok2ppT2UsHv0tq" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "ImageURL", "Platform", "Price", "Title", "Trailer" },
                values: new object[] { "Starfield is a sci-fi RPG that lets you create your own character and explore the galaxy. You can travel to various planets, star systems, and space stations. You can also customize your spaceship, engage in combat, and interact with various factions and aliens. The game features a vast and immersive gameplay, a stunning graphics, and a modding support.", "", "PC, Xbox Series X/S", 69.989999999999995, "Starfield", "https://youtu.be/kfYEiTdsyas?si=fK8oWdk-gXqPNlQ-" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Platform", "Price", "Title", "Trailer" },
                values: new object[] { 2, "Star Wars Jedi: Survivor is a sci-fi action game that follows the story of a Jedi who survived the Order 66 and the rise of the Empire. You play as Cal Kestis, a former Padawan who is hiding his identity and powers. You will use your lightsaber, force abilities, and droid companion to fight against the Inquisitors, stormtroopers, and other enemies. The game features a cinematic and thrilling gameplay, a rich and diverse world, and a original soundtrack.", "", "PC, PS5, Xbox Series X/S", 59.990000000000002, "Star Wars Jedi: Survivor", "https://youtu.be/VRaobDJjiec?si=ZQWV-Wh0Hao2ggUe" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "ImageURL", "Platform", "Title", "Trailer" },
                values: new object[] { "Zelda: Tears of the Kingdom is a fantasy action-adventure game that lets you play as Link, a young hero who must save the kingdom of Hyrule from a dark and evil force. You can explore the vast and beautiful world, solve puzzles, collect items, and fight enemies. You can also use various weapons, tools, and abilities, such as the Master Sword, the Sheikah Slate, and the Champion's Powers. The game features a stunning and immersive gameplay, a breathtaking graphics, and a dynamic weather and time system.", "", "Nintendo Switch", "Zelda: Tears of the Kingdom", "https://youtu.be/uHGShqcAHlQ?si=riJ5u8cW52_qYFL3" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "ImageURL", "Platform", "Price", "Title", "Trailer" },
                values: new object[] { "Spider-Man 2 is a superhero action game that lets you play as Spider-Man, a web-slinging hero who protects New York City from various threats. You can swing through the city, fight against villains, and save the citizens. You can also use various suits, gadgets, and skills, such as the Spider-Sense, the Web-Shooters, and the Venom Blast. The game features a realistic and dynamic gameplay, a stunning graphics, and a captivating story.", "", "PS5", 69.989999999999995, "Spider-Man 2", "https://youtu.be/nq1M_Wc4FIc?si=PUf2wD0jlIdRhxEQ" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "ImageURL", "Platform", "Price", "Title", "Trailer" },
                values: new object[] { "Street Fighter 6 is a fighting game that lets you play as one of the legendary fighters from the Street Fighter series. You can choose from various characters, such as Ryu, Chun-Li, Ken, and Akuma. You can also use various moves, combos, and special attacks, such as the Hadoken, the Shoryuken, and the Raging Demon. The game features a fast and furious gameplay, a stunning graphics, and a multiplayer mode that allows you to play with or against other players.", "", "PC, PS5, Xbox Series X/S", 59.990000000000002, "Street Fighter 6", "https://youtu.be/1INU3FOJsTw?si=MDTRXPFfzH9yrI8j" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Platform", "Price", "Title", "Trailer" },
                values: new object[] { 48, 1, "Final Fantasy 16 is a fantasy RPG that lets you play as Clive Rosfield, a young knight who is the protector of his brother Joshua, the Dominant of the Phoenix. You will embark on a journey to face the dark and twisted fate that awaits you. You will use various weapons, magic, and summons to combat your enemies. The game features a epic and dramatic gameplay, a stunning graphics, and a original soundtrack.", "", "PS5", 69.989999999999995, "Final Fantasy 16", "https://youtu.be/aPT26Dd3OzE?si=Sehz3mvz9i6gIOTw" });
        }
    }
}
