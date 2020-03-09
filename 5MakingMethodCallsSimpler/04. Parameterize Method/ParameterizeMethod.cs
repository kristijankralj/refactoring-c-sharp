using System;

namespace MakingMethodCallsSimpler
{
    public class ParameterizeMethod
    {
        public ParameterizeMethod()
        {
            Animal.CreateFish();
        }

        class Animal
        {
            internal const int BIRD = 1;
            internal const int CAT = 2;
            internal const int FISH = 3;

            public static Animal CreateFish()
            {
                return new Fish();
            }

            public static Animal CreateCat()
            {
                return new Cat();
            }

            public static Animal CreateBird()
            {
                return new Bird();
            }
        }

        class Bird : Animal { }
        class Cat : Animal { }
        class Fish : Animal { }
    }
}
