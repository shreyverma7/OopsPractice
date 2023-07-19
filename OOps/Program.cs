using OOps.InventoryManagement;
using OOPs.DataInventoryManagement;
using System.Collections.Generic;

internal class Program

{
    //------>List of Object
    // static string inventory_filePath = @"D:\Bridgelabz Problem statement\OopsPractice\OOps\DataInventoryManagement\InventoryData.json";
    //------>Object of list
    static string inventory_filePath = @"D:\Bridgelabz Problem statement\OopsPractice\OOps\InventoryManagement\InventoryMangementData.json";
    private static void Main(string[] args)
    {
        //List of Object
        //InventoryDetailsOperation details = new InventoryDetailsOperation();
        //details.ReadInventoryJson(inventory_filePath);

        //Object of List
        InventoryManagementOperation details = new InventoryManagementOperation();
        Console.WriteLine("Welcome to Inventory Management System -->");
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Enter input :\n1.Reading Inventory \n2.Adding to inventory \n3.Delete \n4.Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Reading Inventory :");
                    details.ReadInventoryJson(inventory_filePath);
                    Console.WriteLine("\n");
                    break;
                case 2:
                    Console.WriteLine("Enter crop to added: Type Rice (or) Wheat (or) Pulse");
                    string input = Console.ReadLine();
                    Console.WriteLine("Adding " + input);
                    details.AddInventoryManagement(input);
                    details.WriteToJsonFile(inventory_filePath);
                    Console.WriteLine("\n");
                    break;
                case 3:
                    Console.WriteLine("Enter the crop name to delete :");
                    string Crops = Console.ReadLine();
                    Console.WriteLine("Enter the data on " + Crops + " To delete :");
                    string data = Console.ReadLine();
                    details.DeleteInventoryItem(Crops, data);
                    Console.WriteLine("\n");
                    break;
                case 4:
                    flag = false;
                    break;

            }
        }
    }
}