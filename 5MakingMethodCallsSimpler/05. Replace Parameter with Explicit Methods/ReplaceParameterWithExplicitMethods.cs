using System;
namespace MakingMethodCallsSimpler
{
    public class ReplaceParameterWithExplicitMethods
    {
        public ReplaceParameterWithExplicitMethods()
        {
            Animal.Create(Animal.FISH);
        }

        class Animal
        {
            internal const int BIRD = 1;
            internal const int CAT = 2;
            internal const int FISH = 3;

            public static Animal Create(int type)
            {
                switch (type)
                {
                    case BIRD:
                        return new Bird();
                    case CAT:
                        return new Cat();
                    case FISH:
                        return new Fish();
                    default:
                        throw new ArgumentException("Incorrect animal code.");
                }
            }
        }

        class Bird : Animal { }
        class Cat : Animal { }
        class Fish : Animal { }
    }
}
