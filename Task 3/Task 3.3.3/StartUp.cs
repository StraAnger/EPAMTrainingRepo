using System;
using System.Collections.Generic;
using System.Linq;


namespace Task_3_3_3
{

    public class StartUp
    {


        public static void Main(string[] arg)
        {
            var NewPizzaHouse = new PizzaHouse();

            var NewVisitor = new Visitor();
            NewVisitor.MakeOrder(NewPizzaHouse);

            var NewVisitor2 = new Visitor();
            NewVisitor2.MakeOrder(NewPizzaHouse);

            var NewVisitor3 = new Visitor();
            NewVisitor3.MakeOrder(NewPizzaHouse);

            var NewVisitor4 = new Visitor();
            NewVisitor4.MakeOrder(NewPizzaHouse);

        }

    }

}
