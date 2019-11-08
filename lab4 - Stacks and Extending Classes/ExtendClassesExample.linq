<Query Kind="Program" />

class Animal
{
	int age;
	string type;
	
	internal Animal(int newAge, string newType)
	{
		this.age = newAge;
		this.type = newType;
	}
	
	internal virtual void makeNoise()
	{
		Console.WriteLine("[GENERIC ANIMAL NOISE]");
	}
}

class Dog : Animal
{
	string dogOwner;
	internal Dog(int newAge, string newType) : base(newAge, newType)
	{
		this.dogOwner = "Razvan";
	}
	
	internal override void makeNoise()
	{
		Console.WriteLine("bark");
	}
}

class Cat : Animal
{
	internal int livesLeft;
	internal Cat(int newAge, string newType) : base(newAge, newType)
	{
		this.livesLeft = 9;
	}

	internal override void makeNoise()
	{
		Console.WriteLine("Meow");
	}
}

class GrumpyCat : Cat
{
	internal GrumpyCat(int newAge, string newType) : base(newAge, newType)
	{
		this.livesLeft = 1;
	}

	internal override void makeNoise()
	{
		Console.WriteLine("Leave me alone, human!");
	}
}

void Main()
{
	Animal genericAnimal = new Animal(5, "bear");
	genericAnimal.makeNoise();
	
	Animal myDog = new Dog(2, "dog");
	myDog.makeNoise();
	Animal cat = new Cat(3, "cat");
	cat.makeNoise();

	Animal grumpyCat = new GrumpyCat(9, "cat");
	grumpyCat.makeNoise();
}