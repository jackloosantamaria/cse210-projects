using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation2 World!");
        Address address1 = new Address("123 Villas Alpinas 9th St", "Ernesto Cordoba Campos", "PA", "Panama");
        Customers custom1 = new Customers("John Doe", address1);
        List<Products> productList = new List<Products>();

        Products pro10 =  new Products("Dell Laptop", "DL0001", 350.99, 1);
        Products pro20 = new Products("Samsung Tablet", "ST0002", 536.99, 10);
        Products pro30 = new Products("LG Monitor", "LM0003", 899.99, 2);

        productList.Add(pro10);
        productList.Add(pro20);
        productList.Add(pro30);

        Orders order1 = new Orders(productList, custom1);

        Console.WriteLine("Order Number: 0001");
        order1.ShowResults();
        Console.WriteLine();

        ////////////

        Address address2 = new Address("1234 N 400 E", "SALT LAKE CITY", "UT", "USA");
        Customers custom2 = new Customers("Mary Jensen", address2);
        List<Products> proList2 = new List<Products>();

        Products pro40 = new Products("Samsung Cellphone", "S21", 999.99, 1);
        Products pro50 = new Products("Centrum Vitamins", "CV0004", 14.99, 5);
        Products pro60 = new Products("TP-LINK Deco", "AXE5400", 199.99, 4);

        proList2.Add(pro40);
        proList2.Add(pro50);
        proList2.Add(pro60);

        Orders order2 = new Orders(proList2, custom2);

        Console.WriteLine("Order Number: 0002");
        order2.ShowResults();
        Console.WriteLine();

        //////////// 
        
        Address address3 = new Address("5678 New York St", "Miami", "FL", "USA");
        Customers custom3 = new Customers("Peter Doe", address3);
        List<Products> proList3 = new List<Products>();

        Products pro7 = new Products("Ring Video Doorbel", "B08N5NQ869", 54.99, 1);
        Products pro8 = new Products("Blink Mini Camera", "B09N6YCT3Y", 29.99, 4);
        Products pro9 = new Products("Echo Dot", "C4E8S3", 34.99, 1);

        proList3.Add(pro7);
        proList3.Add(pro8);
        proList3.Add(pro9);

        Orders order3 = new Orders(proList3, custom3);

        Console.WriteLine("Order Number: 0003");
        order3.ShowResults();
        

    }

}