
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace BasketProgram
{
    class Fruits
    {

        private string fruitName;
        public string getfruitName()
        {
            return fruitName;
        }
        public void setfruitName( string fruitName)
        {
            this.fruitName = fruitName;
        }
        private string fruitColor;
        public string getfruitColor()
        {
            return fruitColor;
        }
        public void setfruitColor(string fruitColor)
        {
            this.fruitColor = fruitColor;
        }
        private string fruitSize;
        public string getfruitSize()
        {
            return fruitSize;
        }
        public void setfruitSize(string fruitSize)
        {
            this.fruitSize = fruitSize;
        }
        public int fruitQuantity;
        public int getfruitQuantity()
        {
            return fruitQuantity;
        }
        public void setfruitQuantity(int fruitQuantity)
        {
            this.fruitQuantity = fruitQuantity;
        }


    }
    class Apple : Fruits
    {
       
        public Apple(string fruitSize,string fruitColor, int fruitQuantity)
        {
            setfruitName("Apple");
            setfruitColor(fruitColor);
            setfruitSize(fruitSize);
            setfruitQuantity(fruitQuantity);
        }
    }
    class Banana : Fruits
    {
        
        public Banana(string fruitSize, string fruitColor,int fruitQuantity)
        {
            setfruitName("Banana");
            setfruitColor(fruitColor);
            setfruitSize(fruitSize);
            setfruitQuantity(fruitQuantity);
        }
    }
    class Orange : Fruits
    {
      
        public Orange(string fruitSize, string fruitColor,int fruitQuantity)
        {
            //  fruitName = "orange";
            setfruitName("Orange");
            setfruitColor(fruitColor);
            setfruitSize(fruitSize);
            setfruitQuantity(fruitQuantity);
        }
    }
    class Grapes : Fruits
    {
       
        public Grapes(string fruitSize, string fruitColor, int fruitQuantity)
        {
            //  fruitName = "Grapes";
            setfruitName("Grapes");
            setfruitColor(fruitColor);
            setfruitSize(fruitSize);
            setfruitQuantity(fruitQuantity);
        }
    }
    class Basket
    {
        ArrayList basket = new ArrayList();
        public Basket(Fruits[] bucket)
        {

            for (int i = 0; i < bucket.Length; i++)
            {
                basket.Add(bucket[i]);
            }
        }
        public void Display()
        {
            foreach (Fruits i in basket)
            {
                Console.Write("Fruit Name: " + i.getfruitName() + "\n");
                Console.Write("Fruit Color: " + i.getfruitColor() + "\n");
                Console.Write("Fruit Size: " + i.getfruitSize() + "\n");
                Console.Write("Fruit Quantity: " + i.getfruitQuantity() + "\n");
           
                Console.Write("---------------------------------------------------\n");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fruits apple = new Apple("medium","red",3);
            Fruits banana = new Banana("small", "lightYellow",12);
            Fruits orange = new Orange("medium", "orange", 12);
            Fruits grapes = new Grapes("small","green",7);

            Fruits[] temp_basket = { apple, banana,orange,grapes };

            Basket basket = new Basket(temp_basket);
            basket.Display();
           
            Console.ReadLine();

        }
    }
}
