# Currency-Converter


User Stories and Separate Concerns for a Currency Converter in MVC
As a user, I want to...

1. Select currencies:

Choose the currencies I want to convert between from a list or dropdown menu.
Optionally, be able to search for and select specific currencies.
2. Enter an amount:

Enter the amount I want to convert in the source currency.
3. See the converted amount:

View the converted amount in the target currency displayed clearly.
Optionally, see the exchange rate used for the conversion.
4. View historical exchange rates (optional):

See a graph or chart depicting historical exchange rates between the chosen currencies for a specific period.
Separate Concerns:

1. Model:

Currency class (optional): Stores information about each currency (name, code, etc.).
ExchangeRate class (optional): Stores the exchange rate between two currencies for a specific date or time.
2. Controller:

CurrencyController: Handles requests for selecting currencies, entering amounts, and performing conversions.
Optionally, retrieves historical exchange rate data.
3. View:

Converter view: Displays a form for selecting currencies and entering an amount.
Shows the converted amount and optionally the exchange rate used.
HistoricalRates view (optional): Displays a graph or chart representing historical exchange rates.
_Layout view: Provides the overall website layout and navigation.
4. Data Access (Optional):

Implement a data access layer (e.g., using an external API or local database) to retrieve current and historical exchange rate data.
5. Services (Optional):

Implement services for specific tasks like fetching exchange rate data from external APIs, formatting and displaying historical data, or caching frequently accessed data.
This is a basic set of user stories and separate concerns for the Currency Converter. You can extend or modify it based on your specific requirements and desired functionalities.

Here are some additional features you could consider:

Allow users to set a default currency pair.
Support specifying the date for historical exchange rate lookup.
Display additional information about the currencies, such as their symbols or flags.
