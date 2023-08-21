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

### Sample Formats

### Web Client
Port: http://localhost:5000/

- Home(Index): Form
  - Select country -> retrieve address format
  - View format information: address format and url
  - Add fields to enter destination address -> format an address

**Sample Request**
Method: GET
URL: http://localhost:6000/formats?country={country}
Action: Returns list of formats.

### Web Api
- ApiController: Formats ```.../formats```

| Method    | URL format        | Action                |
| --------- | ----------------- | --------------------- |
| GET       | .../formats       | Returns list of formats
- GET: Get address format (and url)
  ?country={country} => return address information of country

Database: 
- Countries > Formats <> FormatFields <> FieldNames

**Sample Response**
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

**In Consideration**
- Deploy on Azure
- Add field types
- Add valid inputs for each field

##