using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormatterApi.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "FieldId", "FieldName" },
                values: new object[,]
                {
                    { 1, "business" },
                    { 2, "addressee" },
                    { 3, "street-number" },
                    { 4, "street-name" },
                    { 5, "locality" },
                    { 6, "state" },
                    { 7, "postal-code" },
                    { 8, "po-box" },
                    { 9, "locked-bag-number" },
                    { 10, "additional-details" },
                    { 11, "unit" },
                    { 12, "building" },
                    { 13, "town" },
                    { 14, "country" },
                    { 15, "village" },
                    { 16, "post-office" },
                    { 17, "thana-name" },
                    { 18, "number" },
                    { 19, "municipality" },
                    { 20, "region" },
                    { 21, "neighborhood" },
                    { 22, "additional-information" },
                    { 23, "countrycode" },
                    { 24, "relation" },
                    { 25, "relation-name" },
                    { 26, "door-number" },
                    { 27, "via-name" },
                    { 28, "post-name" },
                    { 29, "taluk-name" },
                    { 30, "city" },
                    { 31, "district" },
                    { 32, "state" },
                    { 33, "occupation" },
                    { 34, "house-number" },
                    { 35, "zipcode" }
                });

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 2,
                column: "FormatPattern",
                value: "{business}\n{addressee}\n{po-box}\n{locality}, {state}, {postal-code}");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 35);

            migrationBuilder.UpdateData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 2,
                column: "FormatPattern",
                value: "{business}\n{addressee}\n{PO Box}\n{locality}, {state}, {postal-code}");
        }
    }
}
