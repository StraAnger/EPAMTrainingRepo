namespace Task_3_3_3
{
    public class Pizza
    {

        public event Action OnPizzaReady = delegate { };



        public void CookingPizza()
        {
            for (int i = 5; i >= 0; --i)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
            OnPizzaReady?.Invoke();
        }
    }

}
