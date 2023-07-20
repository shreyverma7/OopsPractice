using Newtonsoft.Json;
using OOPs.DataInventoryManagement;
using OOPs.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps.InventoryManagement
{
    internal class InventoryManagementOperation
    {
        InventoryManagementDetails list;
        public void ReadInventoryJson(string filePath)
        {
            var json = File.ReadAllText(filePath);
            list = JsonConvert.DeserializeObject<InventoryManagementDetails>(json);

            Display(list.RiceList);
            Display(list.WheatList);
            Display(list.PulseList);

        }
        public void Display(List<InventoryDetails> list)
        {
            foreach (var data in list)
            {
                Console.WriteLine(data.Name + " " + data.Weight + " " + data.PricePerKg);
            }
        }
        public void AddInventoryManagement(string objectName)
        {
            InventoryDetails details = new InventoryDetails()
            {
                Name = Console.ReadLine(),
                Weight = Convert.ToInt32(Console.ReadLine()),
                PricePerKg = Convert.ToInt32(Console.ReadLine())
            };
            if (objectName.ToLower().Equals("rice"))
            {
                Console.WriteLine("Enter RiceType , Weight, Price per kg");
                list.RiceList.Add(details);
            }
            if (objectName.ToLower().Equals("wheat"))
            {
                Console.WriteLine("Enter WheatType , Weight, Price per kg");
                list.WheatList.Add(details);
            }
            if (objectName.ToLower().Equals("pulse"))
            {
                Console.WriteLine("Enter PulseType , Weight, Price per kg");
                list.PulseList.Add(details);
            }
        }
        public void WriteToJsonFile(string filePath)
        {
            var json = JsonConvert.SerializeObject(list);
            File.WriteAllText(filePath, json);
        }
        public void DeleteInventoryItems(string objectName, string inventoryName) {
            InventoryDetails details = new InventoryDetails();
            if (objectName.ToLower().Equals("rice"))
            {
                foreach (var data in list.RiceList)
                {
                    if (data.Name.Equals(inventoryName))
                        details = data;
                }
                if(details != null)
                    list.RiceList.Remove(details);
            }
            if (objectName.ToLower().Equals("wheat"))
            {
                foreach (var data in list.WheatList)
                {
                    if (data.Name.Equals(inventoryName))
                        details = data;
                }
                if (details != null)
                    list.WheatList.Remove(details);
            }
            if (objectName.ToLower().Equals("pulse"))
            {
                foreach (var data in list.PulseList)
                {
                    if (data.Name.Equals(inventoryName))
                        details = data;
                }
                if (details != null)
                    list.PulseList.Remove(details);
            }
            if(details == null)
                Console.WriteLine("NO inventory Details Exists")
        }

    }
}
