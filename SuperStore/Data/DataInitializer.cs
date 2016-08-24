using SuperStore.Models;
using System;
using System.Collections.Generic;

namespace SuperStore.Data
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var departments = new List<Department>
                {
                    new Department{Name="Human Resources"},
                    new Department{Name="Marketing"},
                    new Department{Name="Sales"},
                    new Department{Name="Retail"},
                    new Department{Name="Customer Service"},
                    new Department{Name="Marketing"}
                };
            departments.ForEach(d => context.Departments.Add(d));
            context.SaveChanges();

            var employees = new List<Employee>
                {
                    new Employee{FirstName="Carson",LastName="Alexander",DepartmentId= 1,HireDate=DateTime.Parse("2005-09-01")},
                    new Employee{FirstName="Meredith",LastName="Alonso",DepartmentId=5,HireDate=DateTime.Parse("2002-09-01")},
                    new Employee{FirstName="Arturo",LastName="Anand",DepartmentId=2,HireDate=DateTime.Parse("2003-09-01")},
                    new Employee{FirstName="Gytis",LastName="Barzdukas",DepartmentId=2,HireDate=DateTime.Parse("2002-09-01")},
                    new Employee{FirstName="Yan",LastName="Li",DepartmentId=3,HireDate=DateTime.Parse("2002-09-01")},
                    new Employee{FirstName="Peggy",LastName="Justice",DepartmentId=4,HireDate=DateTime.Parse("2001-09-01")},
                    new Employee{FirstName="Laura",LastName="Norman",DepartmentId=4,HireDate=DateTime.Parse("2003-09-01")},
                    new Employee{FirstName="Nino",LastName="Olivetto",DepartmentId=5,HireDate=DateTime.Parse("2005-09-01")}
                };

            employees.ForEach(e => context.Employees.Add(e));
            context.SaveChanges();

            var products = new List<Product>
                {
                    new Product { Name="Minecraft - Motion Movie Set - Multi", Sku="4570112", Inventory=3, Price=32.99m, Description="Lets your child create stop-motion movies based on the Minecraft universe; movie stage; 4 backgrounds; 4 mini figures; phone/tablet holder; downloadable mobile app; suitable for ages 8 and up"},
                    new Product { Name="Mattel - Ker Plunk! Game", Sku="3988833", Inventory=5, Price=6.99m, Description="In this classic game of skill, you're trying not to lose your marbles."},
                    new Product { Name="Urban Dictionary - The Game - Purple", Sku="5067000", Inventory=7, Price=19.99m, Description="based on a popular website; for age 18+; for 3-8 players; includes 330 word cards, 81 prompt cards"},
                    new Product { Name="Hasbro - Marvel Avengers Hulk Gamma Grip Fists - Green", Sku="4544313", Inventory=2, Price=18.99m, Description="Includes 2 grip fists; grip-and-grab design; ages 4 years and up"},
                    new Product { Name="Minecraft - Mini Figure - Multi", Sku="4558108", Inventory=5, Price=3.49m, Description="Collectible mini figure; mystery character from the popular game; for ages 6 and older"},
                    new Product { Name="Sphero - BB-8™ App-Enabled Droid™ by Sphero - White", Sku="4316601", Inventory=6, Price=126.99m, Description="Compatible with select Apple® iOS and Android smartphones and tablets; authentic movements; holographic communication; autonomous behavior; adaptive personality; suitable for ages 8 and up"},
                    new Product { Name="VTech - Kidizoom Smartwatch DX - Blue", Sku="4317201", Inventory=7, Price=44.99m, Description="Lets your child capture photos and videos; motion sensor; 3 action challenges; 8 games; touch screen; more than fifty 3D digital and analog display options; alarm; timer; stopwatch; calendar; calculator"},
                    new Product { Name="AtGames - Sega Genesis Ultimate Portable Game Player", Sku="5066900", Inventory=1, Price=44.99m, Description="Amuse and immerse yourself in nostalgia with 80 preloaded games"},
                    new Product { Name="Orbotix - SPRK Robot - Clear", Sku="4316301", Inventory=4, Price=129.99m, Description="Teaches C-based programming language, OVAL; text-based code viewer; teach the robot simple commands, including roll, flip, spin and change colors; SPRK app (download required); ages 5 and up"},
                    new Product { Name="WowWee - R.E.V. Cars (2-Pack) - Multi", Sku="4247800", Inventory=8, Price=47.99m, Description="BeaconSense technology; mimics real-world physics; R.E.V. app (download required); 2-pack"},
                    new Product { Name="K'NEX - Classics 4-Wheel Drive Truck Building Set - Multi", Sku="6836827", Inventory=6, Price=16.99m, Description="Lets your child build a 4-wheel truck; 313 pieces; working lights; all-wheel steering; alternative pickup truck or dune buggy building ideas; for ages 7 and up"},
                    new Product { Name="Swagtron® - T3 Self-Balancing Scooter - Garnet", Sku="5353005", Inventory=5, Price=499.99m, Description="Multilayer battery protection; Color-coded LED lights; Smart battery management system; Bluetooth® speaker; Swagtron® App; Built-in carrying strap"}
                };
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();

            var customers = new List<Customer>
                {
                    new Customer { FirstName="Joe", LastName="Smith", Email="Joe.Smith@coldmail.com"},
                    new Customer { FirstName="Jeff", LastName="Johnson", Email="jeffyjohn@hmail.com"},
                    new Customer { FirstName="Sarah", LastName="Williams", Email="Swilliams@hmail.com"},
                    new Customer { FirstName="Betty", LastName="Brown", Email="betty@bettybrown.ninja"},
                    new Customer { FirstName="Elliot", LastName="Jones", Email="elliot.jones@hmail.com"},
                    new Customer { FirstName="Frank", LastName="Miller", Email="fm@miller.net"},
                    new Customer { FirstName="Fred", LastName="Davis", Email="davis.fred@email.net"},
                    new Customer { FirstName="Lucy", LastName="Garcia", Email="lucyg@coldmail.com"},
                    new Customer { FirstName="Bill", LastName="Wilson", Email="billywill@hmail.com"},
                    new Customer { FirstName="Jack", LastName="Anderson", Email="janderson@hayoo.com"},
                    new Customer { FirstName="Mary", LastName="Hernandez", Email="maryh@maryghernandez.com"},
                    new Customer { FirstName="Elizabeth", LastName="Lee", Email="elee@hayoo.com"}
                };
            customers.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();

            var orders = new List<Order>
                {
                    new Order {Total=39.97m, CustomerId=4, EmployeeId=3, DatePurchasedUtc=DateTime.Parse("2016-04-03 13:26") },
                    new Order {Total=253.95m, CustomerId=2, EmployeeId=6, DatePurchasedUtc=DateTime.Parse("2016-05-05 08:08") },
                    new Order {Total=999.98m, CustomerId=7, EmployeeId=1, DatePurchasedUtc=DateTime.Parse("2016-06-01 16:15") },
                    new Order {Total=182.45m, CustomerId=6, EmployeeId=3, DatePurchasedUtc=DateTime.Parse("2016-06-04 12:32") },
                    new Order {Total=51.96m, CustomerId=3, EmployeeId=7, DatePurchasedUtc=DateTime.Parse("2016-07-22 19:00") },
                    new Order {Total=126.99m, CustomerId=2, EmployeeId=4, DatePurchasedUtc=DateTime.Parse("2016-07-22 18:01") },
                    new Order {Total=86.95m, CustomerId=1, EmployeeId=2, DatePurchasedUtc=DateTime.Parse("2016-08-02 23:59") },
                };
            orders.ForEach(o => context.Orders.Add(o));
            context.SaveChanges();

            var orderItems = new List<OrderItem>
                {
                    new OrderItem { OrderId=1, ProductId=1, Price=32.99m, Quantity=1 },
                    new OrderItem { OrderId=1, ProductId=5, Price=3.49m, Quantity=2 },
                    new OrderItem { OrderId=2, ProductId=6, Price=126.99m, Quantity=1 },
                    new OrderItem { OrderId=2, ProductId=8, Price=44.99m, Quantity=1 },
                    new OrderItem { OrderId=2, ProductId=10, Price=47.99m, Quantity=1 },
                    new OrderItem { OrderId=2, ProductId=11, Price=16.99m, Quantity=2 },
                    new OrderItem { OrderId=3, ProductId=12, Price=499.99m, Quantity=2 },
                    new OrderItem { OrderId=4, ProductId=5, Price=3.49m, Quantity=3 },
                    new OrderItem { OrderId=4, ProductId=6, Price=126.99m, Quantity=1 },
                    new OrderItem { OrderId=4, ProductId=7, Price=44.99m, Quantity=1 },
                    new OrderItem { OrderId=5, ProductId=2, Price=6.99m, Quantity=2 },
                    new OrderItem { OrderId=5, ProductId=4, Price=18.99m, Quantity=2 },
                    new OrderItem { OrderId=6, ProductId=6, Price=126.99m, Quantity=1 },
                    new OrderItem { OrderId=7, ProductId=2, Price=6.99m, Quantity=1 },
                    new OrderItem { OrderId=7, ProductId=3, Price=19.99m, Quantity=4 }
                };                                     
            orderItems.ForEach(oi => context.OrderItems.Add(oi));
            context.SaveChanges();
        }

    }
}