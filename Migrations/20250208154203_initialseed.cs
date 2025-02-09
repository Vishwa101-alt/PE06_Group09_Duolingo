using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSDProject.Migrations
{
    /// <inheritdoc />
    public partial class initialseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseDatabase",
                columns: table => new
                {
                    CourseDatabaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDatabase", x => x.CourseDatabaseId);
                });

            migrationBuilder.CreateTable(
                name: "RewardShop",
                columns: table => new
                {
                    RewardShopId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RewardType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PointCost = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RewardShop", x => x.RewardShopId);
                });

            migrationBuilder.CreateTable(
                name: "StoreItem",
                columns: table => new
                {
                    StoreItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Questions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MultipleChoice1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MultipleChoice2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MultipleChoice3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MultipleChoice4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<int>(type: "int", nullable: true),
                    CourseDatabaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreItem", x => x.StoreItemId);
                    table.ForeignKey(
                        name: "FK_StoreItem_CourseDatabase_CourseDatabaseId",
                        column: x => x.CourseDatabaseId,
                        principalTable: "CourseDatabase",
                        principalColumn: "CourseDatabaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoursePrice = table.Column<float>(type: "real", nullable: true),
                    CourseDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompletionPercentage = table.Column<int>(type: "int", nullable: true),
                    UserAccId = table.Column<int>(type: "int", nullable: true),
                    CourseDatabaseId = table.Column<int>(type: "int", nullable: false),
                    ScoreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Course_CourseDatabase_CourseDatabaseId",
                        column: x => x.CourseDatabaseId,
                        principalTable: "CourseDatabase",
                        principalColumn: "CourseDatabaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    UserProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentPoints = table.Column<int>(type: "int", nullable: true),
                    RewardId = table.Column<int>(type: "int", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.UserProfileId);
                    table.ForeignKey(
                        name: "FK_UserProfile_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserProfile_RewardShop_RewardId",
                        column: x => x.RewardId,
                        principalTable: "RewardShop",
                        principalColumn: "RewardShopId");
                });

            migrationBuilder.CreateTable(
                name: "Score",
                columns: table => new
                {
                    ScoreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PointsAwarded = table.Column<int>(type: "int", nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    StoreItemId = table.Column<int>(type: "int", nullable: true),
                    UserProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.ScoreId);
                    table.ForeignKey(
                        name: "FK_Score_StoreItem_StoreItemId",
                        column: x => x.StoreItemId,
                        principalTable: "StoreItem",
                        principalColumn: "StoreItemId");
                    table.ForeignKey(
                        name: "FK_Score_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfile",
                        principalColumn: "UserProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAcc",
                columns: table => new
                {
                    UserAccId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserProfileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAcc", x => x.UserAccId);
                    table.ForeignKey(
                        name: "FK_UserAcc_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfile",
                        principalColumn: "UserProfileId");
                });

            migrationBuilder.InsertData(
                table: "CourseDatabase",
                columns: new[] { "CourseDatabaseId", "LanguageName" },
                values: new object[,]
                {
                    { 1, "English" },
                    { 2, "Burmese" },
                    { 3, "Malay" },
                    { 4, "Hindi" }
                });

            migrationBuilder.InsertData(
                table: "RewardShop",
                columns: new[] { "RewardShopId", "PointCost", "RewardType" },
                values: new object[,]
                {
                    { 1, "500 points", "Monitor" },
                    { 2, "450 points", "Microphone" },
                    { 3, "1000 points", "Laptop" },
                    { 4, "300 points", "PowerBank" },
                    { 5, "600 points", "AppleWatch" }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CompletionPercentage", "CourseDatabaseId", "CourseDuration", "CourseName", "CoursePrice", "ScoreId", "UserAccId" },
                values: new object[,]
                {
                    { 1, 0, 1, "60 minutes", "English language course", 10.5f, null, null },
                    { 2, 0, 2, "90 minutes", "Burmese language course", 15f, null, null },
                    { 3, 0, 3, "50 minutes", "Malay language course", 8f, null, null },
                    { 4, 0, 4, "75 minutes", "Hindi language course", 12f, null, null }
                });

            migrationBuilder.InsertData(
                table: "StoreItem",
                columns: new[] { "StoreItemId", "Answer", "CourseDatabaseId", "MultipleChoice1", "MultipleChoice2", "MultipleChoice3", "MultipleChoice4", "Questions" },
                values: new object[,]
                {
                    { 1, 3, 4, "1. Kaise ho", "2. Kaise hai", "3. Aap kaise hai", "4. Tum kaise ho", "How do you say 'How are you' in Hindi?" },
                    { 2, 1, 4, "1. Which subject are you interested in?", "2. Do you work?", "3. What do you do for work?", "4. Where do you study?", "What does this sentence 'tum kis vishay mein ruchi rakhate ho? ' mean?" },
                    { 3, 2, 4, "1. namaste maata-pita jee", "2. suprabhaat, maan-paapa", "3. kaise ho, maata-pita jee?", "4. namaskaar, maata-pita!", "What should you say infront of your parents when you greet them in a informal tone" },
                    { 4, 1, 4, "1. True", "2. False", "3. I don't know", "4. Both", "'yah jagah kahaan hai?' means 'Where is this place?'. Is this true or false?" },
                    { 5, 3, 4, "1. How old are you?", "2. Where are you from?", "3. What is your name?", "4. What do you do?", "What does 'aapaka naam kya hai?' mean in English?" },
                    { 6, 1, 4, "1. main achchha hoon", "2. tum achchhe ho", "3. ham achchhe hain", "4. vah achchha hai", "Which sentence means 'I am fine'?" },
                    { 7, 2, 4, "1. kalam", "2. pustak ", "3. zameen", "4. desk", "What is the Hindi word for 'book'?" },
                    { 8, 1, 4, "1. suprabhaat", "2. shubh raatri", "3. namaste", "4. dhanyavaad", "How do you say 'Good Night' in Hindi?" },
                    { 9, 1, 1, "1. Run", "2. Quickly", "3. Beautiful", "4. Happiness", "Which word is a verb?" },
                    { 10, 4, 1, "1. He", "2. Runs", "3. Very", "4. Fast", "Identify the adverb in this sentence: 'He runs very fast.'" },
                    { 11, 3, 1, "1. Goes", "2. Gone", "3. Went", "4. Going", "What is the past tense of 'go'?" },
                    { 12, 2, 1, "1. Your going to the park", "2. Your book is on the table", "3. She asked your to help", "4. Their book is here", "Which sentence uses 'your' correctly?" },
                    { 13, 3, 1, "1. Run ", "2. Beautiful ", "3.Happiness ", "4. Quickly ", "Which word is a noun?" },
                    { 14, 1, 1, "1. Red", "2. Jump", "3. Apple", "4. Slowly", "Which word is an adjective?" },
                    { 15, 3, 1, "1. She don’t like ice cream", "2. He go to the park every morning", "3. They are playing soccer in the field", "4. The cat drinked all the milk", "Which sentence is grammatically correct?" },
                    { 16, 4, 1, "1. Their going to the park later today", "2. The dog wagged their tail happily", "3. She asked their to help with the project", "4. The students finished their homework before class?", "Which sentence uses 'their' correctly?" },
                    { 17, 2, 3, "1. What is your name?", "2. How are you?", "3. Goodbye", "4. Thank you", "What does 'Apa khabar' mean in English?" },
                    { 18, 2, 3, "1. Rumah", "2. Sekolah", "3. Jalan", "4. Buku", "Which Malay word means 'School'?" },
                    { 19, 2, 3, "1. I am tired", "2. I am hungry", "3. I am happy", "4. I am sad", "Translate 'Saya lapar' into English." },
                    { 20, 3, 3, "1. Selamat pagi", "2. Selamat malam", "3. Selamat petang", "4. Selamat siang", "How do you say 'Good evening' in Malay?" },
                    { 21, 2, 3, "1. Goodbye", "2. Safe", "3. Fast", "4. Bright", "What does the Malay word 'Selamat' mean?" },
                    { 22, 4, 3, "1. Selamat pagi", "2. Apa khaba", "3. Sama-sama", "4. Terima kasih", "What is the Malay word for 'Thank you'?" },
                    { 23, 4, 3, "1. Apa khabar, kawan?", "2. Saya nak pergi rumah awak", "3. Eh, tolong bagi saya itu", "4. Bolehkah saya bantu anda?", "Which malay sentence is correct when speaking to elders?" },
                    { 24, 1, 3, "1. True", "2. False", "3. I dont know ", "4. Both", "Does this sentence 'Saya suka makan nasi lemak di waktu pag' mean ' I like to eat nasi lemak in the morning'?" },
                    { 25, 1, 2, "1. Brother", "2. Sister", "3. Uncle", "4. Aunt", "What does 'maung' mean in English?" },
                    { 26, 3, 2, "1. Welcome", "2. Goodbye", "3. Thank you", "4. Excuse me", "Translate kyaayyjuutainpartaa' into English." },
                    { 27, 2, 2, "1. nayaain", "2. kyaungg", "3. hcarr", "4. ray", "What is the Burmese word for 'School'?" },
                    { 28, 4, 2, "1. hotekae", "2. larpar", "3. maingalarpar", "4. swarrtotmaal", "How do you say 'Goodbye' in Burmese?" },
                    { 29, 1, 2, "1. Yay", "2. Mee", "3. Myay", "4. Lay", "What is the Burmese word for 'water'?" },
                    { 30, 2, 2, "1.Goodbye", "2. Hello", "3. Thank you", "4. Please", "What does 'maingalarpar' mean?" },
                    { 31, 4, 2, "1. Kyisu", "2. Thwa", "3. Lhpa", "4. Kyaung", "Which word is a Burmese noun?" },
                    { 32, 3, 2, "1. paann", "2. paannsee myarr", "3. paannsee", "4. see myarr", "Which of the folowing is correct for Apple in Burmese?" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_CourseDatabaseId",
                table: "Course",
                column: "CourseDatabaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_ScoreId",
                table: "Course",
                column: "ScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_UserAccId",
                table: "Course",
                column: "UserAccId");

            migrationBuilder.CreateIndex(
                name: "IX_Score_StoreItemId",
                table: "Score",
                column: "StoreItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Score_UserProfileId",
                table: "Score",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreItem_CourseDatabaseId",
                table: "StoreItem",
                column: "CourseDatabaseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAcc_UserProfileId",
                table: "UserAcc",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_CourseId",
                table: "UserProfile",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_RewardId",
                table: "UserProfile",
                column: "RewardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Score_ScoreId",
                table: "Course",
                column: "ScoreId",
                principalTable: "Score",
                principalColumn: "ScoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_UserAcc_UserAccId",
                table: "Course",
                column: "UserAccId",
                principalTable: "UserAcc",
                principalColumn: "UserAccId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_CourseDatabase_CourseDatabaseId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreItem_CourseDatabase_CourseDatabaseId",
                table: "StoreItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Score_ScoreId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_UserAcc_UserAccId",
                table: "Course");

            migrationBuilder.DropTable(
                name: "CourseDatabase");

            migrationBuilder.DropTable(
                name: "Score");

            migrationBuilder.DropTable(
                name: "StoreItem");

            migrationBuilder.DropTable(
                name: "UserAcc");

            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "RewardShop");
        }
    }
}
