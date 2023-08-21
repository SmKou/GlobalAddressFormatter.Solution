# Global Address Formatter

By: Thomas Bakken, Stella Marie, Allie Zhao

## Technologies Used
- C# 12
- ASP.NET Core 7
  - EntityFrameworkCore (API)
  - MySQL
  - RestSharp
  - Newtonsoft.Json

## Description

GlobalAddressFormatter is a web app and api for formatting postal addresses for sending mail and packages abroad. Anyone can use the form to format addresses.

### Samples

Format Link: https://en.wikipedia.org/wiki/Address
Format Link: http://www.columbia.edu/~fdc/postal/

Australia
- General format:
    - LINE 1: `{recipient name} OR {business name}`
    - LINE 1.5: `{recipient name IF applicable and business name on line 1}`
    - LINE 2: `{street number} {street name} OR {PO Box} OR {Locked Bag number}`
    - LINE 3: `{locality or suburb}, {state}, {post code} (all in capitals)`

[Source](https://auspost.com.au/sending/check-sending-guidelines/addressing-guidelines)

Bangladesh
- Urban format:
    - LINE 1: `{Addressee (person or organization)}`
    - LINE 1.5: `{Addressee details (optional)}`
    - LINE 2: `{flat number}, {building name} (if applicable)`
    - LINE 3: `{street name and number}`
    - LINE 4: `{town}+{4-digit postal code}`
    - LINE 5: `{country (for international mail)}`
- Rural format:
    - LINE 1: `{Addressee name}`
    - LINE 1.5: `{Addressee details (optional)}`
    - LINE 2: `Village: {village name}`
    - LINE 3: `P.O.: {post office}`
    - LINE 4: `Thana: {thana name}`
    - LINE 5: `District: {district name}`
    - LINE 6: `{country (international mail only)}`

[Source](https://en.wikipedia.org/wiki/Address#Bangladesh)

Chile
- Larger city format (for cities that extend through multiple municipalities):
    - LINE 1: `{Addressee (person or organization)}`
    - LINE 2: `{street name} {number}, {apt. number (if applicable)}`
    - LINE 3: `{postal code (optional)} {municipality}`
    - LINE 4: `{region}`
- Smaller city format (for cities only in one municipality):
    - LINE 1: `{Addressee (person or organization)}`
    - LINE 2: `{street name} {number}, {apt. number (if applicable)}`
    - LINE 3: `{neighborhood}`
    - LINE 4: `{region}`
- Rural format (for rural municipalities):
    - LINE 1: `{Addressee (person or organization)}`
    - LINE 2: `{street name} {number}, {apt. number (if applicable)}`
    - LINE 3: `{postal code} {town or village}`
    - LINE 4: `{region}`
- House number-less format (for primarily rural communities that don't use individual building/house numbers):
    - LINE 1: `{Addressee (person or organization)}`
    - LINE 2: `{street name}, {additional address information}`
    - LINE 3: `{postal code} {town or village}`
    - LINE 4: `{region}`

[Source](https://en.wikipedia.org/wiki/Address#Chile)

Greece
- National format (for mail within Greece):
    - LINE 1: `{Recipient}`
    - LINE 2: `{Street address}`
    - LINE 3: `{post code}, {town}`
- International format (for mail to/from abroad)
    - LINE 1: `{Recipient}`
    - LINE 2: `{Street address}`
    - LINE 3: `{destination country code} {post code}, {town}`

[Source](https://en.wikipedia.org/wiki/Address#Greece)

India
- General address format (for international deliveries)
    - LINE 1: `{Name} {Son/Daughter Of (DO/SO)} OR {Husband/Wife Of (H/O or W/O)} {parent/spouse's name}`
    - LINE 2: `{Door number}`
    - LINE 3: `{Street Number}, {Street Name}`
    - LINE 4: `{VIA NAME (VIA)}`
    - LINE 5: `{Post Name (PO)}`
    - LINE 6: `{Taluk Name (TK)}`
    - LINE 7: `{Locality or Neighbourhood}`
    - LINE 8: `{City} - {Postal Code}`
    - LINE 9: `{District Name}`
    - LINE 10: `{State}`
    - LINE 11: `{Country}`
- Rural address format
    - LINE 1: `{Name}`
    - LINE 2: `{Street number}, {street name}`
    - LINE 3: `{Village name}`
    - LINE 4: `{District name}`
    - LINE 5: `{Postal Code}`
    - LINE 6: `{State}`
- Urban address format
    - LINE 1: `{Name}`
    - LINE 1.5: `{Occupation (optional)}`
    - LINE 2: `{Flat number}, {building name}`
    - LINE 3: `{Street number}, {street name}`
    - LINE 4: `{Locality or neighborhood}`
    - LINE 5: `{Postal Code}`
    - LINE 6: `{State}`

[Source](https://en.wikipedia.org/wiki/Address#India)

United States
- General format (appropriate for most addresses)
    - LINE 1: `{Name of addressee}`
    - LINE 2: `{House number}, {Street name}, {Apartment/Suite/Room number if applicable}`
    - LINE 3: `{Name of post office} {State abbreviation} {ZIP or ZIP+4 code}`

### Web Client
Port: http://localhost:5000/

![structure diagram of application](./struct_diagram.png)

- Home(Index): Form
  - Select country -> retrieve address format
  - View format information: address formats
  - Add fields to enter destination address -> format an address

Appearance:
Select a Country: ______________________________ > API request

* Once api call returns list
| FormatName        | Format (Pattern)          | Description               |
| ----------------- | ------------------------- | ------------------------- |
| {format_name}     | {format_pattern}          | What distinguishes format |

* Once list of formats renders
Select a Format: ________________________________ >

* Once a format is selected => render input fields
FieldName: __________
FieldName: __________

**Sample Request**
Method: GET
URL: http://localhost:6000/formats?country={country}
Action: Returns list of formats.

### Web Api
- ApiController: Countries ```.../countries```
- ApiController: Formats ```.../formats```

| Method    | URL format        | Action                    |
| --------- | ----------------- | ------------------------- |
| GET       | .../countries     | Returns list of countries |
| GET       | .../formats       | Returns list of formats   |

**Queries for: .../formats?**

Parameter: country (country name || countrycode)
Required - Returns list of address formats by country

**Sample Response: /countries**
```json
{
    "countries": [
        { "country_code" : "country_name" }
    ]
}
```

**Sample Response: .../formats?**
```json
{
    "formats": {
        "format_name": {
            "format_pattern" : "{pattern}",
            "fields": [
                "field_name"
            ]
        }
    }
}
```

### Database
Database: Countries > Formats <> FormatFields <> Fields

Tables:
- Countries: Id, FullName, CountryCode
- Formats: Id, CountryId, Name
- FormatFields: Id, FormatId, FieldId
- Fields: Id, Name

Minimal Viable Product Database:
![Enhanced Entity Relationship Diagram](eer_diagram2.png "Green Phase Diagram")

Additional Features Database:
![Enhanced Entity Relationship Diagram](eer_diagram1.png "Yellow Phase Diagram")

### Yellow Features / Could Have (if there's time)
- Deploy on Azure
- Add field types
- Add valid inputs for each field

### Red Features / Won't Have (this time)
- Global address book

## Complete Setup
