using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class commentdislike : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DisCommentReactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    IsDisLike = table.Column<bool>(nullable: false),
                    CommentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisCommentReactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DisCommentReactions_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DisCommentReactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 8, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(7669), false, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(8696), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9651), true, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9709), new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 19, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9749), new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9753), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 7, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9780), new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9789), 13 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9816), new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9820), 7 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9851), false, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9856), 8 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 6, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9882), true, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9887), 14 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 19, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9918), new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9922), 2 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9949), false, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9958), 18 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 14, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9985), false, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9989), 17 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 6, new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(16), new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(20), 13 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(47), new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(56), 2 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 7, new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(82), false, new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(87), 20 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(113), new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(118), 11 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 20, new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(149), false, new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(153), 4 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 9, new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(180), new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(185), 3 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 9, new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(211), new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(220), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 8, new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(247), false, new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(251), 13 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(278), new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(282), 21 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Aut alias et consequatur nisi eum debitis.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(2100), 4, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Aperiam asperiores sint ut aspernatur eum odit.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4024), 19, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Natus aliquam vel omnis occaecati vitae quisquam.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4286), 12, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Accusamus perferendis maxime quisquam porro ad placeat.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4371), 5, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Ipsam eius id autem laudantium.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4437), 11, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Ipsam qui fugit ut dignissimos.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4526), 1, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Fuga dicta corrupti quaerat aut rerum vero et impedit.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4611), 6, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "Et dolorem quidem officia ut harum labore laboriosam et.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4775), 7, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Omnis nihil laborum id.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4846), 7, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Omnis soluta delectus est distinctio accusantium a.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4917), 8, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 14, "Maiores dicta ducimus quae minus.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4980), 10, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Cupiditate ad vel tenetur.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5042), 3, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Omnis voluptatem impedit.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5091), 7, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Sequi vel ducimus.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5144), 3, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Quia aut natus nemo iusto accusamus voluptatibus libero.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5268), 18, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 20, "Illum possimus quia omnis.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5331), new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Animi reiciendis et laborum aut omnis magnam excepturi eaque.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5415), 17, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Repellat nisi et alias ipsam non sapiente delectus.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5491), 2, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Et ut repudiandae dicta necessitatibus molestiae non sunt.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5562), 7, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Aspernatur eos et error sunt et inventore et.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5695), 15, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(3571), 5, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(4575), 2 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5553), 19, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5566), 4 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5611), true, 17, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5620), 6 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5651), true, 9, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5655), 20 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5686), false, 9, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5691), 9 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5722), 3, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5726), 8 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5757), 13, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5762), 14 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5788), 20, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5793), 6 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5824), 3, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5828), 5 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5855), 8, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5860), 19 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5891), true, 14, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5895), 11 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "IsDisLike", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5926), false, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5931), 13 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5962), 2, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5966), 10 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5993), 12, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6002), 7 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6028), false, 4, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6033), 4 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6068), new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6073), 1 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6104), false, 18, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6108), 14 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6135), new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6140), 13 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6171), 16, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6175), 16 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6202), true, 20, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6211), 17 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 889, DateTimeKind.Local).AddTicks(4534), "https://s3.amazonaws.com/uifaces/faces/twitter/aka_james/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(6810), "https://s3.amazonaws.com/uifaces/faces/twitter/the_purplebunny/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(6872), "https://s3.amazonaws.com/uifaces/faces/twitter/mocabyte/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(6903), "https://s3.amazonaws.com/uifaces/faces/twitter/ffbel/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(6935), "https://s3.amazonaws.com/uifaces/faces/twitter/adhiardana/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(6966), "https://s3.amazonaws.com/uifaces/faces/twitter/sainraja/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(6997), "https://s3.amazonaws.com/uifaces/faces/twitter/spedwig/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7028), "https://s3.amazonaws.com/uifaces/faces/twitter/ahmadajmi/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7055), "https://s3.amazonaws.com/uifaces/faces/twitter/gipsy_raf/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7086), "https://s3.amazonaws.com/uifaces/faces/twitter/overra/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7112), "https://s3.amazonaws.com/uifaces/faces/twitter/woodydotmx/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7143), "https://s3.amazonaws.com/uifaces/faces/twitter/liminha/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7170), "https://s3.amazonaws.com/uifaces/faces/twitter/gt/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7201), "https://s3.amazonaws.com/uifaces/faces/twitter/amanruzaini/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7232), "https://s3.amazonaws.com/uifaces/faces/twitter/dmitriychuta/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7259), "https://s3.amazonaws.com/uifaces/faces/twitter/amywebbb/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7299), "https://s3.amazonaws.com/uifaces/faces/twitter/jarsen/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7335), "https://s3.amazonaws.com/uifaces/faces/twitter/gmourier/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7361), "https://s3.amazonaws.com/uifaces/faces/twitter/vigobronx/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7392), "https://s3.amazonaws.com/uifaces/faces/twitter/buleswapnil/128.jpg", new DateTime(2019, 6, 18, 1, 17, 4, 890, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(5045), "https://picsum.photos/640/480/?image=161", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6307), "https://picsum.photos/640/480/?image=777", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6356), "https://picsum.photos/640/480/?image=423", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6392), "https://picsum.photos/640/480/?image=1005", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6432), "https://picsum.photos/640/480/?image=62", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6463), "https://picsum.photos/640/480/?image=1071", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6494), "https://picsum.photos/640/480/?image=923", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6525), "https://picsum.photos/640/480/?image=384", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6556), "https://picsum.photos/640/480/?image=1011", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6587), "https://picsum.photos/640/480/?image=297", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6618), "https://picsum.photos/640/480/?image=765", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6649), "https://picsum.photos/640/480/?image=666", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6676), "https://picsum.photos/640/480/?image=148", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6707), "https://picsum.photos/640/480/?image=11", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6738), "https://picsum.photos/640/480/?image=136", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6769), "https://picsum.photos/640/480/?image=651", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6805), "https://picsum.photos/640/480/?image=978", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6836), "https://picsum.photos/640/480/?image=48", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6867), "https://picsum.photos/640/480/?image=351", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6898), "https://picsum.photos/640/480/?image=618", new DateTime(2019, 6, 18, 1, 17, 4, 897, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(1366), 18, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(2291), 17 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3504), 16, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3517), 5 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3562), false, 20, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3571), 8 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3597), 11, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3606), 8 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3633), true, 2, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3642), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3669), 8, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3673), 15 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3704), false, 14, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3713), 18 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3740), false, 7, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3744), 9 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3829), 5, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3833), 11 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3869), false, 4, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3873), 3 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3900), 5, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3904), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3935), 16, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3940), 13 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3966), true, 14, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3971), 6 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4002), 5, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4006), 9 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4033), true, 7, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4037), 6 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4069), 8, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4073), 19 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4104), 3, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4109), 3 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4140), 1, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4144), 8 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4171), 9, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4180), 5 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4206), 15, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4211), 13 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, "Et dolores quis est dolor qui.", new DateTime(2019, 6, 18, 1, 17, 5, 159, DateTimeKind.Local).AddTicks(5415), 27, new DateTime(2019, 6, 18, 1, 17, 5, 159, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, @"Repudiandae quaerat culpa vel et.
Sed beatae labore corporis nisi ex qui quas earum.
Quis aspernatur sed quia perspiciatis et voluptas fugiat.
Numquam molestias et.
Aliquam architecto illo harum eligendi magni tempore.", new DateTime(2019, 6, 18, 1, 17, 5, 160, DateTimeKind.Local).AddTicks(6953), 36, new DateTime(2019, 6, 18, 1, 17, 5, 160, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, @"Quibusdam sequi explicabo enim omnis necessitatibus eius ut et aperiam.
Architecto exercitationem possimus ab recusandae.", new DateTime(2019, 6, 18, 1, 17, 5, 160, DateTimeKind.Local).AddTicks(7269), 35, new DateTime(2019, 6, 18, 1, 17, 5, 160, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "Exercitationem totam maiores tempora nostrum.", new DateTime(2019, 6, 18, 1, 17, 5, 160, DateTimeKind.Local).AddTicks(7366), 35, new DateTime(2019, 6, 18, 1, 17, 5, 160, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "Aut qui corrupti sed vel.", new DateTime(2019, 6, 18, 1, 17, 5, 160, DateTimeKind.Local).AddTicks(7433), 35, new DateTime(2019, 6, 18, 1, 17, 5, 160, DateTimeKind.Local).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "cupiditate", new DateTime(2019, 6, 18, 1, 17, 5, 160, DateTimeKind.Local).AddTicks(8478), 25, new DateTime(2019, 6, 18, 1, 17, 5, 160, DateTimeKind.Local).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, "Consequatur eius quod.", new DateTime(2019, 6, 18, 1, 17, 5, 160, DateTimeKind.Local).AddTicks(8633), 40, new DateTime(2019, 6, 18, 1, 17, 5, 160, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, "Voluptatem amet voluptatem libero et sit ipsum et. Illo amet pariatur. Et corporis nulla sed sint aut laboriosam cumque modi eos.", new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(2269), 40, new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "Voluptas corrupti enim iure voluptas quis provident vero.", new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(2384), 31, new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "Ut consequatur quas dolor eos odio. Necessitatibus sint saepe. Quam molestiae quod ipsa quibusdam quae. Fuga commodi tempore ea vel. Libero quam natus iusto veritatis possimus cum libero.", new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(2660), 24, new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 3, "Sapiente qui id dolore assumenda pariatur deserunt et. Voluptas unde quos inventore et consequatur et ea maxime dolores. Quibusdam excepturi quisquam debitis id dolorem nesciunt numquam est incidunt. Earum impedit beatae vitae sed.", new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(2971), new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, "Voluptas cumque culpa perferendis rerum alias quaerat accusamus molestiae. At nam nisi molestiae qui aut est facilis rerum. Vel explicabo id molestias id dolor reiciendis quam. Modi dolore voluptas qui sed. Consequatur eos et distinctio qui ut ut nisi in deleniti.", new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(3309), 26, new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "harum", new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(3362), 29, new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "Et voluptate placeat delectus quasi voluptate neque voluptatem voluptas deserunt.", new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(3451), 25, new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "vitae", new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(3495), 23, new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, @"Maiores quia temporibus doloremque placeat suscipit doloremque sit esse.
Repellendus voluptas non omnis aut porro autem sed nulla.
Praesentium dolores et.
Facere eos illum.
Adipisci modi amet doloribus rem et.
Quo architecto autem repellat et ipsa.", new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(3900), 22, new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "illo", new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(3998), 36, new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "Ut voluptas quibusdam saepe in. Voluptatem qui ad laborum occaecati natus. Consectetur quidem quibusdam quis.", new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(4127), 30, new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(4131) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 5, "facilis", new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(4171), 29, new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, "accusantium", new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(4215), 28, new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2019, 6, 18, 1, 17, 4, 936, DateTimeKind.Local).AddTicks(2623), "Heather.Turner3@yahoo.com", "KwEGs/lmxaVuEzQYFtWybBe7ZZpD3KlYRO5blo63U5c=", "0HnSOwpnTMk6pG530jA2qfJeiT/JgfFw/vc9aaxibLs=", new DateTime(2019, 6, 18, 1, 17, 4, 936, DateTimeKind.Local).AddTicks(3707), "Ibrahim.Kuphal" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2019, 6, 18, 1, 17, 4, 946, DateTimeKind.Local).AddTicks(9983), "Kaylin_OConner@gmail.com", "l8LYqehV8G5ZNMQJBxhvrel0HA0HjzS+SvhJWD295kc=", "KyV5CEXhijXQteYtFgUYT4IHMdLm/xpHm7TS5bYXNPM=", new DateTime(2019, 6, 18, 1, 17, 4, 947, DateTimeKind.Local).AddTicks(28), "Amber.Renner64" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2019, 6, 18, 1, 17, 4, 957, DateTimeKind.Local).AddTicks(2063), "Amanda_Koch38@gmail.com", "ZN2UR2C2c0IJQnT0aQDFF/sY3ibpcSAeoTrNBvZlOP0=", "aYS/WnEcbzl0nl2mhQPfluYVyqKOOwo/avtBiwKeeII=", new DateTime(2019, 6, 18, 1, 17, 4, 957, DateTimeKind.Local).AddTicks(2081), "Dulce35" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2019, 6, 18, 1, 17, 4, 967, DateTimeKind.Local).AddTicks(5676), "Trey.Reynolds26@yahoo.com", "funDSo3BsIaDATbgtvXnRtDZE0skgH+gruip8al+dmk=", "hvlxQoW8A4mYUrqPtIC99QsHIc+ShD7X3W/JbBK3vck=", new DateTime(2019, 6, 18, 1, 17, 4, 967, DateTimeKind.Local).AddTicks(5698), "Jasen_DuBuque" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2019, 6, 18, 1, 17, 4, 977, DateTimeKind.Local).AddTicks(8859), "Kariane78@hotmail.com", "Hj0+FbUaI1FjveWqbrj9TIUmHrqlbOq7y7uuIrcnOwU=", "H0cZXZXOhxfGtIlDggNa66ypJn80cjx7SRuue6m/sFE=", new DateTime(2019, 6, 18, 1, 17, 4, 977, DateTimeKind.Local).AddTicks(8899), "Laura53" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 6, 18, 1, 17, 4, 988, DateTimeKind.Local).AddTicks(5383), "Kiley.Wintheiser10@gmail.com", "VHmKTYHUAnfBMkrAJ5Ocq1fvAMUeKombu+CcTDzXzDc=", "uI2rI0VOSK/kuprDtFJLLq25Ti6rfL3mZG6f9HcHN8k=", new DateTime(2019, 6, 18, 1, 17, 4, 988, DateTimeKind.Local).AddTicks(5410), "Jensen33" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2019, 6, 18, 1, 17, 4, 998, DateTimeKind.Local).AddTicks(7024), "Brandon68@hotmail.com", "wfxPiFBgWelM08CX+q/rF+o3ckhOgtOoiIZSI/bgz0M=", "6ED6/LaIIMApHpmJcVswgbsVsgqNAWugMsYuG4UaxEk=", new DateTime(2019, 6, 18, 1, 17, 4, 998, DateTimeKind.Local).AddTicks(7041), "Buster.Mohr" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2019, 6, 18, 1, 17, 5, 9, DateTimeKind.Local).AddTicks(6308), "Camille74@yahoo.com", "ZoSTQsajyw9dqeHYW/AZNTV/nFyn78NThNVlVFuk2tk=", "siXZjlCEPXjjLuSmeIH6vDOF6W+rTpHbTLDqGSVO290=", new DateTime(2019, 6, 18, 1, 17, 5, 9, DateTimeKind.Local).AddTicks(6371), "Amalia.Schiller" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2019, 6, 18, 1, 17, 5, 19, DateTimeKind.Local).AddTicks(8525), "Katherine.Zulauf21@hotmail.com", "yxO+LVV2ymu8ljgNyDqJFg7kAtqnnDBGkKWWUwC5xA8=", "n+eWq35dvkcTDLLnv9p2GtdbLhs2xgQj+JJBEsCW1cw=", new DateTime(2019, 6, 18, 1, 17, 5, 19, DateTimeKind.Local).AddTicks(8543), "Grace26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2019, 6, 18, 1, 17, 5, 32, DateTimeKind.Local).AddTicks(375), "Melyna.Anderson@hotmail.com", "tV/f5RwN6dbWqM+3UFlvuYWLFLaJBugdhf+wt4EiDGw=", "jmR5XLDnKuWtI2AzkZcxetv4zfz6jX5ZRaJnjD4blZw=", new DateTime(2019, 6, 18, 1, 17, 5, 32, DateTimeKind.Local).AddTicks(410), "Haley.Windler" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2019, 6, 18, 1, 17, 5, 42, DateTimeKind.Local).AddTicks(4966), "Rocky12@gmail.com", "ZR6OWya2clSz/rNMwUEmFi+OR3SV4xx4po6pvuOZWgw=", "7dRH4sjCqxOwW5ALIyyOKYHPE9rTw3zQ/RVmXDjg0pY=", new DateTime(2019, 6, 18, 1, 17, 5, 42, DateTimeKind.Local).AddTicks(4997), "Mackenzie.Jacobi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2019, 6, 18, 1, 17, 5, 52, DateTimeKind.Local).AddTicks(7326), "Hosea77@yahoo.com", "KIeRHcbNa9VQbn1NrRwoN5q7ZvGf40lg5FHmD/szw2c=", "+kw9i4r63iTqMUg23SsDRaIurYzY+Ekzj48Djv6GWhU=", new DateTime(2019, 6, 18, 1, 17, 5, 52, DateTimeKind.Local).AddTicks(7348), "Reyes7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 63, DateTimeKind.Local).AddTicks(6535), "Toby_Berge@gmail.com", "QbiRzT8kVnbfxUKIY5yH/nGtCl1alH90ifNNlUIkmnY=", "VuMUWjd4OONmiuejGtZ10O9ewFNE83qcqdXbGDsj8Ls=", new DateTime(2019, 6, 18, 1, 17, 5, 63, DateTimeKind.Local).AddTicks(6571), "Dane_Heidenreich82" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2019, 6, 18, 1, 17, 5, 74, DateTimeKind.Local).AddTicks(8935), "Jamil26@yahoo.com", "GX/YhjgbOqUZkoYc/QhQdfVjXT4oa/iR2Fi2YROtrIg=", "Ja+MtcDb3N0j+bpHe9YwfjcnukNNeqdnFuLEPGZk8P0=", new DateTime(2019, 6, 18, 1, 17, 5, 74, DateTimeKind.Local).AddTicks(8971), "Ramiro.Jacobi50" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 6, 18, 1, 17, 5, 85, DateTimeKind.Local).AddTicks(633), "Cristopher12@hotmail.com", "zMBYj3LHmjL56k6hoAl5lD4Ui2c4+Im9SAIxucZrBWo=", "AMhKc0zk/AohshkuNnN5biGBWoomMGp6Bil7Kb/6aig=", new DateTime(2019, 6, 18, 1, 17, 5, 85, DateTimeKind.Local).AddTicks(646), "Agustina_Haley" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2019, 6, 18, 1, 17, 5, 95, DateTimeKind.Local).AddTicks(2695), "Dereck67@hotmail.com", "JD1bBO+FfjGAx+yQvjF6Xo1gYzeiSuD8k8u3Ai7VF20=", "RNXlsi9DKuQoCZDW9y8sYO8Qx3YKUe/+/1dOytrVQVA=", new DateTime(2019, 6, 18, 1, 17, 5, 95, DateTimeKind.Local).AddTicks(2708), "Susie.Sanford" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 6, 18, 1, 17, 5, 105, DateTimeKind.Local).AddTicks(7988), "Regan.Muller49@hotmail.com", "68nsiIqwCPWQXJjMefqZ85AOtUJIU9sWJesHJEOZQ2M=", "XR2DGf3JG++pBOgsxaSkg6yfrfrvtl7XrdrPE7sPD7A=", new DateTime(2019, 6, 18, 1, 17, 5, 105, DateTimeKind.Local).AddTicks(8024), "Ayden_Weimann" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 6, 18, 1, 17, 5, 115, DateTimeKind.Local).AddTicks(9433), "Oda_Schaden@gmail.com", "pbLUa9lhLpBJnWy9xZZ8kae0Qc6Tn6j0lva35GBiDPo=", "EaTV3HozYn0iIN8lYkkH3NTv+7Mi3zr3pYgNT/lCQck=", new DateTime(2019, 6, 18, 1, 17, 5, 115, DateTimeKind.Local).AddTicks(9446), "Maegan_Ward28" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2019, 6, 18, 1, 17, 5, 126, DateTimeKind.Local).AddTicks(1024), "Cora_Okuneva27@gmail.com", "GQH0hny4aDOD+fxYI5f4kwDmRHm6J2JJ/RVvW4CxCpc=", "Vnzu6h582SX5w4dhLU3KjXdRiBqeF7G8GltsuTva6BA=", new DateTime(2019, 6, 18, 1, 17, 5, 126, DateTimeKind.Local).AddTicks(1046), "Jaida.Brekke1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2019, 6, 18, 1, 17, 5, 136, DateTimeKind.Local).AddTicks(6624), "Destini.Reichert@yahoo.com", "BQobkZUlj2L6lmIJsBi5Q8s3yO7GaD2PTfx9tOL5zzc=", "m/wiNqf7cvMFBw3alelYg0/1clP5puK9ulhB3vaXuLA=", new DateTime(2019, 6, 18, 1, 17, 5, 136, DateTimeKind.Local).AddTicks(6659), "Damon_DuBuque" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 146, DateTimeKind.Local).AddTicks(8620), "hc8NEdS+j/m+rx4YS3s57asHiyq74IAJCbMdPEM2slw=", "CK/eUt3HTrORwlCrKkZvVtVxzBHKdgR0WG+mTFYAMWw=", new DateTime(2019, 6, 18, 1, 17, 5, 146, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.CreateIndex(
                name: "IX_DisCommentReactions_CommentId",
                table: "DisCommentReactions",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_DisCommentReactions_UserId",
                table: "DisCommentReactions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DisCommentReactions");

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 7, new DateTime(2019, 6, 17, 15, 10, 22, 16, DateTimeKind.Local).AddTicks(8557), true, new DateTime(2019, 6, 17, 15, 10, 22, 16, DateTimeKind.Local).AddTicks(9975), 16 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1295), false, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt" },
                values: new object[] { 17, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1392), new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 10, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1459), new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1472), 6 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 9, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1530), new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1539), 7 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 8, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1597), new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1606), 20 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1664), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1672), 18 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1730), false, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1739), 21 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1797), new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1806), 15 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1864), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1872), 7 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 9, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1926), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1939), 11 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 8, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(1992), new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2006), 4 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 10, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2055), new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2068), 11 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 3, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2126), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2135), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 16, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2192), new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2201), 20 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 14, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2255), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2264), 2 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 15, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2321), new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2330), 17 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 15, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2388), new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2397), 12 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 15, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2455), true, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2464), 9 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 6, new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2521), new DateTime(2019, 6, 17, 15, 10, 22, 17, DateTimeKind.Local).AddTicks(2530), 14 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Magni vero velit qui.", new DateTime(2019, 6, 17, 15, 10, 21, 977, DateTimeKind.Local).AddTicks(7712), 20, new DateTime(2019, 6, 17, 15, 10, 21, 977, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Ratione est reiciendis.", new DateTime(2019, 6, 17, 15, 10, 21, 977, DateTimeKind.Local).AddTicks(9788), 10, new DateTime(2019, 6, 17, 15, 10, 21, 977, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 12, "Est quam cumque neque velit quia at consequatur magnam aut.", new DateTime(2019, 6, 17, 15, 10, 21, 977, DateTimeKind.Local).AddTicks(9925), 1, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Commodi aut qui asperiores.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(104), 6, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Id ipsa magni.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(166), 12, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "Sed quaerat id ex voluptate sit laudantium ipsa minus non.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(250), 2, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 12, "Eos ducimus dolor aut nulla distinctio sed rerum et veritatis.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(335), 14, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Sit reprehenderit eum est nostrum quam culpa voluptatum quidem mollitia.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(419), 18, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Occaecati iste magni et quibusdam aut molestiae.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(557), 8, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Nihil nesciunt veniam fuga totam doloribus sint.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(633), 4, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Praesentium quo quasi distinctio consequuntur et commodi corrupti.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(708), 5, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Repudiandae maiores et eos natus vel doloribus ut omnis.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(793), 19, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Est a ducimus consequatur autem fugit atque porro in.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(873), 4, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Nobis atque totam quas.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(988), 9, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Sed quia voluptas excepturi quia eaque.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1055), 19, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 12, "Non non velit reiciendis.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1113), new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Cumque cum sint similique autem.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1170), 11, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Illum quibusdam aut qui architecto ut.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1241), 8, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Quis consequatur est consequatur ducimus.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1299), 20, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1304) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Quia nemo repellendus rem soluta.", new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1415), 12, new DateTime(2019, 6, 17, 15, 10, 21, 978, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(7170), 16, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(8259), 19 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9299), 12, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9312), 7 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9388), false, 5, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9397), 9 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9450), false, 16, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9459), 6 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9504), true, 10, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9512), 14 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9575), 12, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9588), 11 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9668), 19, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9686), 11 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9797), 5, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9815), 17 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9890), 11, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9904), 2 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9966), 13, new DateTime(2019, 6, 17, 15, 10, 22, 2, DateTimeKind.Local).AddTicks(9975), 3 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(370), false, 5, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(392), 2 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "IsDisLike", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(499), true, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(508), 18 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(579), 8, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(588), 1 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(646), 13, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(659), 3 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(712), true, 5, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(726), 10 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(784), new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(792), 18 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(850), true, 14, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(859), 2 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(917), new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(930), 1 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(988), 3, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(1001), 14 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(1059), false, 6, new DateTime(2019, 6, 17, 15, 10, 22, 3, DateTimeKind.Local).AddTicks(1068), 12 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 698, DateTimeKind.Local).AddTicks(1920), "https://s3.amazonaws.com/uifaces/faces/twitter/svenlen/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3204), "https://s3.amazonaws.com/uifaces/faces/twitter/mtolokonnikov/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3262), "https://s3.amazonaws.com/uifaces/faces/twitter/ivanfilipovbg/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3293), "https://s3.amazonaws.com/uifaces/faces/twitter/chadengle/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3324), "https://s3.amazonaws.com/uifaces/faces/twitter/petrangr/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3355), "https://s3.amazonaws.com/uifaces/faces/twitter/cadikkara/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3382), "https://s3.amazonaws.com/uifaces/faces/twitter/doronmalki/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3413), "https://s3.amazonaws.com/uifaces/faces/twitter/nellleo/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3444), "https://s3.amazonaws.com/uifaces/faces/twitter/jennyyo/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3471), "https://s3.amazonaws.com/uifaces/faces/twitter/Chakintosh/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3497), "https://s3.amazonaws.com/uifaces/faces/twitter/brandonflatsoda/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3528), "https://s3.amazonaws.com/uifaces/faces/twitter/rez___a/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3555), "https://s3.amazonaws.com/uifaces/faces/twitter/thedamianhdez/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3586), "https://s3.amazonaws.com/uifaces/faces/twitter/reabo101/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3613), "https://s3.amazonaws.com/uifaces/faces/twitter/ostirbu/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3640), "https://s3.amazonaws.com/uifaces/faces/twitter/kalmerrautam/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3671), "https://s3.amazonaws.com/uifaces/faces/twitter/slowspock/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3786), "https://s3.amazonaws.com/uifaces/faces/twitter/flashmurphy/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3813), "https://s3.amazonaws.com/uifaces/faces/twitter/mattsapii/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3844), "https://s3.amazonaws.com/uifaces/faces/twitter/darcystonge/128.jpg", new DateTime(2019, 6, 17, 15, 10, 21, 699, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(5266), "https://picsum.photos/640/480/?image=682", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6644), "https://picsum.photos/640/480/?image=656", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6689), "https://picsum.photos/640/480/?image=149", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6720), "https://picsum.photos/640/480/?image=39", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6751), "https://picsum.photos/640/480/?image=475", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6782), "https://picsum.photos/640/480/?image=1033", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6813), "https://picsum.photos/640/480/?image=660", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6840), "https://picsum.photos/640/480/?image=942", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6871), "https://picsum.photos/640/480/?image=155", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6902), "https://picsum.photos/640/480/?image=521", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6933), "https://picsum.photos/640/480/?image=658", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7017), "https://picsum.photos/640/480/?image=838", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7049), "https://picsum.photos/640/480/?image=704", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7075), "https://picsum.photos/640/480/?image=693", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7106), "https://picsum.photos/640/480/?image=351", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7137), "https://picsum.photos/640/480/?image=914", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7169), "https://picsum.photos/640/480/?image=919", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7195), "https://picsum.photos/640/480/?image=985", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7226), "https://picsum.photos/640/480/?image=1014", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7294), "https://picsum.photos/640/480/?image=590", new DateTime(2019, 6, 17, 15, 10, 21, 706, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(1673), 16, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(3033), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5264), 18, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5291), 21 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5366), true, 14, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5371), 11 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5402), 8, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5411), 15 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5442), false, 17, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5446), 1 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5477), 11, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5482), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5508), true, 4, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5517), 15 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5544), true, 6, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5553), 7 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5588), 6, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5597), 20 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5651), true, 15, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5664), 16 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5722), 12, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5731), 3 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5904), 18, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5913), 18 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5975), false, 9, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(5984), 14 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6037), 18, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6046), 5 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6104), false, 15, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6113), 15 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6166), 6, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6175), 1 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6251), 7, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6277), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6326), 11, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6335), 13 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6384), 18, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6393), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6451), 1, new DateTime(2019, 6, 17, 15, 10, 21, 990, DateTimeKind.Local).AddTicks(6464), 9 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "mollitia", new DateTime(2019, 6, 17, 15, 10, 21, 964, DateTimeKind.Local).AddTicks(3424), 21, new DateTime(2019, 6, 17, 15, 10, 21, 964, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "iure", new DateTime(2019, 6, 17, 15, 10, 21, 964, DateTimeKind.Local).AddTicks(5433), 23, new DateTime(2019, 6, 17, 15, 10, 21, 964, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "Voluptas aut consequatur nulla itaque beatae aut voluptatum qui sint. Quis iusto et magnam laudantium ut vel consectetur enim. Perferendis voluptatum et veniam odit omnis voluptatem sit.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(1735), 40, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, @"Consequatur et sint.
Quo fugiat tempore et expedita dolores suscipit.
Qui perferendis doloribus et dolores.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(3708), 32, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(3726) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, "Sit dolor natus eum cupiditate. Nostrum voluptatem quam eius voluptates sit quos ducimus unde nisi. Ea rerum eaque ea nisi exercitationem aut cupiditate.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(4046), 31, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "Voluptates eaque occaecati rerum eligendi totam id veritatis aut.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(6455), 27, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "Quo fugit in aliquam occaecati ut autem.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(6646), 36, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "eius", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(6695), 24, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "Nemo maiores tenetur accusantium ullam excepturi sit. Dignissimos et reiciendis consequatur minima repellendus. Tenetur cumque at. Sit sunt ut sit quos rerum inventore doloribus. Ullam nihil id deleniti at voluptatum in voluptatem minus. Quia sed non aut vel.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(6988), 35, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, @"Dolorem ut deleniti aut.
Cumque perferendis ipsa ut laudantium.
Labore occaecati commodi sunt.
Veritatis et tenetur et non id eius iure.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7152), 33, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 5, "Blanditiis ullam non voluptatem unde vero et.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7232), new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, @"Laudantium sed ut enim.
Ut soluta error et.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7366), 22, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "laborum", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7415), 35, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, "Explicabo praesentium recusandae.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7477), 29, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, @"Dolorem eligendi nam impedit inventore sint nihil.
Quibusdam suscipit cum iure hic eius.
Maxime est rerum vel quidem et nihil quo.
Modi maiores magni quia sit impedit perferendis hic cum id.
Minima sit vero eos natus.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7810), 25, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "Ipsa aspernatur debitis dolor. Possimus consequatur sed aperiam. Sed at est atque architecto eum magnam velit. Quia est quo.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8024), 25, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "Fugiat omnis qui ea amet necessitatibus laudantium eligendi.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8104), 24, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, "Repellat hic quia maxime rerum et.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8170), 25, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "Temporibus quia maiores atque est.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8237), 22, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "Alias eum blanditiis molestiae doloremque eum harum atque incidunt reprehenderit.", new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8321), 21, new DateTime(2019, 6, 17, 15, 10, 21, 967, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2019, 6, 17, 15, 10, 21, 745, DateTimeKind.Local).AddTicks(4262), "Stephania_Reynolds@hotmail.com", "DV3RfSAIWZiOnWWimckn0YDdPWi0hk3rPOmz0/rZlkY=", "lCCcNyCxQnA2eHfF9Wr11LlYjN1syVIiYQN5kpYdOBQ=", new DateTime(2019, 6, 17, 15, 10, 21, 745, DateTimeKind.Local).AddTicks(5347), "Jaycee_Abbott" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2019, 6, 17, 15, 10, 21, 755, DateTimeKind.Local).AddTicks(8920), "Amber13@yahoo.com", "2QTlWpPfHc6utxTPWBoqV6GyF27x2RFjFkbzlrnP0u8=", "s4NxsxdikJXnzHhEifXyI6Z6b5TRn8L+lwSmrdI/O8w=", new DateTime(2019, 6, 17, 15, 10, 21, 755, DateTimeKind.Local).AddTicks(8943), "Toby_Hayes" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2019, 6, 17, 15, 10, 21, 765, DateTimeKind.Local).AddTicks(9658), "Perry78@hotmail.com", "+TjsBFKpsEirTppkTgHA4NRxnuEOni8QMEG36HOwo3k=", "5/vjS6PWR5Pqv8S29pxhmnWgK6vB4A9IyAMhZ71IQmg=", new DateTime(2019, 6, 17, 15, 10, 21, 765, DateTimeKind.Local).AddTicks(9680), "Daniela.Jenkins7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2019, 6, 17, 15, 10, 21, 776, DateTimeKind.Local).AddTicks(409), "Juston.Zemlak20@gmail.com", "R3wu0pzwXy0dFcLMVB1CGMNdFrG+Y/LkBwl2j22BHLM=", "GQPkn0mLYyGYAds6gHCNz9LZ8rFPb+05FwgKLKgUAas=", new DateTime(2019, 6, 17, 15, 10, 21, 776, DateTimeKind.Local).AddTicks(436), "Susan36" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2019, 6, 17, 15, 10, 21, 786, DateTimeKind.Local).AddTicks(1703), "Hector.Hermiston@hotmail.com", "JGklaZOVjagqDn3/8aAn5KdVlYkOim6pGGQptgkEVvY=", "VHibLUE+le3bw2v6NPckVJMWvjD7fTkViYsIZ0y7wS4=", new DateTime(2019, 6, 17, 15, 10, 21, 786, DateTimeKind.Local).AddTicks(1721), "Cali.Hand50" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2019, 6, 17, 15, 10, 21, 796, DateTimeKind.Local).AddTicks(4254), "Jensen_Sanford96@gmail.com", "LgNcGg/V4J6hvwb8Ltx/tU8f0F5PDnif3AUhKdMqFFM=", "TCqD7fc3Bv+DlLiBM20rhy/OSnwvJDrJy7EjCqN80tA=", new DateTime(2019, 6, 17, 15, 10, 21, 796, DateTimeKind.Local).AddTicks(4285), "Angie36" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2019, 6, 17, 15, 10, 21, 806, DateTimeKind.Local).AddTicks(4684), "Marcus83@yahoo.com", "T03/VIGWAiOBrd1lW3CSXpX4BclAiK+ChxIHaq1ua8Q=", "P3onZ3mHOmkD4hYK87Ekw/4tkt0qXfionB7/Yj9OKhA=", new DateTime(2019, 6, 17, 15, 10, 21, 806, DateTimeKind.Local).AddTicks(4702), "Diamond_Heller" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2019, 6, 17, 15, 10, 21, 816, DateTimeKind.Local).AddTicks(4796), "Virgie.Willms32@yahoo.com", "YAYoVRyjSydOu6U81mnLz16HvQl6jtwOzAJQFGH0lT0=", "tnFpn8s9Bbb5Pz/FVVh/kQqzT/yFDEFhIVK6aItImyo=", new DateTime(2019, 6, 17, 15, 10, 21, 816, DateTimeKind.Local).AddTicks(4805), "Madeline_Shanahan" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2019, 6, 17, 15, 10, 21, 826, DateTimeKind.Local).AddTicks(8032), "Amani11@hotmail.com", "iUyW1f4xkAsJ5jMU6PzEOrf/uLKVUp7VGOXuaxW+7Fc=", "PVI+RfI8midbnnXBZNNxy2HJ4hk4hMXKz0bxIsTS9NM=", new DateTime(2019, 6, 17, 15, 10, 21, 826, DateTimeKind.Local).AddTicks(8054), "Krista51" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2019, 6, 17, 15, 10, 21, 837, DateTimeKind.Local).AddTicks(2290), "Gina5@yahoo.com", "NNtAKDXwmaPZZc3fYF2y0KLiCvdcRlhCQV8QEoP57wI=", "Hsihg0gNfmPdVXQP9b6hQdQvwD7p96wgn+JOpBky2dg=", new DateTime(2019, 6, 17, 15, 10, 21, 837, DateTimeKind.Local).AddTicks(2316), "Emma_Hegmann60" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2019, 6, 17, 15, 10, 21, 847, DateTimeKind.Local).AddTicks(2760), "Evan_White9@yahoo.com", "yB50TKS8p85ZrdGkB+SaWfA1/rxaP5FDOPiDFhF4ezM=", "yV8Td3HKfvxGmuBs8zRf5IqBjSBgRbXwya5rldqI4Wg=", new DateTime(2019, 6, 17, 15, 10, 21, 847, DateTimeKind.Local).AddTicks(2778), "Jamel_Veum41" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 6, 17, 15, 10, 21, 857, DateTimeKind.Local).AddTicks(4574), "Camylle.Haley@gmail.com", "VBIUAtuCDlj741s9M3ABzLlZgKTqAOGy/cc5ES4a/+0=", "8UfLrcGYv9pb6c5hldd+q5FIpzG9dqSccWZVqbcJvaA=", new DateTime(2019, 6, 17, 15, 10, 21, 857, DateTimeKind.Local).AddTicks(4591), "Devante_Simonis" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 867, DateTimeKind.Local).AddTicks(5392), "Retha_Considine53@gmail.com", "lQH3Y1kUjuA6eMoHDvkkXAG2xcIg5sJ3I2eNAZNfwgw=", "eR9E6MEZ5ZDXyyeH78IAcDag+Kpj/jlrzZFb0EcfsMk=", new DateTime(2019, 6, 17, 15, 10, 21, 867, DateTimeKind.Local).AddTicks(5414), "Jolie_Howell" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2019, 6, 17, 15, 10, 21, 879, DateTimeKind.Local).AddTicks(4743), "Arch_Moen15@gmail.com", "QyGZ0YccVoqlinVc/fUFN0IopNudmF/oISidbigCVeQ=", "5Jy4dbdZDiZw7kf1AUAHwwErYb89NLXfhO05/gtD1qk=", new DateTime(2019, 6, 17, 15, 10, 21, 879, DateTimeKind.Local).AddTicks(4779), "Abraham_Sauer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2019, 6, 17, 15, 10, 21, 890, DateTimeKind.Local).AddTicks(1169), "Arnold.Doyle55@yahoo.com", "5igdHvSGa72JFdKswPTs71tLc0CzKH93K9ThimyJXDY=", "uc2n+dpMJAG99I6x3BYmWOmFvc9sn2P0A7cyrc/ejcs=", new DateTime(2019, 6, 17, 15, 10, 21, 890, DateTimeKind.Local).AddTicks(1209), "Carolanne.Beahan6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2019, 6, 17, 15, 10, 21, 901, DateTimeKind.Local).AddTicks(7179), "Shaun.Koch76@yahoo.com", "cjPAfzDaL7/MlWHUkQ7faaeM3knTA5RuS2QJP8QA7TQ=", "EvA2+vLG0S7nnrEdBBTJo+2r1B/7CbqgEpF0rMLhNXY=", new DateTime(2019, 6, 17, 15, 10, 21, 901, DateTimeKind.Local).AddTicks(7223), "Jovan73" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2019, 6, 17, 15, 10, 21, 912, DateTimeKind.Local).AddTicks(5249), "Dario_Heller@gmail.com", "UqTfWqmp39hu368vFsFiQB54JD6tZyrdPUPJBFl3vSA=", "ZHtBzKkLeE6gGTWd4wlsXGFERK4aO1IdLIx0z2JHFb4=", new DateTime(2019, 6, 17, 15, 10, 21, 912, DateTimeKind.Local).AddTicks(5276), "Renee.Feeney" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2019, 6, 17, 15, 10, 21, 922, DateTimeKind.Local).AddTicks(6760), "Pedro_Lemke@gmail.com", "FpN0XtFLvSjgFcZAsiJ7TMzP7XgPQXeoII2L06a8VaM=", "uchRnlu4H39IT+ud5ivreGvZms8qoU1k8micz4fKj+Y=", new DateTime(2019, 6, 17, 15, 10, 21, 922, DateTimeKind.Local).AddTicks(6778), "Rosalind.Kuhic" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 6, 17, 15, 10, 21, 932, DateTimeKind.Local).AddTicks(7321), "Alexane.Kemmer@gmail.com", "RmdIsnq0Oq/AzJzogMgyE73ERhHNkqaH86YyCpf2rWY=", "QEnukf3U/7iXCuu7aK89EnP+w3Mrw18+ufRisRto59E=", new DateTime(2019, 6, 17, 15, 10, 21, 932, DateTimeKind.Local).AddTicks(7347), "Eulah.Dietrich95" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2019, 6, 17, 15, 10, 21, 942, DateTimeKind.Local).AddTicks(9236), "Barney_Zemlak52@gmail.com", "jfYuDlFjocB77RLG9ShExVNTPZaSLu5pm2poyR9vBEM=", "W94Ok0Y2lPfRmaRbkSChj5Mhcw3gZLBrMj7D3Xz+BbQ=", new DateTime(2019, 6, 17, 15, 10, 21, 942, DateTimeKind.Local).AddTicks(9263), "Rocky43" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 17, 15, 10, 21, 952, DateTimeKind.Local).AddTicks(9308), "tlsRD84IM9CUB+apKtjuui7neJwZKiVypKAKdWMgrZQ=", "kodLmlV4z1U/aXmRRuqY20LbaapJt1QJ4zlEOwAB2To=", new DateTime(2019, 6, 17, 15, 10, 21, 952, DateTimeKind.Local).AddTicks(9308) });
        }
    }
}
