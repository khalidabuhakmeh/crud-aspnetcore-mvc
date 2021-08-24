# Basic CRUD with ASP.NET Core MVC

Folks might find controllers, models, views, and viewmodels overwhelming. If you
find yourself struggling, this straightforward sample can help you make
sense of where and when to use certain concepts.

This example shows how an individual may structure their elements to get
the most value out of their setup.

## Some notable techniques

- Every view has a viewmodel. An entity that represents the information we want to display on the client.
- New, Edit, Create, Update endpoints use a variation of `CreateViewModel`
- Use HTTP Methods appropriately (GET, POST, PUT, and DELETE)
- Use `HttpMethodOverride` to support additional methods
- Appropriate use of validation logic and redirects
- Use `form` attributes on deletes to trigger a delete within a table
- Tempdata for flash notifications
