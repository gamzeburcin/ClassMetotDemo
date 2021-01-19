using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CostumerManager
    {
        public void AddCostumer (Costumer costumer)
        {
            Console.WriteLine(costumer.Name + " " + costumer.Surname + " sisteme eklendi! ");

        }
        public void DeleteCostumer(Costumer costumer)
        {
            Console.WriteLine(costumer.Name + " " + costumer.Surname + " sistemden silindi! ");

        }
        public void ListCostumer(Costumer[] costumers)
        {
            foreach (var costumer in costumers)
            {
                Console.WriteLine(costumer.Id);
                Console.WriteLine("Name: "+costumer.Name);
                Console.WriteLine("Surname: "+costumer.Surname);
                Console.WriteLine("Phone Number: "+costumer.PhoneNumber);
                Console.WriteLine("Adress: "+costumer.Adress);
            }

        }
    }
}
