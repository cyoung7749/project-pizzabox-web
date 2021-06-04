# Pizzabox (Web Application)

## Description
Not impressed with UberEats, DoorDash, GrubHub pizza offerings?
You can now try PizzaBox, the latest food delivery service. 
It is a command line-based application focused on nothing but pizzas.

## technologies

+ .NET Core - C#
+ .NET Core - EF + SQL
+ .NET Core - xUnit
+ ASP.NET Core - MVC
    
## getting started
* Hosted MVC project: https://pizzabox258.azurewebsites.net/
> When using Postgres, Docker Hub is used to host the SQL database
* docker container run -it --rm -d --name {database name} -p 5432:5432 -e POSTGRES_PASSWORD={password} postgres
> Running the application locally: 
* dotnet run Pizzabox.Client/

## usage
* Clicking on the button will redirect to the orders page.  
* You can click on the button or name to select Crust, Size, and Toppings.  
* You must select no less than 2 but no more than 5 toppings.  Failure will 
* Clicking on checkout will redirect the checkout page and display 

