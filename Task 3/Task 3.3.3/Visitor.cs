namespace Task_3_3_3
{
    public class Visitor
    {

        public Pizza? Pizza { get; private set; }

        public void MakeOrder(PizzaHouse newPizzaHouse)
        {
            var newPizza = new Pizza();

            newPizzaHouse.OrderList(newPizza);

            Pizza = newPizza;

            Pizza.OnPizzaReady += PizzaReady;


        }

        public void PizzaReady()
        {
            Pizza.OnPizzaReady -= PizzaReady;
            Console.WriteLine("Got my pizza"); // DEBUG_OUTPUT
        }

    }

}
