// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Car myCar = new Car();
//myCar.Make = "Viet Nam";
//myCar.Model = "Vinfast";
//myCar.Year = 2020;
//myCar.color = "blue";

//Car myOtherCar;
//myOtherCar = myCar;

//Console.WriteLine("{0} {1} {2} {3}",
//    myOtherCar.Make,
//    myOtherCar.Model,
//    myOtherCar.Year,
//    myOtherCar.color);
//Console.ReadLine();

Car customer1 = new Car("Le Nhat Thong", 1000000);
Console.WriteLine("{0} {1}", 
    customer1.customername, 
    customer1.customerbalance);

customer1.Debit(100000);
customer1.Credit(500000);

Console.WriteLine("{0} {1}",
    customer1.customername,
    customer1.customerbalance);

customer1.customername = "Nguyen Dinh Quy";
Console.WriteLine(customer1.customername);

