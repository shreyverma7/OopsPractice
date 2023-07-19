using OOPs.DataInventoryManagement;
using System.Collections.Generic;

internal class Program
{
    //------>List of Object
    static string inventory_filePath = @"D:\Bridgelabz Problem statement\OopsPractice\OOps\DataInventoryManagement\InventoryData.json";
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Inventory Management");
        InventoryDetailsOperation details = new InventoryDetailsOperation();
        details.ReadInventoryJson(inventory_filePath);
    }
}