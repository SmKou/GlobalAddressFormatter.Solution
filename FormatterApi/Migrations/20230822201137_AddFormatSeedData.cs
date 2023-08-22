using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormatterApi.Migrations
{
    /// <inheritdoc />
    public partial class AddFormatSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Formats",
                columns: new[] { "FormatId", "CountryId", "FormatName", "FormatPattern" },
                values: new object[,]
                {
                    { 1, 1, "Australia (general, to street address)", "{business}\n{addressee}\n{street-number} {street-name}\n{locality}, {state}, {postal-code}" },
                    { 2, 1, "Australia (general, to PO Box)", "{business}\n{addressee}\n{PO Box}\n{locality}, {state}, {postal-code}" },
                    { 3, 1, "Australia (general, to Locked Bag)", "{business}\n{addressee}\n{locked-bag-number}\n{locality}, {state}, {postal-code}" },
                    { 4, 2, "Bangladesh (urban)", "{addressee}\n{additional-details}\n{unit}, {building}\n{street-name} {street-number}\n{town}+{postal-code}\n{country}" },
                    { 5, 2, "Bangladesh (rural)", "{addressee}\n{additional-details}\nVillage: {village}\nP.O.:{post-office}\nThana: {thana-name}\n{country}" },
                    { 6, 3, "Chile (multiple municipality city, with unit/apartment number)", "{addressee}\n{street-name} {number}, {unit}\n{postal-code} {municipality}\n{region}" },
                    { 7, 3, "Chile (multiple municipality city, no unit/apartment number)", "{addressee}\n{street-name} {number}\n{postal-code} {municipality}\n{region}" },
                    { 8, 3, "Chile (single municipality city, with unit/apartment number)", "{addressee}\n{street-name} {number}, {unit}\n{neighborhood}\n{region}" },
                    { 9, 3, "Chile (single municipality city, no unit/apartment number)", "{addressee}\n{street-name} {number}\n{neighborhood}\n{region}" },
                    { 10, 3, "Chile (rural, with unit/apartment number)", "{addressee}\n{street-name} {number}, {unit}\n{postal-code} {town}\n{region}" },
                    { 11, 3, "Chile (rural, no unit/apartment number)", "{addressee}\n{street-name} {number}\n{postal-code} {town}\n{region}" },
                    { 12, 3, "Chile (rural, no individual house numbers)", "{addressee}\n{street-name}, {additional-information}\n{postal-code} {town}\n{region}" },
                    { 13, 4, "Greece (non-international mail)", "{addressee}\n{street-address}\n{postal-code}, {town}" },
                    { 14, 4, "Greece (international mail)", "{addressee}\n{street-address}\n{countrycode} {postal-code}, {town}" },
                    { 15, 5, "India (general, international)", "{addressee} {relation} of {relation-name}\n{door-number} {street-number}, {street-name}\nvia {via-name}\n{post-name}\n{taluk-name}\n{locality}\n{city} - {postal-code}\n{district}\n{state}\n{country}" },
                    { 16, 5, "India (rural)", "{addressee}\n{street-number}, {street-name}\n{village}\n{district}\n{postal-code}\n{state}" },
                    { 17, 5, "India (urban)", "{addressee}\n{occupation}\n{unit}, {building}\n{street-number}, {street-name}\n{locality}\n{postal-code}\n{state}" },
                    { 18, 6, "USA (general)", "{addressee}\n{house-number}, {street-name}, {unit}\n{city}, {state} {zipcode}" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Formats",
                keyColumn: "FormatId",
                keyValue: 18);
        }
    }
}
