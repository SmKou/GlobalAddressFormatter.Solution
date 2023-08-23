using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormatterApi.Migrations
{
    /// <inheritdoc />
    public partial class AddFormatFieldSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "FieldId", "FieldName" },
                values: new object[] { 36, "street-address" });

            migrationBuilder.InsertData(
                table: "FormatFields",
                columns: new[] { "FormatFieldId", "FieldId", "FormatId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 5, 5, 1 },
                    { 6, 6, 1 },
                    { 7, 7, 1 },
                    { 8, 1, 2 },
                    { 9, 2, 2 },
                    { 10, 8, 2 },
                    { 11, 6, 2 },
                    { 12, 7, 2 },
                    { 13, 1, 3 },
                    { 14, 2, 3 },
                    { 15, 9, 3 },
                    { 16, 5, 3 },
                    { 17, 6, 3 },
                    { 18, 7, 3 },
                    { 19, 2, 4 },
                    { 20, 10, 4 },
                    { 21, 11, 4 },
                    { 22, 12, 4 },
                    { 23, 4, 4 },
                    { 24, 3, 4 },
                    { 25, 13, 4 },
                    { 26, 7, 4 },
                    { 27, 14, 4 },
                    { 28, 2, 5 },
                    { 29, 10, 5 },
                    { 30, 15, 5 },
                    { 31, 16, 5 },
                    { 32, 17, 5 },
                    { 33, 14, 5 },
                    { 34, 2, 6 },
                    { 35, 4, 6 },
                    { 36, 18, 6 },
                    { 37, 11, 6 },
                    { 38, 7, 6 },
                    { 39, 19, 6 },
                    { 40, 20, 6 },
                    { 41, 2, 7 },
                    { 42, 4, 7 },
                    { 43, 18, 7 },
                    { 44, 7, 7 },
                    { 45, 19, 7 },
                    { 46, 20, 7 },
                    { 47, 2, 8 },
                    { 48, 4, 8 },
                    { 49, 18, 8 },
                    { 50, 11, 8 },
                    { 51, 21, 8 },
                    { 52, 20, 8 },
                    { 53, 2, 9 },
                    { 54, 4, 9 },
                    { 55, 18, 9 },
                    { 56, 21, 9 },
                    { 57, 20, 9 },
                    { 58, 2, 10 },
                    { 59, 4, 10 },
                    { 60, 18, 10 },
                    { 61, 11, 10 },
                    { 62, 7, 10 },
                    { 63, 13, 10 },
                    { 64, 20, 10 },
                    { 65, 2, 11 },
                    { 66, 4, 11 },
                    { 67, 18, 11 },
                    { 68, 7, 11 },
                    { 69, 13, 11 },
                    { 70, 20, 11 },
                    { 71, 2, 12 },
                    { 72, 4, 12 },
                    { 73, 22, 12 },
                    { 74, 7, 12 },
                    { 75, 13, 12 },
                    { 76, 20, 12 },
                    { 77, 2, 13 },
                    { 78, 3, 13 },
                    { 79, 7, 13 },
                    { 80, 13, 13 },
                    { 81, 2, 14 },
                    { 83, 23, 14 },
                    { 84, 7, 14 },
                    { 85, 13, 14 },
                    { 86, 2, 15 },
                    { 87, 24, 15 },
                    { 88, 25, 15 },
                    { 89, 26, 15 },
                    { 90, 3, 15 },
                    { 91, 4, 15 },
                    { 92, 27, 15 },
                    { 93, 28, 15 },
                    { 94, 29, 15 },
                    { 95, 5, 15 },
                    { 96, 30, 15 },
                    { 97, 16, 15 },
                    { 98, 31, 15 },
                    { 99, 32, 15 },
                    { 100, 14, 15 },
                    { 101, 2, 16 },
                    { 102, 3, 16 },
                    { 103, 4, 16 },
                    { 104, 15, 16 },
                    { 105, 31, 16 },
                    { 106, 7, 16 },
                    { 107, 32, 16 },
                    { 108, 2, 17 },
                    { 109, 33, 17 },
                    { 110, 11, 17 },
                    { 111, 12, 17 },
                    { 112, 3, 17 },
                    { 113, 4, 17 },
                    { 114, 5, 17 },
                    { 115, 7, 17 },
                    { 116, 6, 17 },
                    { 117, 2, 18 },
                    { 118, 34, 18 },
                    { 119, 4, 18 },
                    { 120, 11, 18 },
                    { 121, 30, 18 },
                    { 122, 32, 18 },
                    { 123, 35, 18 }
                });

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 1,
                column: "FormatPattern",
                value: "{:business}\n{addressee}\n{street-number} {street-name}\n{locality}, {state}, {postal-code}");

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 2,
                column: "FormatPattern",
                value: "{:business}\n{addressee}\n{po-box}\n{locality}, {state}, {postal-code}");

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 3,
                column: "FormatPattern",
                value: "{:business}\n{addressee}\n{locked-bag-number}\n{locality}, {state}, {postal-code}");

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 4,
                column: "FormatPattern",
                value: "{addressee}\n{:additional-details}\n{unit}, {building}\n{street-name} {street-number}\n{town}+{postal-code}\n{country}");

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 5,
                column: "FormatPattern",
                value: "{addressee}\n{:additional-details}\nVillage: {village}\nP.O.:{post-office}\nThana: {thana-name}\n{country}");

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 6,
                column: "FormatPattern",
                value: "{addressee}\n{street-name} {number}, {unit}\n{:postal-code} {municipality}\n{region}");

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 7,
                column: "FormatPattern",
                value: "{addressee}\n{street-name} {number}\n{:postal-code} {municipality}\n{region}");

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 17,
                column: "FormatPattern",
                value: "{addressee}\n{:occupation}\n{unit}, {building}\n{street-number}, {street-name}\n{locality}\n{postal-code}\n{state}");

            migrationBuilder.InsertData(
                table: "FormatFields",
                columns: new[] { "FormatFieldId", "FieldId", "FormatId" },
                values: new object[] { 82, 36, 14 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "FormatFields",
                keyColumn: "FormatFieldId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 36);

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 1,
                column: "FormatPattern",
                value: "{business}\n{addressee}\n{street-number} {street-name}\n{locality}, {state}, {postal-code}");

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 2,
                column: "FormatPattern",
                value: "{business}\n{addressee}\n{po-box}\n{locality}, {state}, {postal-code}");

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 3,
                column: "FormatPattern",
                value: "{business}\n{addressee}\n{locked-bag-number}\n{locality}, {state}, {postal-code}");

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 4,
                column: "FormatPattern",
                value: "{addressee}\n{additional-details}\n{unit}, {building}\n{street-name} {street-number}\n{town}+{postal-code}\n{country}");

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 5,
                column: "FormatPattern",
                value: "{addressee}\n{additional-details}\nVillage: {village}\nP.O.:{post-office}\nThana: {thana-name}\n{country}");

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 6,
                column: "FormatPattern",
                value: "{addressee}\n{street-name} {number}, {unit}\n{postal-code} {municipality}\n{region}");

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 7,
                column: "FormatPattern",
                value: "{addressee}\n{street-name} {number}\n{postal-code} {municipality}\n{region}");

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 17,
                column: "FormatPattern",
                value: "{addressee}\n{occupation}\n{unit}, {building}\n{street-number}, {street-name}\n{locality}\n{postal-code}\n{state}");
        }
    }
}
