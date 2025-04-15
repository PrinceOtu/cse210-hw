class Animal {
    public virtual void Speak() {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal {
    public override void Speak() {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal {
    public override void Speak() {
        Console.WriteLine("Cat meows");
    }
}

// Usage
Animal a = new Dog();
a.Speak();  // Outputs: Dog barks
