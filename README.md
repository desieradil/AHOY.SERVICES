# AHOY.SERVICES
# 
# Steps to Run the application
# 
# .Net Core Framework with VS 2019
# 
# Implemented https://developers.amadeus.com/enterprise/category/hotel amadeus hotel api
# 
# For booking the hotel you need to pass the object like this below:
# 
# {
  "data": {
    "offerId": "NRPQNQBOJM",
    "guests": [
      {
        "name": {
          "title": "MR",
          "firstName": "BOB",
          "lastName": "SMITH"
        },
        "contact": {
          "phone": "+33679278416",
          "email": "bob.smith@email.com"
        }
      }
    ],
    "payments": [
      {
        "method": "creditCard",
        "card": {
          "vendorCode": "VI",
          "cardNumber": "4111111111111111",
          "expiryDate": "2023-01"
        }
      }
    ]
  }
}

you will get the below confirmation response.

{
  "data": [
    {
      "type": "hotel-booking",
      "id": "XD_8138319951754",
      "providerConfirmationId": "8138319951754",
      "associatedRecords": [
        {
          "reference": "QVH2BX",
          "originSystemCode": "GDS"
        }
      ]
    }
  ]
}
# 
# 
# 
# 
# 
# 
# 
# 
# 
# 
# 
# 
