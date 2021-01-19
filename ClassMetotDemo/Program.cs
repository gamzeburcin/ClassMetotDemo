using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Costumer costumer1 = new Costumer();
            costumer1.Id = 1;
            costumer1.Name = "Gamze";
            costumer1.Surname = "Aydın";
            costumer1.PhoneNumber = 74738539753;
            costumer1.Adress = "Ankara";

            Costumer costumer2 = new Costumer();
            costumer2.Id = 2;
            costumer2.Name = "Cemre";
            costumer2.Surname = "Aydın";
            costumer2.PhoneNumber = 74732443534;
            costumer2.Adress = "Ankara";

            Costumer costumer3 = new Costumer();
            costumer3.Id = 3;
            costumer3.Name = "Ecrin";
            costumer3.Surname = "Aydın";
            costumer3.PhoneNumber = 36543639753;
            costumer3.Adress = "Ankara";

            Costumer[] costumers = new Costumer[]
            {
                costumer1,costumer2,costumer3
            };
            CostumerManager costumerManager = new CostumerManager();
            costumerManager.AddCostumer(costumer1);
            costumerManager.AddCostumer(costumer2);
            costumerManager.AddCostumer(costumer3);
            costumerManager.ListCostumer(costumers);
            costumerManager.DeleteCostumer(costumer1);
            costumerManager.DeleteCostumer(costumer2);
            costumerManager.DeleteCostumer(costumer3);

        }
    }
}
