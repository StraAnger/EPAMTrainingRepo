namespace Task_3_3_3
{
    public class PizzaHouse
    {
        public int OrderNumber { get; set; }

        public PizzaHouse()
        {
            OrderNumber = 100;
        }


        public void OrderList(Pizza orderedPizza)
        {
            ++OrderNumber;
            Thread New = new Thread(orderedPizza.CookingPizza);
            New.Name = $"{OrderNumber}";
            New.Start();

        }



    }

}
