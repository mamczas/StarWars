using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWars.Migrations
{
    public partial class StarsShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StarShips",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CargoCapacity = table.Column<long>(nullable: false),
                    Consumables = table.Column<string>(nullable: true),
                    CostInCredits = table.Column<long>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Crew = table.Column<long>(nullable: false),
                    Edited = table.Column<DateTime>(nullable: false),
                    HyperdriveRating = table.Column<double>(nullable: false),
                    Length = table.Column<long>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    Max_atmosphering_speed = table.Column<int>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Passengers = table.Column<int>(nullable: false),
                    Starship_class = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarShips", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "StarShips",
                columns: new[] { "Id", "CargoCapacity", "Consumables", "CostInCredits", "Created", "Crew", "Edited", "HyperdriveRating", "Length", "Manufacturer", "Max_atmosphering_speed", "Model", "Name", "Passengers", "Starship_class" },
                values: new object[,]
                {
                    { 1, 250000000L, "6 years", 1143350000L, new DateTime(2014, 12, 15, 12, 31, 42, 547, DateTimeKind.Utc), 279144L, new DateTime(2017, 4, 19, 10, 56, 6, 685, DateTimeKind.Utc).AddTicks(5920), 0.0, 19000L, "Kuat Drive Yards, Fondor Shipyards", 0, "Executor-class star dreadnought", "Executor", 38000, "Star dreadnought" },
                    { 21, 0L, "unknown", 0L, new DateTime(2014, 12, 20, 17, 46, 46, 847, DateTimeKind.Utc), 4L, new DateTime(2014, 12, 22, 17, 35, 45, 158, DateTimeKind.Utc).AddTicks(9690), 0.0, 0L, "Theed Palace Space Vessel Engineering Corps", 8000, "H-type Nubian yacht", "H-type Nubian yacht", 0, "yacht" },
                    { 22, 36000000L, "2 years", 150000000L, new DateTime(2014, 12, 10, 15, 8, 19, 848, DateTimeKind.Utc), 47060L, new DateTime(2014, 12, 22, 17, 35, 44, 410, DateTimeKind.Utc).AddTicks(9410), 0.0, 0L, "Kuat Drive Yards", 975, "Imperial I-class Star Destroyer", "Star Destroyer", 0, "Star Destroyer" },
                    { 23, 50000000L, "4 years", 125000000L, new DateTime(2014, 12, 20, 19, 40, 21, 902, DateTimeKind.Utc), 600L, new DateTime(2014, 12, 22, 17, 35, 45, 195, DateTimeKind.Utc).AddTicks(1650), 0.0, 1088L, "Rendili StarDrive, Free Dac Volunteers Engineering corps.", 1050, "Providence-class carrier/destroyer", "Trade Federation cruiser", 48247, "capital ship" },
                    { 24, 50000L, "56 days", 1000000L, new DateTime(2014, 12, 20, 19, 48, 40, 409, DateTimeKind.Utc), 5L, new DateTime(2014, 12, 22, 17, 35, 45, 208, DateTimeKind.Utc).AddTicks(5840), 0.0, 0L, "Cygnus Spaceworks", 2000, "Theta-class T-2c shuttle", "Theta-class T-2c shuttle", 16, "transport" },
                    { 25, 0L, "unknown", 0L, new DateTime(2015, 4, 17, 6, 58, 50, 614, DateTimeKind.Utc).AddTicks(4750), 1L, new DateTime(2015, 4, 17, 6, 58, 50, 614, DateTimeKind.Utc).AddTicks(5280), 0.0, 0L, "Incom", 0, "T-70 X-wing fighter", "T-70 X-wing fighter", 0, "fighter" },
                    { 26, 19000000L, "6 months", 0L, new DateTime(2014, 12, 15, 12, 34, 52, 264, DateTimeKind.Utc), 6L, new DateTime(2014, 12, 22, 17, 35, 44, 680, DateTimeKind.Utc).AddTicks(8380), 0.0, 90L, "Gallofree Yards, Inc.", 650, "GR-75 medium transport", "Rebel transport", 90, "Medium transport" },
                    { 27, 4000000000L, "500 days", 0L, new DateTime(2014, 12, 19, 17, 4, 6, 323, DateTimeKind.Utc), 175L, new DateTime(2014, 12, 22, 17, 35, 45, 42, DateTimeKind.Utc).AddTicks(9000), 0.0, 3170L, "Hoersch-Kessel Drive, Inc.", 0, "Lucrehulk-class Droid Control Ship", "Droid control ship", 139000, "Droid control ship" },
                    { 28, 11250000L, "2 years", 0L, new DateTime(2014, 12, 20, 18, 8, 42, 926, DateTimeKind.Utc), 700L, new DateTime(2014, 12, 22, 17, 35, 45, 171, DateTimeKind.Utc).AddTicks(6530), 0.0, 752L, "Rothana Heavy Engineering", 0, "Acclamator I-class assault ship", "Republic Assault ship", 16000, "assault ship" },
                    { 29, 240L, "7 days", 35700L, new DateTime(2014, 12, 20, 18, 37, 56, 969, DateTimeKind.Utc), 3L, new DateTime(2014, 12, 22, 17, 35, 45, 183, DateTimeKind.Utc).AddTicks(750), 0.0, 0L, "Huppla Pasa Tisc Shipwrights Collective", 1600, "Punworcca 116-class interstellar sloop", "Solar Sailer", 11, "yacht" },
                    { 30, 20000000L, "2 years", 59000000L, new DateTime(2014, 12, 20, 19, 52, 56, 232, DateTimeKind.Utc), 7400L, new DateTime(2014, 12, 22, 17, 35, 45, 224, DateTimeKind.Utc).AddTicks(5400), 0.0, 1137L, "Kuat Drive Yards, Allanteen Six shipyards", 975, "Senator-class Star Destroyer", "Republic attack cruiser", 2000, "star destroyer" },
                    { 31, 0L, "unknown", 0L, new DateTime(2014, 12, 20, 19, 55, 15, 396, DateTimeKind.Utc), 3L, new DateTime(2014, 12, 22, 17, 35, 45, 258, DateTimeKind.Utc).AddTicks(8590), 0.0, 0L, "Theed Palace Space Vessel Engineering Corps/Nubia Star Drives, Incorporated", 1050, "J-type star skiff", "Naboo star skiff", 3, "yacht" },
                    { 32, 60L, "2 days", 320000L, new DateTime(2014, 12, 20, 19, 56, 57, 468, DateTimeKind.Utc), 1L, new DateTime(2014, 12, 22, 17, 35, 45, 272, DateTimeKind.Utc).AddTicks(3490), 0.0, 0L, "Kuat Systems Engineering", 1500, "Eta-2 Actis-class light interceptor", "Jedi Interceptor", 0, "starfighter" },
                    { 33, 110L, "5 days", 155000L, new DateTime(2014, 12, 20, 20, 3, 48, 603, DateTimeKind.Utc), 3L, new DateTime(2014, 12, 22, 17, 35, 45, 287, DateTimeKind.Utc).AddTicks(2140), 0.0, 0L, "Incom Corporation, Subpro Corporation", 1000, "Aggressive Reconnaissance-170 starfighte", "arc-170", 0, "starfighter" },
                    { 34, 140L, "7 days", 168000L, new DateTime(2014, 12, 20, 20, 38, 5, 31, DateTimeKind.Utc), 1L, new DateTime(2014, 12, 22, 17, 35, 45, 381, DateTimeKind.Utc).AddTicks(9000), 6.0, 0L, "Feethan Ottraw Scalable Assemblies", 1100, "Belbullab-22 starfighter", "Belbullab-22 starfighter", 0, "starfighter" },
                    { 35, 60L, "15 hours", 102500L, new DateTime(2014, 12, 20, 20, 43, 4, 349, DateTimeKind.Utc), 1L, new DateTime(2014, 12, 22, 17, 35, 45, 396, DateTimeKind.Utc).AddTicks(7110), 0.0, 0L, "Kuat Systems Engineering", 1050, "Alpha-3 Nimbus-class V-wing starfighter", "V-wing", 0, "starfighter" },
                    { 20, 60L, "7 days", 180000L, new DateTime(2014, 12, 20, 17, 35, 23, 906, DateTimeKind.Utc), 1L, new DateTime(2014, 12, 22, 17, 35, 45, 147, DateTimeKind.Utc).AddTicks(7460), 0.0, 8L, "Kuat Systems Engineering", 1150, "Delta-7 Aethersprite-class interceptor", "Jedi starfighter", 0, "Starfighter" },
                    { 36, 3000000L, "1 year", 3500000L, new DateTime(2014, 12, 10, 14, 20, 33, 369, DateTimeKind.Utc), 165L, new DateTime(2014, 12, 22, 17, 35, 45, 408, DateTimeKind.Utc).AddTicks(3680), 0.0, 150L, "Corellian Engineering Corporation", 950, "CR90 corvette", "CR90 corvette", 600, "corvette" },
                    { 19, 0L, "unknown", 0L, new DateTime(2014, 12, 20, 17, 24, 23, 509, DateTimeKind.Utc), 0L, new DateTime(2014, 12, 22, 17, 35, 45, 135, DateTimeKind.Utc).AddTicks(9870), 0.0, 390L, "Botajef Shipyards", 0, "Botajef AA-9 Freighter-Liner", "AA-9 Coruscant freighter", 30000, "freighter" },
                    { 17, 2500000L, "30 days", 55000000L, new DateTime(2014, 12, 20, 9, 39, 56, 116, DateTimeKind.Utc), 1L, new DateTime(2014, 12, 22, 17, 35, 45, 105, DateTimeKind.Utc).AddTicks(5220), 0.0, 0L, "Republic Sienar Systems", 1180, "Star Courier", "Scimitar", 6, "Space Transport" },
                    { 2, 180000L, "1 month", 240000L, new DateTime(2014, 12, 10, 15, 48, 0, 586, DateTimeKind.Utc), 5L, new DateTime(2014, 12, 22, 17, 35, 44, 431, DateTimeKind.Utc).AddTicks(4070), 0.0, 38L, "Sienar Fleet Systems, Cyngus Spaceworks", 1000, "Sentinel-class landing craft", "Sentinel-class landing craft", 75, "landing craft" },
                    { 3, 1000000000000L, "3 years", 1000000000000L, new DateTime(2014, 12, 10, 16, 36, 50, 509, DateTimeKind.Utc), 342953L, new DateTime(2014, 12, 22, 17, 35, 44, 452, DateTimeKind.Utc).AddTicks(5890), 0.0, 120000L, "Imperial Department of Military Research, Sienar Fleet Systems", 0, "DS-1 Orbital Battle Station", "Death Star", 843342, "Deep Space Mobile Battlestation" },
                    { 4, 100000L, "2 months", 100000L, new DateTime(2014, 12, 10, 16, 59, 45, 94, DateTimeKind.Utc), 4L, new DateTime(2014, 12, 22, 17, 35, 44, 464, DateTimeKind.Utc).AddTicks(1560), 0.0, 0L, "Corellian Engineering Corporation", 1050, "YT-1300 light freighter", "Millennium Falcon", 6, "Light freighter" },
                    { 5, 110L, "1 week", 134999L, new DateTime(2014, 12, 12, 11, 0, 39, 817, DateTimeKind.Utc), 2L, new DateTime(2014, 12, 22, 17, 35, 44, 479, DateTimeKind.Utc).AddTicks(7060), 0.0, 14L, "Koensayr Manufacturing", 0, "BTL Y-wing", "Y-wing", 0, "assault starfighter" },
                    { 6, 110L, "1 week", 149999L, new DateTime(2014, 12, 12, 11, 19, 5, 340, DateTimeKind.Utc), 1L, new DateTime(2014, 12, 22, 17, 35, 44, 491, DateTimeKind.Utc).AddTicks(2330), 0.0, 0L, "Incom Corporation", 1050, "T-65 X-wing", "X-wing", 0, "Starfighter" },
                    { 7, 150L, "5 days", 0L, new DateTime(2014, 12, 12, 11, 21, 32, 991, DateTimeKind.Utc), 1L, new DateTime(2014, 12, 22, 17, 35, 44, 549, DateTimeKind.Utc).AddTicks(470), 0.0, 0L, "Sienar Fleet Systems", 1200, "Twin Ion Engine Advanced x1", "TIE Advanced x1", 0, "Starfighter" },
                    { 8, 70000L, "1 month", 0L, new DateTime(2014, 12, 15, 13, 0, 56, 332, DateTimeKind.Utc), 1L, new DateTime(2014, 12, 22, 17, 35, 44, 716, DateTimeKind.Utc).AddTicks(2730), 0.0, 0L, "Kuat Systems Engineering", 1000, "Firespray-31-class patrol and attack", "Slave 1", 6, "Patrol craft" },
                    { 9, 80000L, "2 months", 240000L, new DateTime(2014, 12, 15, 13, 4, 47, 235, DateTimeKind.Utc), 6L, new DateTime(2014, 12, 22, 17, 35, 44, 795, DateTimeKind.Utc).AddTicks(4050), 0.0, 20L, "Sienar Fleet Systems", 850, "Lambda-class T-4a shuttle", "Imperial shuttle", 20, "Armed government transport" },
                    { 10, 6000000L, "2 years", 8500000L, new DateTime(2014, 12, 15, 13, 6, 30, 813, DateTimeKind.Utc), 854L, new DateTime(2014, 12, 22, 17, 35, 44, 848, DateTimeKind.Utc).AddTicks(3290), 0.0, 300L, "Kuat Drive Yards", 800, "EF76 Nebulon-B escort frigate", "EF76 Nebulon-B escort frigate", 75, "Escort ship" },
                    { 11, 0L, "2 years", 104000000L, new DateTime(2014, 12, 18, 10, 54, 57, 804, DateTimeKind.Utc), 5400L, new DateTime(2014, 12, 22, 17, 35, 44, 957, DateTimeKind.Utc).AddTicks(8520), 0.0, 1200L, "Mon Calamari shipyards", 0, "MC80 Liberty type Star Cruiser", "Calamari Cruiser", 1200, "Star Cruiser" },
                    { 12, 40L, "1 week", 175000L, new DateTime(2014, 12, 18, 11, 16, 34, 542, DateTimeKind.Utc), 1L, new DateTime(2014, 12, 22, 17, 35, 44, 978, DateTimeKind.Utc).AddTicks(7540), 0.0, 0L, "Alliance Underground Engineering, Incom Corporation", 1300, "RZ-1 A-wing Interceptor", "A-wing", 0, "Starfighter" },
                    { 13, 45L, "1 week", 220000L, new DateTime(2014, 12, 18, 11, 18, 4, 763, DateTimeKind.Utc), 1L, new DateTime(2014, 12, 22, 17, 35, 45, 11, DateTimeKind.Utc).AddTicks(1930), 0.0, 0L, "Slayn & Korpil", 950, "A/SF-01 B-wing starfighter", "B-wing", 0, "Assault Starfighter" },
                    { 14, 0L, "unknown", 0L, new DateTime(2014, 12, 19, 17, 1, 31, 488, DateTimeKind.Utc), 9L, new DateTime(2014, 12, 22, 17, 35, 45, 27, DateTimeKind.Utc).AddTicks(3080), 0.0, 115L, "Corellian Engineering Corporation", 900, "Consular-class cruiser", "Republic Cruiser", 16, "Space cruiser" },
                    { 15, 65L, "7 days", 200000L, new DateTime(2014, 12, 19, 17, 39, 17, 582, DateTimeKind.Utc), 1L, new DateTime(2014, 12, 22, 17, 35, 45, 79, DateTimeKind.Utc).AddTicks(4520), 0.0, 11L, "Theed Palace Space Vessel Engineering Corps", 1100, "N-1 starfighter", "Naboo fighter", 0, "Starfighter" },
                    { 16, 0L, "unknown", 0L, new DateTime(2014, 12, 19, 17, 45, 3, 506, DateTimeKind.Utc), 8L, new DateTime(2014, 12, 22, 17, 35, 45, 91, DateTimeKind.Utc).AddTicks(9250), 0.0, 76L, "Theed Palace Space Vessel Engineering Corps, Nubia Star Drives", 920, "J-type 327 Nubian royal starship", "Naboo Royal Starship", 0, "yacht" },
                    { 18, 0L, "1 year", 2000000L, new DateTime(2014, 12, 20, 11, 5, 51, 237, DateTimeKind.Utc), 5L, new DateTime(2014, 12, 22, 17, 35, 45, 124, DateTimeKind.Utc).AddTicks(3860), 0.0, 39L, "Theed Palace Space Vessel Engineering Corps, Nubia Star Drives", 2000, "J-type diplomatic barge", "J-type diplomatic barge", 10, "Diplomatic barge" },
                    { 37, 40000000L, "2 years", 57000000L, new DateTime(2014, 12, 20, 20, 7, 11, 538, DateTimeKind.Utc), 200L, new DateTime(2017, 4, 19, 10, 53, 32, 700, DateTimeKind.Utc).AddTicks(2830), 0.0, 825L, "Hoersch-Kessel Drive, Inc, Gwori Revolutionary Industries", 0, "Munificent-class star frigate", "Banking clan frigate", 0, "cruiser" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StarShips");
        }
    }
}
