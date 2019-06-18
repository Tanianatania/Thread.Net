using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class DisReactions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(6403), new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(7314), 15 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 11, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8323), false, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8336), 20 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 15, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8381), new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8385), 11 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 13, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8416), false, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8425), 17 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 19, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8452), new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8456), 12 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8487), new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8492), 4 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 8, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8523), new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8527), 19 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 14, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8558), new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8563), 2 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8594), true, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8598), 18 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8625), true, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8661), new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8665), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 12, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8696), false, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8701), 3 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8727), new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8736), 18 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8763), true, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8767), 3 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 12, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8794), new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8803), 21 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 14, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8830), true, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8834), 18 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 20, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8861), new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8870), 11 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 19, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8896), new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8901), 9 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 13, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8932), true, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8936), 14 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8963), new DateTime(2019, 6, 18, 1, 34, 0, 407, DateTimeKind.Local).AddTicks(8972), 13 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Ratione porro qui error voluptatem itaque non molestiae excepturi.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(3185), 8, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Sed rem dignissimos omnis dolores voluptatem natus vitae voluptatem quam.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(5225), 6, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Eum iste suscipit eos cum optio eum.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(5399), 9, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "Deserunt fugiat numquam esse quia.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(5474), 2, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "Eaque dignissimos quas autem consequatur voluptates laboriosam quia quisquam.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(5559), 20, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(5563) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Est aut rem veritatis debitis eum adipisci.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(5630), 17, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Perspiciatis aut nihil sed at porro veniam ut.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(5705), 10, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Qui nam vel repellat.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(5803), 4, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 14, "Occaecati rem reiciendis inventore illum at.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(5874), 12, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Voluptatem sed itaque reprehenderit sit.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(5936), 9, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Ea tempore dolore inventore dolorum molestiae illum sed et vel.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6021), 7, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Et accusamus adipisci assumenda perspiciatis commodi expedita corrupti.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6096), 18, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Enim ex magni consequatur ullam odit.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6270), 12, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6279) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Repudiandae mollitia suscipit earum consequatur.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6341), 11, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Cupiditate voluptatem rem atque.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6399), 15, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Nam maxime fuga.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6456), 13, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Velit sed illum facere repellendus voluptatem autem ducimus ut.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6536), 5, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Dicta quod totam sed magnam in facilis.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6621), 10, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Delectus vel aut eaque et quae nihil omnis atque est.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6772), 11, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Voluptatum sint amet qui quidem facere quo.", new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6847), 19, new DateTime(2019, 6, 18, 1, 34, 0, 376, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(1012), true, 9, new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(1932), 9 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(2888), 10, new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(2906), 16 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(2946), false, 7, new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(2955), 3 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(2986), false, 19, new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(2990), 18 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3021), true, 13, new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3026), 4 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3052), false, 10, new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3057), 14 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3088), true, 14, new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3097), 4 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3123), new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3128), 14 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3159), false, 17, new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3163), 2 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3195), new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3199), 1 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3230), false, 20, new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3235), 7 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3261), 13, new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3270), 10 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3297), false, 8, new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3301), 1 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3328), false, 5, new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3337), 6 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3363), 20, new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3368), 17 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3399), true, 16, new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3403), 15 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3430), 2, new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3439), 8 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3466), false, 11, new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3470), 5 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3497), false, 17, new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3506), 4 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3532), 14, new DateTime(2019, 6, 18, 1, 34, 0, 398, DateTimeKind.Local).AddTicks(3537), 18 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 36, DateTimeKind.Local).AddTicks(2811), "https://s3.amazonaws.com/uifaces/faces/twitter/krystalfister/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4415), "https://s3.amazonaws.com/uifaces/faces/twitter/franciscoamk/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4477), "https://s3.amazonaws.com/uifaces/faces/twitter/magugzbrand2d/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4481) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4508), "https://s3.amazonaws.com/uifaces/faces/twitter/sementiy/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4539), "https://s3.amazonaws.com/uifaces/faces/twitter/peterlandt/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4543) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4566), "https://s3.amazonaws.com/uifaces/faces/twitter/gipsy_raf/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4592), "https://s3.amazonaws.com/uifaces/faces/twitter/jamiebrittain/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4623), "https://s3.amazonaws.com/uifaces/faces/twitter/Silveredge9/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4650), "https://s3.amazonaws.com/uifaces/faces/twitter/rangafangs/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4677), "https://s3.amazonaws.com/uifaces/faces/twitter/snowshade/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4708), "https://s3.amazonaws.com/uifaces/faces/twitter/agromov/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4739), "https://s3.amazonaws.com/uifaces/faces/twitter/danvernon/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4766), "https://s3.amazonaws.com/uifaces/faces/twitter/betraydan/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4792), "https://s3.amazonaws.com/uifaces/faces/twitter/d_kobelyatsky/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4823), "https://s3.amazonaws.com/uifaces/faces/twitter/wearesavas/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4850), "https://s3.amazonaws.com/uifaces/faces/twitter/allfordesign/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4877), "https://s3.amazonaws.com/uifaces/faces/twitter/thatonetommy/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4908), "https://s3.amazonaws.com/uifaces/faces/twitter/kaelifa/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4935), "https://s3.amazonaws.com/uifaces/faces/twitter/danro/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4961), "https://s3.amazonaws.com/uifaces/faces/twitter/jerrybai1907/128.jpg", new DateTime(2019, 6, 18, 1, 34, 0, 37, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(374), "https://picsum.photos/640/480/?image=373", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(1841), "https://picsum.photos/640/480/?image=177", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(1890), "https://picsum.photos/640/480/?image=1056", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(1921), "https://picsum.photos/640/480/?image=100", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(1952), "https://picsum.photos/640/480/?image=712", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(1997), "https://picsum.photos/640/480/?image=27", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2028), "https://picsum.photos/640/480/?image=755", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2054), "https://picsum.photos/640/480/?image=750", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2086), "https://picsum.photos/640/480/?image=816", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2117), "https://picsum.photos/640/480/?image=143", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2143), "https://picsum.photos/640/480/?image=805", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2174), "https://picsum.photos/640/480/?image=728", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2206), "https://picsum.photos/640/480/?image=256", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2232), "https://picsum.photos/640/480/?image=940", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2263), "https://picsum.photos/640/480/?image=955", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2294), "https://picsum.photos/640/480/?image=591", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2321), "https://picsum.photos/640/480/?image=705", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2361), "https://picsum.photos/640/480/?image=286", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2392), "https://picsum.photos/640/480/?image=171", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2423), "https://picsum.photos/640/480/?image=439", new DateTime(2019, 6, 18, 1, 34, 0, 44, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(5656), true, 3, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(6585), 20 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(7652), 3, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(7670), 13 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(7714), true, 17, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(7718), 5 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(7750), false, 9, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(7758), 6 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(7785), 15, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(7821), 15, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(7825), 13 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(7856), 19, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(7861), 15 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(7887), 12, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(7892), 13 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(7954), 1, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(7958), 21 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(7990), true, 1, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(7994), 18 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8025), true, 14, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8030), 17 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8061), true, 2, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8123), 3 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8158), false, 9, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8163), 15 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8194), false, 6, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8198), 2 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8225), false, 6, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8234), 3 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8261), true, 2, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8265), 7 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8296), 1, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8301), 18 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8327), true, 13, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8336), 21 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8363), 7, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8367), 16 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8398), 13, new DateTime(2019, 6, 18, 1, 34, 0, 388, DateTimeKind.Local).AddTicks(8403), 16 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "Qui libero voluptatem voluptate occaecati assumenda.", new DateTime(2019, 6, 18, 1, 34, 0, 364, DateTimeKind.Local).AddTicks(216), 25, new DateTime(2019, 6, 18, 1, 34, 0, 364, DateTimeKind.Local).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "Officiis reprehenderit tempora repellat ea nihil et. Dolorum omnis quaerat et et consectetur consectetur aliquid et. Maiores illo cupiditate nihil quia.", new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(3950), 32, new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, "deserunt", new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(5870), 31, new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, "rerum", new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(6172), 31, new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "Itaque id id fugiat. Autem aut quisquam eos accusamus incidunt eius sit. Voluptatem vel dolorem eaque voluptatibus ipsum. Facilis illo laboriosam fugit. Ipsum ducimus dolores quo laudantium. Quam tenetur esse.", new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(7101), 27, new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "reprehenderit", new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(7216), 35, new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, "Architecto fugiat autem non incidunt at.", new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(7465), 37, new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, "Animi ab nostrum omnis voluptatem porro ullam dolorum ea qui.", new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(7696), 29, new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, "et", new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(8074), 28, new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, "qui", new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(8181), 34, new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "Cumque quia reiciendis molestias quod.", new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(8376), 24, new DateTime(2019, 6, 18, 1, 34, 0, 365, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, @"Neque dolor illum et quia omnis voluptate odio explicabo odit.
Ut perferendis libero nam in fugiat incidunt.
Nobis illo et et sit ut dicta in facere.", new DateTime(2019, 6, 18, 1, 34, 0, 366, DateTimeKind.Local).AddTicks(456), 40, new DateTime(2019, 6, 18, 1, 34, 0, 366, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, @"Iusto et asperiores voluptatibus rem.
Et id tempora omnis qui qui et adipisci nemo nulla.
Voluptatem impedit quod fuga.
Excepturi unde atque iste eaque amet et laudantium rerum nihil.
Dolorum in molestiae tempore deserunt ea aliquid est hic.", new DateTime(2019, 6, 18, 1, 34, 0, 366, DateTimeKind.Local).AddTicks(892), 37, new DateTime(2019, 6, 18, 1, 34, 0, 366, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, "Unde necessitatibus ut voluptates consequatur eum aut.", new DateTime(2019, 6, 18, 1, 34, 0, 366, DateTimeKind.Local).AddTicks(1012), 21, new DateTime(2019, 6, 18, 1, 34, 0, 366, DateTimeKind.Local).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "Dignissimos dolores repudiandae voluptas illo vitae voluptas est.", new DateTime(2019, 6, 18, 1, 34, 0, 366, DateTimeKind.Local).AddTicks(1145), 35, new DateTime(2019, 6, 18, 1, 34, 0, 366, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "et", new DateTime(2019, 6, 18, 1, 34, 0, 366, DateTimeKind.Local).AddTicks(1194), 38, new DateTime(2019, 6, 18, 1, 34, 0, 366, DateTimeKind.Local).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, @"Magni cum fugit voluptate veritatis.
Aut ratione et maxime expedita sed qui placeat delectus beatae.
Tempora explicabo dignissimos molestias iste et veritatis dolores.
Facilis consequatur enim eum id incidunt accusamus et saepe.
Iure quia eum laborum et eligendi dolores laboriosam odit corrupti.
Non numquam ut sit rerum.", new DateTime(2019, 6, 18, 1, 34, 0, 366, DateTimeKind.Local).AddTicks(1518), 30, new DateTime(2019, 6, 18, 1, 34, 0, 366, DateTimeKind.Local).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Ab repudiandae nostrum et rerum officiis sed consequatur nihil. Fugiat at voluptatibus est. Nulla deleniti ut vel quam non. Consequatur quas iusto sequi minus sed temporibus placeat ex assumenda. Quia suscipit voluptate explicabo quis.", new DateTime(2019, 6, 18, 1, 34, 0, 366, DateTimeKind.Local).AddTicks(1803), 26, new DateTime(2019, 6, 18, 1, 34, 0, 366, DateTimeKind.Local).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, @"Labore et ex incidunt pariatur consequatur aut alias.
Aperiam sequi minima aspernatur voluptates repellendus consequatur corrupti qui suscipit.
Tempore saepe et sed.", new DateTime(2019, 6, 18, 1, 34, 0, 366, DateTimeKind.Local).AddTicks(1954), 37, new DateTime(2019, 6, 18, 1, 34, 0, 366, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "Enim asperiores dolorem. Enim voluptas quasi beatae. Aut qui est placeat vel id neque saepe labore dolores. Natus omnis cum voluptatem fugit. Ut consequatur qui. Dolores quo aliquid necessitatibus cumque eaque.", new DateTime(2019, 6, 18, 1, 34, 0, 366, DateTimeKind.Local).AddTicks(2198), 27, new DateTime(2019, 6, 18, 1, 34, 0, 366, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2019, 6, 18, 1, 34, 0, 90, DateTimeKind.Local).AddTicks(4926), "Bettie.Watsica42@hotmail.com", "oSVpQATzIlhoqd0GxrpMSaVW32st0gsb4UCTqJHWW9w=", "O+P0+Fk0YORSgHmhQfqX54wANzkVFRAKWjVnfmTCNXk=", new DateTime(2019, 6, 18, 1, 34, 0, 90, DateTimeKind.Local).AddTicks(6912), "Flavio.Blick10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 12, new DateTime(2019, 6, 18, 1, 34, 0, 109, DateTimeKind.Local).AddTicks(4282), "Dolores_Hane85@yahoo.com", "o0xI9+zROaYc8ogVwwUNEHRx2dolcQvz5RrGJ34vx0w=", "ybUxO9C7kq7U5UIthkMOKmI4NEU6ZzsEM6qNGF9/2zA=", new DateTime(2019, 6, 18, 1, 34, 0, 109, DateTimeKind.Local).AddTicks(4327), "Lizzie87" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2019, 6, 18, 1, 34, 0, 121, DateTimeKind.Local).AddTicks(2953), "Estefania.Jacobi67@gmail.com", "/WzLbfkMv/C7IHL98yRqFSU2EQN/9y/IKbt5+NvOazw=", "5GNkvsFuce/tfRfqhE2SHQvwqUIWTVCLw9pzx8DTWAA=", new DateTime(2019, 6, 18, 1, 34, 0, 121, DateTimeKind.Local).AddTicks(2993), "Deondre_Schroeder" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2019, 6, 18, 1, 34, 0, 139, DateTimeKind.Local).AddTicks(6433), "Selmer_McGlynn7@hotmail.com", "qmdhvUvrNngEy/VtbviKmghlD6qx5UXTZ58WJenmsB8=", "21b/CW/7F6VkZz+MLpx7evK+22+8gXI0d9ZLSmwbGM0=", new DateTime(2019, 6, 18, 1, 34, 0, 139, DateTimeKind.Local).AddTicks(6486), "Korbin_Prohaska" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2019, 6, 18, 1, 34, 0, 159, DateTimeKind.Local).AddTicks(1006), "Odie_MacGyver78@yahoo.com", "i7yBUoPs2s+4emNFnr71rXMLu9hxTLXIukS2z6OBVpY=", "c2TKMKo1yhrFF2fw3IzooXqRghePg5A+iXT/StlbvMo=", new DateTime(2019, 6, 18, 1, 34, 0, 159, DateTimeKind.Local).AddTicks(1055), "Trisha.Kautzer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2019, 6, 18, 1, 34, 0, 171, DateTimeKind.Local).AddTicks(7891), "Cesar.Schroeder@yahoo.com", "s+no5+tL6Jb2Hgl4ITc+r8ISOdyjm6lervj3aZC3+Mo=", "6PgHF+A6OjOulq1dzdKDI0xckkKVBDKBfvG5s954kRI=", new DateTime(2019, 6, 18, 1, 34, 0, 171, DateTimeKind.Local).AddTicks(7931), "Jalon_Prohaska" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2019, 6, 18, 1, 34, 0, 189, DateTimeKind.Local).AddTicks(7593), "Kenyon.Adams9@yahoo.com", "7QagstgBaLri8nBd9OAkMn/4Z2JsnV4qmWKI4wuXPVE=", "iPpx0wJQpyGkkAszAiLbjBEeD6Nvoin8fVbOT3mxi3k=", new DateTime(2019, 6, 18, 1, 34, 0, 189, DateTimeKind.Local).AddTicks(7642), "Amari_Swaniawski1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2019, 6, 18, 1, 34, 0, 204, DateTimeKind.Local).AddTicks(8567), "Pietro.Pfeffer37@hotmail.com", "N71JMWv40svAzmNmNYXgtgwoGO5Y0Jvy76H6gz8FxS4=", "VQiQPwFMUNc8sD+0/pegvafIgQ3lzOo/oC7GIN2I6ys=", new DateTime(2019, 6, 18, 1, 34, 0, 204, DateTimeKind.Local).AddTicks(8616), "Kenya63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2019, 6, 18, 1, 34, 0, 222, DateTimeKind.Local).AddTicks(8105), "Georgiana79@yahoo.com", "3hkFCXqAd5BmrqypCollgvA0EO7Oz5SIe0HQX+Q+6sE=", "hN/QdNuJWkZkNWLZFtqpvzxTSQzqSUbmrJENfYuq9d0=", new DateTime(2019, 6, 18, 1, 34, 0, 222, DateTimeKind.Local).AddTicks(8140), "Mathias.Jenkins" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2019, 6, 18, 1, 34, 0, 235, DateTimeKind.Local).AddTicks(5967), "Corine_Ernser70@yahoo.com", "/UW94zXMjfJM0/2O+VuJevuFPXBjG5B0v88yEpJiEdc=", "HnF3irXR8tDY5kJrK268w7LP5o5oD029j8qWAmCf5hc=", new DateTime(2019, 6, 18, 1, 34, 0, 235, DateTimeKind.Local).AddTicks(6007), "Dorothy96" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2019, 6, 18, 1, 34, 0, 245, DateTimeKind.Local).AddTicks(9891), "Francisca_Herzog@hotmail.com", "yWCidwkWYJoubzObjIkAgT5F4uor5X3lU0rmSJq0k7A=", "Drp57WQpos5FL2l0ElyKB/9zEWPQ1Ev9kCaox27mW/w=", new DateTime(2019, 6, 18, 1, 34, 0, 245, DateTimeKind.Local).AddTicks(9927), "Cordie.Corkery93" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2019, 6, 18, 1, 34, 0, 257, DateTimeKind.Local).AddTicks(962), "Vida_Walsh@hotmail.com", "txjde3C3SWo7qcl5VL+F4sGMn30NJUxCvO0ZM5mvYFg=", "8z/SzfFbKRuNv12iYiJx6qwmUr7BH9IGV/pxaY5NaH4=", new DateTime(2019, 6, 18, 1, 34, 0, 257, DateTimeKind.Local).AddTicks(1002), "Ramon_Boyle" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 12, new DateTime(2019, 6, 18, 1, 34, 0, 268, DateTimeKind.Local).AddTicks(1518), "Brady_Tromp78@yahoo.com", "akyffyBNY83j/W8nTmrpWBEqYEE4YwvjtNoFE9SDKqA=", "HCDX0U00laG8jf6OjGl5ciWLQIqoWkeEbLpRw/EHIwY=", new DateTime(2019, 6, 18, 1, 34, 0, 268, DateTimeKind.Local).AddTicks(1553), "Kayleigh_Romaguera" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 6, 18, 1, 34, 0, 279, DateTimeKind.Local).AddTicks(2967), "Sarah44@gmail.com", "zBMYEoKz/5iBncOgRwEN4PJVE+5ra1qleuVL5CUs9CA=", "9kth6j8r87I3zVFqW7CqRWN1YbIc4GcgeZWT+r24swY=", new DateTime(2019, 6, 18, 1, 34, 0, 279, DateTimeKind.Local).AddTicks(3002), "Zoie_Fay" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2019, 6, 18, 1, 34, 0, 289, DateTimeKind.Local).AddTicks(6234), "Lexie55@gmail.com", "JPrFsEuO7DTFUMRnP/b1ghTtczc0gS7dg/XoDeXsVsE=", "ufR1slDJyOHXQdC87oBOM3gxSh9Gsi+/Zs2AXUrooyY=", new DateTime(2019, 6, 18, 1, 34, 0, 289, DateTimeKind.Local).AddTicks(6261), "Dax.Koch4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2019, 6, 18, 1, 34, 0, 299, DateTimeKind.Local).AddTicks(9989), "Pansy.Stroman40@yahoo.com", "PbY7tjchzTtoT7dUVh68DgtpVZLw1M9pqWgHy2JPy5I=", "k6j0OhvwQqLE+vq53sBrVvP2E4Y3W5ftabxr7OyKsf0=", new DateTime(2019, 6, 18, 1, 34, 0, 300, DateTimeKind.Local).AddTicks(25), "Jerald_Ullrich" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2019, 6, 18, 1, 34, 0, 310, DateTimeKind.Local).AddTicks(5434), "Katarina.Harvey91@yahoo.com", "ex0f1xsRPvdoUapTBcXrdDaznz+eHElYES+rmFrpQHk=", "L+jYFQeposS9vgxhruiSqIzdNDHkYDT3Tm8N+L3oKeg=", new DateTime(2019, 6, 18, 1, 34, 0, 310, DateTimeKind.Local).AddTicks(5470), "Pink.Bartoletti" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2019, 6, 18, 1, 34, 0, 320, DateTimeKind.Local).AddTicks(6434), "Garrison_Gutkowski@gmail.com", "k02qcQYNMIZn+nnGgEqmNy70UMBJFQipuzjN8Inb/j4=", "isu7YmY2oTeB3Xs8GGoTI9a4wazb3gEVefO/u8kU75Y=", new DateTime(2019, 6, 18, 1, 34, 0, 320, DateTimeKind.Local).AddTicks(6452), "Garrick60" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2019, 6, 18, 1, 34, 0, 330, DateTimeKind.Local).AddTicks(8447), "Dayna.Littel0@yahoo.com", "kcRfWwp+hIGxz0USVmZmoTxfdkxAotosGCuT2NOBlPE=", "NTCelS1VZpJ/Ca7ex73p/75UUFBIX5L5zdnBtK91urU=", new DateTime(2019, 6, 18, 1, 34, 0, 330, DateTimeKind.Local).AddTicks(8474), "Adolph.Oberbrunner21" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2019, 6, 18, 1, 34, 0, 340, DateTimeKind.Local).AddTicks(9181), "Earnest.Leffler@yahoo.com", "BujIDR7vP9qLBP89kh0VkJwSjND061zRkjiJYwHAsAE=", "atVLAClbpmnL6XtdaYs4WVTMbLgEKMNxkOo1htFpBeA=", new DateTime(2019, 6, 18, 1, 34, 0, 340, DateTimeKind.Local).AddTicks(9198), "Danyka_Green51" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 34, 0, 351, DateTimeKind.Local).AddTicks(1470), "8Qf0gaPQAbvgRwjcEqu8epTOtlZ0eitQC90+PJVxBpQ=", "Y19vu0hxvQBfQWMiJn5/6c4q5UwubPqL75Epiw1Quzg=", new DateTime(2019, 6, 18, 1, 34, 0, 351, DateTimeKind.Local).AddTicks(1470) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 8, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(7669), new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(8696), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 9, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9651), true, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9665), 21 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 16, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9709), new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9718), 15 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 19, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9749), true, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9753), 10 });

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
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9851), new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9856), 8 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 6, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9882), new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9887), 14 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 19, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9918), false, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9922), 2 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9949), false, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 14, new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9985), new DateTime(2019, 6, 18, 1, 17, 5, 202, DateTimeKind.Local).AddTicks(9989), 17 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 6, new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(16), true, new DateTime(2019, 6, 18, 1, 17, 5, 203, DateTimeKind.Local).AddTicks(20), 13 });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Omnis soluta delectus est distinctio accusantium a.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4917), 8, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(4922) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Quia aut natus nemo iusto accusamus voluptatibus libero.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5268), 18, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Illum possimus quia omnis.", new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5331), 2, new DateTime(2019, 6, 18, 1, 17, 5, 171, DateTimeKind.Local).AddTicks(5335) });

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
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(3571), false, 5, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(4575), 2 });

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
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5722), true, 3, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5726), 8 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5757), false, 13, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5762), 14 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5788), new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5793), 6 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5824), true, 3, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5828), 5 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5855), new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5860), 19 });

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
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5926), 7, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5931), 13 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5962), true, 2, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5966), 10 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(5993), true, 12, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6002), 7 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6028), 4, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6033), 4 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6068), false, 19, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6073), 1 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6104), 18, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6108), 14 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6135), true, 19, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6140), 13 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "IsDisLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6171), true, 16, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6175), 16 });

            migrationBuilder.UpdateData(
                table: "DisPostReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6202), 20, new DateTime(2019, 6, 18, 1, 17, 5, 193, DateTimeKind.Local).AddTicks(6211), 17 });

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
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(1366), false, 18, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(2291), 17 });

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
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3597), true, 11, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3606), 8 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3633), 2, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3642) });

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
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3704), 14, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3713), 18 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3740), 7, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3744), 9 });

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
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3900), false, 5, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3904), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3935), false, 16, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(3940), 13 });

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
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4002), true, 5, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4006), 9 });

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
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4069), false, 8, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4073), 19 });

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
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4140), false, 1, new DateTime(2019, 6, 18, 1, 17, 5, 183, DateTimeKind.Local).AddTicks(4144), 8 });

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
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "Aut qui corrupti sed vel.", new DateTime(2019, 6, 18, 1, 17, 5, 160, DateTimeKind.Local).AddTicks(7433), 35, new DateTime(2019, 6, 18, 1, 17, 5, 160, DateTimeKind.Local).AddTicks(7438) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, "Sapiente qui id dolore assumenda pariatur deserunt et. Voluptas unde quos inventore et consequatur et ea maxime dolores. Quibusdam excepturi quisquam debitis id dolorem nesciunt numquam est incidunt. Earum impedit beatae vitae sed.", new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(2971), 21, new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(2980) });

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
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "vitae", new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(3495), 23, new DateTime(2019, 6, 18, 1, 17, 5, 161, DateTimeKind.Local).AddTicks(3500) });

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
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2019, 6, 18, 1, 17, 5, 63, DateTimeKind.Local).AddTicks(6535), "Toby_Berge@gmail.com", "QbiRzT8kVnbfxUKIY5yH/nGtCl1alH90ifNNlUIkmnY=", "VuMUWjd4OONmiuejGtZ10O9ewFNE83qcqdXbGDsj8Ls=", new DateTime(2019, 6, 18, 1, 17, 5, 63, DateTimeKind.Local).AddTicks(6571), "Dane_Heidenreich82" });

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
        }
    }
}
