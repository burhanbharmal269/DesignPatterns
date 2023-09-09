using UnitOfWorkMVCDemo.FactoryDesign;

namespace UnitOfWorkMVCDemo.FactoryDesign
{
    interface IPizza
    {
        string Eat();
    }
    public class VegPizza : IPizza
    {
        public string Eat()
        {
            return "Eating veg pizza";
        }
    }

    public class NonVegPizza : IPizza
    {
        public string Eat()
        {
            return "Eating non veg pizza";
        }
    }

    interface IPizzaChef
    {
        IPizza PreparePizza();
    }

    public class VegPizzaChef : IPizzaChef
    {
        IPizza IPizzaChef.PreparePizza()
        {
            return new VegPizza();
        }
    }

    public class NonVegPizzaChef : IPizzaChef
    {
        IPizza IPizzaChef.PreparePizza()
        {
            return new NonVegPizza();
        }
    }

    class Waiter
    {
        public IPizza GetPizza(String type)
        {
            IPizzaChef chef;
            switch (type)
            {
                case "Veg":
                    chef = new VegPizzaChef();
                    break;
                default:
                    chef = new NonVegPizzaChef();
                    break;
            }
            return chef.PreparePizza();
        }
    }

}
