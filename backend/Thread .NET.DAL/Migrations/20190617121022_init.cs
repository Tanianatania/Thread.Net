using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    URL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    AvatarId = table.Column<int>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Salt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Images_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    PreviewId = table.Column<int>(nullable: true),
                    Body = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Images_PreviewId",
                        column: x => x.PreviewId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Token = table.Column<string>(nullable: true),
                    Expires = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false),
                    Body = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DisPostReactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    IsDisLike = table.Column<bool>(nullable: false),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisPostReactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DisPostReactions_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DisPostReactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostReactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    IsLike = table.Column<bool>(nullable: false),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostReactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostReactions_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostReactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentReactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    IsLike = table.Column<bool>(nullable: false),
                    CommentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentReactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentReactions_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentReactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedAt", "URL", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 6, 17, 15, 10, 21, 698, DateTimeKind.Local).AddTicks(1920), "https://s3.amazonaws.com/uifaces/faces/twitter/svenlen/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(1808) },
                    { 23, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6689), "https://picsum.photos/640/480/?image=149", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6693) },
                    { 24, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6720), "https://picsum.photos/640/480/?image=39", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6724) },
                    { 25, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6751), "https://picsum.photos/640/480/?image=475", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6755) },
                    { 26, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6782), "https://picsum.photos/640/480/?image=1033", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6786) },
                    { 27, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6813), "https://picsum.photos/640/480/?image=660", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6817) },
                    { 28, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6840), "https://picsum.photos/640/480/?image=942", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6849) },
                    { 29, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6871), "https://picsum.photos/640/480/?image=155", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6875) },
                    { 30, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6902), "https://picsum.photos/640/480/?image=521", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6906) },
                    { 31, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6933), "https://picsum.photos/640/480/?image=658", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6991) },
                    { 32, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7017), "https://picsum.photos/640/480/?image=838", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7022) },
                    { 33, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7049), "https://picsum.photos/640/480/?image=704", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7053) },
                    { 34, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7075), "https://picsum.photos/640/480/?image=693", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7084) },
                    { 35, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7106), "https://picsum.photos/640/480/?image=351", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7111) },
                    { 36, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7137), "https://picsum.photos/640/480/?image=914", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7142) },
                    { 37, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7169), "https://picsum.photos/640/480/?image=919", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7173) },
                    { 38, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7195), "https://picsum.photos/640/480/?image=985", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7200) },
                    { 39, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7226), "https://picsum.photos/640/480/?image=1014", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7231) },
                    { 22, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6644), "https://picsum.photos/640/480/?image=656", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6657) },
                    { 40, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7294), "https://picsum.photos/640/480/?image=590", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7298) },
                    { 21, new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(5266), "https://picsum.photos/640/480/?image=682", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6333) },
                    { 19, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3813), "https://s3.amazonaws.com/uifaces/faces/twitter/mattsapii/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3822) },
                    { 2, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3204), "https://s3.amazonaws.com/uifaces/faces/twitter/mtolokonnikov/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3222) },
                    { 3, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3262), "https://s3.amazonaws.com/uifaces/faces/twitter/ivanfilipovbg/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3271) },
                    { 4, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3293), "https://s3.amazonaws.com/uifaces/faces/twitter/chadengle/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3302) },
                    { 5, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3324), "https://s3.amazonaws.com/uifaces/faces/twitter/petrangr/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3328) },
                    { 6, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3355), "https://s3.amazonaws.com/uifaces/faces/twitter/cadikkara/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3360) },
                    { 7, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3382), "https://s3.amazonaws.com/uifaces/faces/twitter/doronmalki/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3391) },
                    { 8, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3413), "https://s3.amazonaws.com/uifaces/faces/twitter/nellleo/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3417) },
                    { 9, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3444), "https://s3.amazonaws.com/uifaces/faces/twitter/jennyyo/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3448) },
                    { 10, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3471), "https://s3.amazonaws.com/uifaces/faces/twitter/Chakintosh/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3475) },
                    { 11, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3497), "https://s3.amazonaws.com/uifaces/faces/twitter/brandonflatsoda/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3506) },
                    { 12, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3528), "https://s3.amazonaws.com/uifaces/faces/twitter/rez___a/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3533) },
                    { 13, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3555), "https://s3.amazonaws.com/uifaces/faces/twitter/thedamianhdez/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3564) },
                    { 14, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3586), "https://s3.amazonaws.com/uifaces/faces/twitter/reabo101/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3591) },
                    { 15, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3613), "https://s3.amazonaws.com/uifaces/faces/twitter/ostirbu/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3617) },
                    { 16, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3640), "https://s3.amazonaws.com/uifaces/faces/twitter/kalmerrautam/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3648) },
                    { 17, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3671), "https://s3.amazonaws.com/uifaces/faces/twitter/slowspock/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3675) },
                    { 18, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3786), "https://s3.amazonaws.com/uifaces/faces/twitter/flashmurphy/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3791) },
                    { 20, new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3844), "https://s3.amazonaws.com/uifaces/faces/twitter/darcystonge/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3848) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 21, null, new DateTime(2019, 6, 17, 15, 10, 21, 952, DateTimeKind.Local).AddTicks(9308), "test@gmail.com", "tlsRD84IM9CUB+apKtjuui7neJwZKiVypKAKdWMgrZQ=", "kodLmlV4z1U/aXmRRuqY20LbaapJt1QJ4zlEOwAB2To=", new DateTime(2019, 6, 17, 15, 10, 21, 952, DateTimeKind.Local).AddTicks(9308), "testUser" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[,]
                {
                    { 8, 21, "eius", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(6695), 24, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(6699) },
                    { 2, 21, "iure", new DateTime(2019, 6, 17, 15, 10, 21, 964, DateTimeKind.Local).AddTicks(5433), 23, new DateTime(2019, 6, 17, 15, 10, 21, 964, DateTimeKind.Local).AddTicks(5446) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { 18, 19, new DateTime(2019, 6, 17, 15, 10, 21, 922, DateTimeKind.Local).AddTicks(6760), "Pedro_Lemke@gmail.com", "FpN0XtFLvSjgFcZAsiJ7TMzP7XgPQXeoII2L06a8VaM=", "uchRnlu4H39IT+ud5ivreGvZms8qoU1k8micz4fKj+Y=", new DateTime(2019, 6, 17, 15, 10, 21, 922, DateTimeKind.Local).AddTicks(6778), "Rosalind.Kuhic" },
                    { 17, 18, new DateTime(2019, 6, 17, 15, 10, 21, 912, DateTimeKind.Local).AddTicks(5249), "Dario_Heller@gmail.com", "UqTfWqmp39hu368vFsFiQB54JD6tZyrdPUPJBFl3vSA=", "ZHtBzKkLeE6gGTWd4wlsXGFERK4aO1IdLIx0z2JHFb4=", new DateTime(2019, 6, 17, 15, 10, 21, 912, DateTimeKind.Local).AddTicks(5276), "Renee.Feeney" },
                    { 9, 17, new DateTime(2019, 6, 17, 15, 10, 21, 826, DateTimeKind.Local).AddTicks(8032), "Amani11@hotmail.com", "iUyW1f4xkAsJ5jMU6PzEOrf/uLKVUp7VGOXuaxW+7Fc=", "PVI+RfI8midbnnXBZNNxy2HJ4hk4hMXKz0bxIsTS9NM=", new DateTime(2019, 6, 17, 15, 10, 21, 826, DateTimeKind.Local).AddTicks(8054), "Krista51" },
                    { 4, 17, new DateTime(2019, 6, 17, 15, 10, 21, 776, DateTimeKind.Local).AddTicks(409), "Juston.Zemlak20@gmail.com", "R3wu0pzwXy0dFcLMVB1CGMNdFrG+Y/LkBwl2j22BHLM=", "GQPkn0mLYyGYAds6gHCNz9LZ8rFPb+05FwgKLKgUAas=", new DateTime(2019, 6, 17, 15, 10, 21, 776, DateTimeKind.Local).AddTicks(436), "Susan36" },
                    { 15, 15, new DateTime(2019, 6, 17, 15, 10, 21, 890, DateTimeKind.Local).AddTicks(1169), "Arnold.Doyle55@yahoo.com", "5igdHvSGa72JFdKswPTs71tLc0CzKH93K9ThimyJXDY=", "uc2n+dpMJAG99I6x3BYmWOmFvc9sn2P0A7cyrc/ejcs=", new DateTime(2019, 6, 17, 15, 10, 21, 890, DateTimeKind.Local).AddTicks(1209), "Carolanne.Beahan6" },
                    { 11, 14, new DateTime(2019, 6, 17, 15, 10, 21, 847, DateTimeKind.Local).AddTicks(2760), "Evan_White9@yahoo.com", "yB50TKS8p85ZrdGkB+SaWfA1/rxaP5FDOPiDFhF4ezM=", "yV8Td3HKfvxGmuBs8zRf5IqBjSBgRbXwya5rldqI4Wg=", new DateTime(2019, 6, 17, 15, 10, 21, 847, DateTimeKind.Local).AddTicks(2778), "Jamel_Veum41" },
                    { 6, 13, new DateTime(2019, 6, 17, 15, 10, 21, 796, DateTimeKind.Local).AddTicks(4254), "Jensen_Sanford96@gmail.com", "LgNcGg/V4J6hvwb8Ltx/tU8f0F5PDnif3AUhKdMqFFM=", "TCqD7fc3Bv+DlLiBM20rhy/OSnwvJDrJy7EjCqN80tA=", new DateTime(2019, 6, 17, 15, 10, 21, 796, DateTimeKind.Local).AddTicks(4285), "Angie36" },
                    { 14, 11, new DateTime(2019, 6, 17, 15, 10, 21, 879, DateTimeKind.Local).AddTicks(4743), "Arch_Moen15@gmail.com", "QyGZ0YccVoqlinVc/fUFN0IopNudmF/oISidbigCVeQ=", "5Jy4dbdZDiZw7kf1AUAHwwErYb89NLXfhO05/gtD1qk=", new DateTime(2019, 6, 17, 15, 10, 21, 879, DateTimeKind.Local).AddTicks(4779), "Abraham_Sauer" },
                    { 13, 10, new DateTime(2019, 6, 17, 15, 10, 21, 867, DateTimeKind.Local).AddTicks(5392), "Retha_Considine53@gmail.com", "lQH3Y1kUjuA6eMoHDvkkXAG2xcIg5sJ3I2eNAZNfwgw=", "eR9E6MEZ5ZDXyyeH78IAcDag+Kpj/jlrzZFb0EcfsMk=", new DateTime(2019, 6, 17, 15, 10, 21, 867, DateTimeKind.Local).AddTicks(5414), "Jolie_Howell" },
                    { 5, 10, new DateTime(2019, 6, 17, 15, 10, 21, 786, DateTimeKind.Local).AddTicks(1703), "Hector.Hermiston@hotmail.com", "JGklaZOVjagqDn3/8aAn5KdVlYkOim6pGGQptgkEVvY=", "VHibLUE+le3bw2v6NPckVJMWvjD7fTkViYsIZ0y7wS4=", new DateTime(2019, 6, 17, 15, 10, 21, 786, DateTimeKind.Local).AddTicks(1721), "Cali.Hand50" },
                    { 19, 9, new DateTime(2019, 6, 17, 15, 10, 21, 932, DateTimeKind.Local).AddTicks(7321), "Alexane.Kemmer@gmail.com", "RmdIsnq0Oq/AzJzogMgyE73ERhHNkqaH86YyCpf2rWY=", "QEnukf3U/7iXCuu7aK89EnP+w3Mrw18+ufRisRto59E=", new DateTime(2019, 6, 17, 15, 10, 21, 932, DateTimeKind.Local).AddTicks(7347), "Eulah.Dietrich95" },
                    { 12, 9, new DateTime(2019, 6, 17, 15, 10, 21, 857, DateTimeKind.Local).AddTicks(4574), "Camylle.Haley@gmail.com", "VBIUAtuCDlj741s9M3ABzLlZgKTqAOGy/cc5ES4a/+0=", "8UfLrcGYv9pb6c5hldd+q5FIpzG9dqSccWZVqbcJvaA=", new DateTime(2019, 6, 17, 15, 10, 21, 857, DateTimeKind.Local).AddTicks(4591), "Devante_Simonis" },
                    { 8, 7, new DateTime(2019, 6, 17, 15, 10, 21, 816, DateTimeKind.Local).AddTicks(4796), "Virgie.Willms32@yahoo.com", "YAYoVRyjSydOu6U81mnLz16HvQl6jtwOzAJQFGH0lT0=", "tnFpn8s9Bbb5Pz/FVVh/kQqzT/yFDEFhIVK6aItImyo=", new DateTime(2019, 6, 17, 15, 10, 21, 816, DateTimeKind.Local).AddTicks(4805), "Madeline_Shanahan" },
                    { 16, 6, new DateTime(2019, 6, 17, 15, 10, 21, 901, DateTimeKind.Local).AddTicks(7179), "Shaun.Koch76@yahoo.com", "cjPAfzDaL7/MlWHUkQ7faaeM3knTA5RuS2QJP8QA7TQ=", "EvA2+vLG0S7nnrEdBBTJo+2r1B/7CbqgEpF0rMLhNXY=", new DateTime(2019, 6, 17, 15, 10, 21, 901, DateTimeKind.Local).AddTicks(7223), "Jovan73" },
                    { 10, 6, new DateTime(2019, 6, 17, 15, 10, 21, 837, DateTimeKind.Local).AddTicks(2290), "Gina5@yahoo.com", "NNtAKDXwmaPZZc3fYF2y0KLiCvdcRlhCQV8QEoP57wI=", "Hsihg0gNfmPdVXQP9b6hQdQvwD7p96wgn+JOpBky2dg=", new DateTime(2019, 6, 17, 15, 10, 21, 837, DateTimeKind.Local).AddTicks(2316), "Emma_Hegmann60" },
                    { 1, 4, new DateTime(2019, 6, 17, 15, 10, 21, 745, DateTimeKind.Local).AddTicks(4262), "Stephania_Reynolds@hotmail.com", "DV3RfSAIWZiOnWWimckn0YDdPWi0hk3rPOmz0/rZlkY=", "lCCcNyCxQnA2eHfF9Wr11LlYjN1syVIiYQN5kpYdOBQ=", new DateTime(2019, 6, 17, 15, 10, 21, 745, DateTimeKind.Local).AddTicks(5347), "Jaycee_Abbott" },
                    { 20, 2, new DateTime(2019, 6, 17, 15, 10, 21, 942, DateTimeKind.Local).AddTicks(9236), "Barney_Zemlak52@gmail.com", "jfYuDlFjocB77RLG9ShExVNTPZaSLu5pm2poyR9vBEM=", "W94Ok0Y2lPfRmaRbkSChj5Mhcw3gZLBrMj7D3Xz+BbQ=", new DateTime(2019, 6, 17, 15, 10, 21, 942, DateTimeKind.Local).AddTicks(9263), "Rocky43" },
                    { 7, 1, new DateTime(2019, 6, 17, 15, 10, 21, 806, DateTimeKind.Local).AddTicks(4684), "Marcus83@yahoo.com", "T03/VIGWAiOBrd1lW3CSXpX4BclAiK+ChxIHaq1ua8Q=", "P3onZ3mHOmkD4hYK87Ekw/4tkt0qXfionB7/Yj9OKhA=", new DateTime(2019, 6, 17, 15, 10, 21, 806, DateTimeKind.Local).AddTicks(4702), "Diamond_Heller" },
                    { 3, 10, new DateTime(2019, 6, 17, 15, 10, 21, 765, DateTimeKind.Local).AddTicks(9658), "Perry78@hotmail.com", "+TjsBFKpsEirTppkTgHA4NRxnuEOni8QMEG36HOwo3k=", "5/vjS6PWR5Pqv8S29pxhmnWgK6vB4A9IyAMhZ71IQmg=", new DateTime(2019, 6, 17, 15, 10, 21, 765, DateTimeKind.Local).AddTicks(9680), "Daniela.Jenkins7" },
                    { 2, 1, new DateTime(2019, 6, 17, 15, 10, 21, 755, DateTimeKind.Local).AddTicks(8920), "Amber13@yahoo.com", "2QTlWpPfHc6utxTPWBoqV6GyF27x2RFjFkbzlrnP0u8=", "s4NxsxdikJXnzHhEifXyI6Z6b5TRn8L+lwSmrdI/O8w=", new DateTime(2019, 6, 17, 15, 10, 21, 755, DateTimeKind.Local).AddTicks(8943), "Toby_Hayes" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[,]
                {
                    { 18, 11, "Illum quibusdam aut qui architecto ut.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1241), 8, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1246) },
                    { 9, 1, "Occaecati iste magni et quibusdam aut molestiae.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(557), 8, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(561) },
                    { 16, 12, "Non non velit reiciendis.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1113), 2, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1117) },
                    { 6, 17, "Sed quaerat id ex voluptate sit laudantium ipsa minus non.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(250), 2, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(255) }
                });

            migrationBuilder.InsertData(
                table: "DisPostReactions",
                columns: new[] { "Id", "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { 13, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(579), true, 8, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(588), 1 });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5402), true, 8, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5411), 15 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[,]
                {
                    { 18, 9, "Repellat hic quia maxime rerum et.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8170), 25, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8179) },
                    { 10, 9, @"Dolorem ut deleniti aut.
                Cumque perferendis ipsa ut laudantium.
                Labore occaecati commodi sunt.
                Veritatis et tenetur et non id eius iure.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7152), 33, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7157) },
                    { 15, 15, @"Dolorem eligendi nam impedit inventore sint nihil.
                Quibusdam suscipit cum iure hic eius.
                Maxime est rerum vel quidem et nihil quo.
                Modi maiores magni quia sit impedit perferendis hic cum id.
                Minima sit vero eos natus.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7810), 25, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7819) },
                    { 6, 15, "Voluptates eaque occaecati rerum eligendi totam id veritatis aut.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(6455), 27, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(6472) },
                    { 19, 11, "Temporibus quia maiores atque est.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8237), 22, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8241) },
                    { 3, 11, "Voluptas aut consequatur nulla itaque beatae aut voluptatum qui sint. Quis iusto et magnam laudantium ut vel consectetur enim. Perferendis voluptatum et veniam odit omnis voluptatem sit.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(1735), 40, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(1779) },
                    { 1, 11, "mollitia", new DateTime(2019, 6, 17, 15, 10, 21, 964, DateTimeKind.Local).AddTicks(3424), 21, new DateTime(2019, 6, 17, 15, 10, 21, 964, DateTimeKind.Local).AddTicks(4415) },
                    { 4, 13, @"Consequatur et sint.
                Quo fugiat tempore et expedita dolores suscipit.
                Qui perferendis doloribus et dolores.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(3708), 32, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(3726) },
                    { 11, 5, "Blanditiis ullam non voluptatem unde vero et.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7232), 21, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7237) },
                    { 17, 19, "Fugiat omnis qui ea amet necessitatibus laudantium eligendi.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8104), 24, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8112) },
                    { 16, 19, "Ipsa aspernatur debitis dolor. Possimus consequatur sed aperiam. Sed at est atque architecto eum magnam velit. Quia est quo.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8024), 25, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8032) },
                    { 9, 12, "Nemo maiores tenetur accusantium ullam excepturi sit. Dignissimos et reiciendis consequatur minima repellendus. Tenetur cumque at. Sit sunt ut sit quos rerum inventore doloribus. Ullam nihil id deleniti at voluptatum in voluptatem minus. Quia sed non aut vel.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(6988), 35, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(6997) },
                    { 14, 10, "Explicabo praesentium recusandae.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7477), 29, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7481) },
                    { 5, 1, "Sit dolor natus eum cupiditate. Nostrum voluptatem quam eius voluptates sit quos ducimus unde nisi. Ea rerum eaque ea nisi exercitationem aut cupiditate.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(4046), 31, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(4050) },
                    { 13, 20, "laborum", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7415), 35, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7419) },
                    { 7, 20, "Quo fugit in aliquam occaecati ut autem.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(6646), 36, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(6650) },
                    { 12, 14, @"Laudantium sed ut enim.
                Ut soluta error et.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7366), 22, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7375) },
                    { 20, 7, "Alias eum blanditiis molestiae doloremque eum harum atque incidunt reprehenderit.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8321), 21, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8330) }
                });

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 11, 9, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1926), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1939), 11 },
                    { 15, 16, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2192), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2201), 20 },
                    { 20, 6, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2521), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2530), 14 },
                    { 5, 9, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1530), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1539), 7 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[,]
                {
                    { 8, 6, "Sit reprehenderit eum est nostrum quam culpa voluptatum quidem mollitia.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(419), 18, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(424) },
                    { 2, 10, "Ratione est reiciendis.", new DateTime(2019, 6, 17, 15, 10, 21, 977, DateTimeKind.Local).AddTicks(9788), 10, new DateTime(2019, 6, 17, 15, 10, 21, 977, DateTimeKind.Local).AddTicks(9801) },
                    { 4, 1, "Commodi aut qui asperiores.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(104), 6, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(113) },
                    { 15, 11, "Sed quia voluptas excepturi quia eaque.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1055), 19, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1059) },
                    { 12, 16, "Repudiandae maiores et eos natus vel doloribus ut omnis.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(793), 19, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(797) },
                    { 3, 12, "Est quam cumque neque velit quia at consequatur magnam aut.", new DateTime(2019, 6, 17, 15, 10, 21, 977, DateTimeKind.Local).AddTicks(9925), 1, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(5) },
                    { 5, 6, "Id ipsa magni.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(166), 12, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(170) },
                    { 13, 3, "Est a ducimus consequatur autem fugit atque porro in.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(873), 4, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(877) },
                    { 10, 5, "Nihil nesciunt veniam fuga totam doloribus sint.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(633), 4, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(637) },
                    { 17, 1, "Cumque cum sint similique autem.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1170), 11, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1179) },
                    { 20, 5, "Quia nemo repellendus rem soluta.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1415), 12, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1424) },
                    { 11, 11, "Praesentium quo quasi distinctio consequuntur et commodi corrupti.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(708), 5, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(717) },
                    { 19, 6, "Quis consequatur est consequatur ducimus.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1299), 20, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1304) },
                    { 14, 19, "Nobis atque totam quas.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(988), 9, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(993) },
                    { 7, 12, "Eos ducimus dolor aut nulla distinctio sed rerum et veritatis.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(335), 14, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(344) },
                    { 1, 3, "Magni vero velit qui.", new DateTime(2019, 6, 17, 15, 10, 21, 977, DateTimeKind.Local).AddTicks(7712), 20, new DateTime(2019, 6, 17, 15, 10, 21, 977, DateTimeKind.Local).AddTicks(8690) }
                });

            migrationBuilder.InsertData(
                table: "DisPostReactions",
                columns: new[] { "Id", "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 16, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(784), false, 19, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(792), 18 },
                    { 5, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9504), true, 10, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9512), 14 },
                    { 20, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(1059), false, 6, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(1068), 12 },
                    { 14, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(646), true, 13, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(659), 3 },
                    { 18, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(917), true, 19, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(930), 1 },
                    { 7, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9668), false, 19, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9686), 11 },
                    { 4, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9450), false, 16, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9459), 6 },
                    { 3, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9388), false, 5, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9397), 9 },
                    { 19, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(988), true, 3, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(1001), 14 },
                    { 10, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9966), true, 13, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9975), 3 },
                    { 8, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9797), false, 5, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9815), 17 },
                    { 2, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9299), false, 12, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9312), 7 },
                    { 11, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(370), false, 5, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(392), 2 },
                    { 15, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(712), true, 5, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(726), 10 },
                    { 17, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(850), true, 14, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(859), 2 },
                    { 12, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(499), true, 7, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(508), 18 },
                    { 1, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(7170), false, 16, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(8259), 19 },
                    { 9, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9890), true, 11, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9904), 2 },
                    { 6, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9575), true, 12, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9588), 11 }
                });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 12, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5904), false, 18, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5913), 18 },
                    { 2, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5264), false, 18, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5291), 21 },
                    { 14, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6037), true, 18, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6046), 5 },
                    { 19, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6384), true, 18, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6393), 4 },
                    { 17, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6251), true, 7, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6277), 10 },
                    { 15, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6104), false, 15, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6113), 15 },
                    { 3, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5366), true, 14, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5371), 11 },
                    { 16, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6166), false, 6, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6175), 1 },
                    { 9, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5588), true, 6, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5597), 20 },
                    { 8, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5544), true, 6, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5553), 7 },
                    { 5, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5442), false, 17, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5446), 1 },
                    { 20, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6451), false, 1, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6464), 9 },
                    { 11, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5722), false, 12, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5731), 3 },
                    { 7, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5508), true, 4, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5517), 15 },
                    { 1, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(1673), false, 16, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(3033), 4 },
                    { 18, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6326), false, 11, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6335), 13 },
                    { 6, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5477), false, 11, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5482), 10 },
                    { 10, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5651), true, 15, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5664), 16 },
                    { 13, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5975), false, 9, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5984), 14 }
                });

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 7, new DateTime(2019, 6, 17, 15, 10, 22, 16, DateTimeKind.Local).AddTicks(8557), true, new DateTime(2019, 6, 17, 15, 10, 22, 16, DateTimeKind.Local).AddTicks(9975), 16 },
                    { 16, 14, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2255), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2264), 2 },
                    { 3, 17, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1392), false, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1401), 15 },
                    { 4, 10, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1459), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1472), 6 },
                    { 13, 10, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2055), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2068), 11 },
                    { 7, 5, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1664), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1672), 18 },
                    { 10, 5, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1864), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1872), 7 },
                    { 14, 3, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2126), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2135), 1 },
                    { 17, 15, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2321), false, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2330), 17 },
                    { 18, 15, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2388), false, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2397), 12 },
                    { 19, 15, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2455), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2464), 9 },
                    { 2, 4, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1295), false, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1317), 21 },
                    { 8, 2, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1730), false, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1739), 21 },
                    { 9, 2, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1797), false, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1806), 15 },
                    { 6, 8, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1597), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1606), 20 },
                    { 12, 8, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1992), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2006), 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentReactions_CommentId",
                table: "CommentReactions",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentReactions_UserId",
                table: "CommentReactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_DisPostReactions_PostId",
                table: "DisPostReactions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_DisPostReactions_UserId",
                table: "DisPostReactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostReactions_PostId",
                table: "PostReactions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostReactions_UserId",
                table: "PostReactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PreviewId",
                table: "Posts",
                column: "PreviewId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AvatarId",
                table: "Users",
                column: "AvatarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentReactions");

            migrationBuilder.DropTable(
                name: "DisPostReactions");

            migrationBuilder.DropTable(
                name: "PostReactions");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
