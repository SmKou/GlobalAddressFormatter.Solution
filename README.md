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
"{business}\n{addressee}\n{street-number} {street-name}\n{locality}, {state}, {postal-code}"
"{business}\n{addressee}\n{PO Box}\n{locality}, {state}, {postal-code}"
"{business}\n{addressee}\n{locked-bag-number}\n{locality}, {state}, {postal-code}"
- General format:
    - LINE 1: `{recipient name} OR {business name}`
    - LINE 1.5: `{recipient name IF applicable and business name on line 1}`
    - LINE 2: `{street number} {street name} OR {PO Box} OR {Locked Bag number}`
    - LINE 3: `{locality or suburb}, {state}, {post code} (all in capitals)`

[Source](https://auspost.com.au/sending/check-sending-guidelines/addressing-guidelines)

Bangladesh
"{addressee}\n{additional-details}\n{unit}, {building}\n{street-name} {street-number}\n{town}+{postal-code}\n{country}"
- Urban format:
    - LINE 1: `{Addressee (person or organization)}`
    - LINE 1.5: `{Addressee details (optional)}`
    - LINE 2: `{flat number}, {building name} (if applicable)`
    - LINE 3: `{street name and number}`
    - LINE 4: `{town}+{4-digit postal code}`
    - LINE 5: `{country (for international mail)}`
"{addressee}\n{additional-details}\nVillage: {village}\nP.O.:{post-office}\nThana: {thana-name}\n{country}"
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
"{addressee}\n{street-name} {number}, {unit}\n{postal-code} {municipality}\n{region}"
"{addressee}\n{street-name} {number}\n{postal-code} {municipality}\n{region}"
- Larger city format (for cities that extend through multiple municipalities):
    - LINE 1: `{Addressee (person or organization)}`
    - LINE 2: `{street name} {number}, {apt. number (if applicable)}`
    - LINE 3: `{postal code (optional)} {municipality}`
    - LINE 4: `{region}`
"{addressee}\n{street-name} {number}, {unit}\n{neighborhood}\n{region}"
"{addressee}\n{street-name} {number}\n{neighborhood}\n{region}"
- Smaller city format (for cities only in one municipality):
    - LINE 1: `{Addressee (person or organization)}`
    - LINE 2: `{street name} {number}, {apt. number (if applicable)}`
    - LINE 3: `{neighborhood}`
    - LINE 4: `{region}`
"{addressee}\n{street-name} {number}, {unit}\n{postal-code} {town}\n{region}"
"{addressee}\n{street-name} {number}\n{postal-code} {town}\n{region}"
- Rural format (for rural municipalities):
    - LINE 1: `{Addressee (person or organization)}`
    - LINE 2: `{street name} {number}, {apt. number (if applicable)}`
    - LINE 3: `{postal code} {town or village}`
    - LINE 4: `{region}`
"{addressee}\n{street-name}, {additional-information}\n{postal-code} {town}\n{region}"
- House number-less format (for primarily rural communities that don't use individual building/house numbers):
    - LINE 1: `{Addressee (person or organization)}`
    - LINE 2: `{street name}, {additional address information}`
    - LINE 3: `{postal code} {town or village}`
    - LINE 4: `{region}`

[Source](https://en.wikipedia.org/wiki/Address#Chile)

Greece
"{addressee}\n{street-address}\n{postal-code}, {town}"
- National format (for mail within Greece):
    - LINE 1: `{Recipient}`
    - LINE 2: `{street} {number}`
    - LINE 3: `{post code}, {town}`
"{addressee}\n{street-address}\n{countrycode} {postal-code}, {town}"
- International format (for mail to/from abroad)
    - LINE 1: `{Recipient}`
    - LINE 2: `{Street address}`
    - LINE 3: `{destination country code} {post code}, {town}`

[Source](https://en.wikipedia.org/wiki/Address#Greece)

India
"{addressee} {relation} of {relation-name}\n{door-number} {street-number}, {street-name}\nvia {via-name}\n{post-name}\n{taluk-name}\n{locality}\n{city} - {postal-code}\n{district}\n{state}\n{country}"
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
"{addressee}\n{street-number}, {street-name}\n{village}\n{district}\n{postal-code}\n{state}"
- Rural address format
    - LINE 1: `{Name}`
    - LINE 2: `{Street number}, {street name}`
    - LINE 3: `{Village name}`
    - LINE 4: `{District name}`
    - LINE 5: `{Postal Code}`
    - LINE 6: `{State}`
"{addressee}\n{occupation}\n{unit}, {building}\n{street-number}, {street-name}\n{locality}\n{postal-code}\n{state}"
- Urban address format
    - LINE 1: `{Name}`
    - LINE 1.5: `{Occupation (optional)}`
    - LINE 2: `{Flat number}, {building name}`
    - LINE 3: `{Street number}, {street name}`
    - LINE 4: `{Locality or neighborhood}`
    - LINE 5: `{Postal Code}`
    - LINE 6: `{State}`

[Source](https://en.wikipedia.org/wiki/Address#India)

United States:
"{addressee}\n{house-number}, {street-name}, {unit}\n{city}, {state} {zipcode}"
- General format (appropriate for most addresses)
    - LINE 1: `{Name of addressee}`
    - LINE 2: `{House number}, {Street name}, {Apartment/Suite/Room number if applicable}`
    - LINE 3: `{Name of post office} {State abbreviation} {ZIP or ZIP+4 code}`

<!--
Add : in front of field names in pattern that are optional
-->

### Web Client
Port: http://localhost:5000/

![structure diagram of application](./struct_diagram.png)

- Home(Index): Form
  - Select country -> retrieve address format
  - View format information: address formats
  - Add fields to enter destination address -> format an address

<!-- Modification:
AddressFormatter (class) = Tracking object for view
-->

### Client Appearance
Select a Country: ______________________________ > API request

**Sample Request**
Method: GET
URL: http://localhost:6000/formats?country={country}
Action: Returns list of formats.

<!-- Modification: 
1. Table values too long for shorter/smaller screens
2. Adjust to list req. hiding in collapsible element (details) or removing upon selection
3. Add button to listings to select format
4. ASP.NET Core event handlers cannot create elements and append to page (server-side)

Mod 2: Prefer collapsible element so user can change their mind and select another format (when they press a select format button, close the details with js)

* Once api call returns list
| FormatName        | Format (Pattern)          | Description               |
| ----------------- | ------------------------- | ------------------------- |
| {format_name}     | {format_pattern}          | What distinguishes format |

* Once list of formats renders
Select a Format: ________________________________ >

* Once a format is selected => render input fields
FieldName: __________
FieldName: __________
-->

* Once api call returns list
Select a format from below:

**Format:** ReformattedName(format_name)
- **Pattern:** {format_pattern}
- **Description:** {description}
Button (id=format_name): Select this Format

* Once format selected
Form:
FieldName: _____________
FieldName: _____________

* Submit form with fields
Show formatted address

<!--
Serialized model:
{
    "CountryCode": "",
    "Formats": [
        {
            "FormatName": "",
            "Pattern": "",
            "Description": "",
            "Fields": [
                "",
                ...
            ]
        },
        ...
    ],
    "Pattern": "",
    "Fields": {
        "FieldName": "",
        ...
    }
}
- CountryCode provided by dropdown and controller method SetCountry
- Formats provided by API call with CountryCode
- Pattern set when select format button pressed
- Fields set when select format button pressed

Formatting the address:
1. Get form data and set values to keys in Fields (model)
2. Parse pattern on \n to get lines
3. Parse each line on {} giving field_names and string pieces
4. Construct address: field_names => Fields["{field_name}"] + string pieces...
5. Display address
-->

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
- Countries: CountryId, CountryName, CountryCode
- Formats: FormatId, CountryId, FormatName, Description, Pattern
- FormatFields: FormatFieldId, FormatId, FieldId
- Fields: FieldId, FieldName

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

This app requires use of a database. It is suggested to use migrations for ensuring the smooth setup of the sample data for running the project.

### Database Schemas

To setup the database, follow the directions in [Connecting the Database](#connecting-the-database) and then implement migrations as detailed in [Migrations](#migrations).

### Connecting the Database

In your IDE:
- Create a file in the root of the assembly: appsettings.json
  - Do not remove the mention of this file from .gitignore
- Add this code:

```json
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=[hostname];Port=[port_number];database=[database_name];uid=[username];pwd=[password]"
    }
}
```

Replace the values accordingly and brackets are not to be included.

### Migrations

- In the terminal, run ```dotnet build --project AssemblyName```
  - Or navigate into the assembly subdirectory of the project and run ```dotnet build```

This command will install the necessary dependencies. For it to work though, appsettings.json should already be setup. As migrations are included in the clone or fork, you should only need to run:

```dotnet ef database update```

However, since the models are already set up, if update does not work, then do:

```bash
dotnet ef migrations add Initial
dotnet ef database update
```

### Run the App

Required:
- Database created with migrations
- Connection string in appsettings.json

- Navigate to main page of repo
- Either fork or clone project to local directory
- Bash or Terminal: ```dotnet run --project AssemblyName```
  - If you navigate into the main assembly, use ```dotnet run```

This project consists of both a client app and an api. First run the api, which will run on port 6000, then run the client, which will run on port 5000.

```bash
dotnet run --project FormatterApi
```

```bash
dotnet run --project FormatterClient
```

If the app does not launch in the browser:
- Run the app
- Open a browser
- Enter the url: http://localhost:5000/

## Known Bugs

Please report any issues in using the app.

- Swagger documentation

## License

[MIT](https://choosealicense.com/licenses/mit/) T. Bakken, S. Marie, A. Zhao