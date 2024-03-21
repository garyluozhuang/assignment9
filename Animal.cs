class AnimalFactory
{
    public static IAnimal CreateAnimal(string animalType)
    {
        if (animalType == "Dog")
            return new Dog();
        else if (animalType == "Cat")
            return new Cat();
        else
            throw new ArgumentException("Invalid animal type");
    }
}


IAnimal dog = AnimalFactory.CreateAnimal("Dog");
dog.speak(); // Output: woof

IAnimal cat = AnimalFactory.CreateAnimal("Cat");
cat.speak(); // Output: meow