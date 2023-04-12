using Main1;

namespace Main1
{

    public class Animal
    {
        public virtual void makeSound()
        {
            Console.WriteLine("Dong vat tao ra am thanh");
        }
    }
    class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("gau gau gau");
        }
        public void fetch()
        {
            Console.WriteLine("Con cho choi voi qua bong");
        }
    }
    class Cat : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("meo meo");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        // Upcasting: chuyển đổi đối tượng của lớp con thành đối tượng của lớp cha
        Animal animal = new Dog();
        animal.makeSound(); // "gau gau gau"
        //animal.fetch();

        // Downcasting: chuyển đổi đối tượng của lớp cha thành đối tượng của lớp con
        Dog dog = (Dog)animal;
        dog.makeSound(); // "gau gau gau"
        dog.fetch(); // "Con cho choi voi qua bong"

        // Downcasting không hợp lệ
        Animal cat = new Animal();
        //Cat invalidCat = (Cat)cat; // Lỗi ClassCastException
        //invalidCat.makeSound();

        Animal cat2 = new Cat();
        cat2.makeSound();
        }
    }
}

