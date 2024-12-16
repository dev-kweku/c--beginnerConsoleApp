public class Person{
    public string Name;
    public int Age;

    public void Introduce(){
        Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old");
    }
}

public class Program{
public static void Main(String[] args){
    Person person=new Person();
    person.Name="John";
    person.Age=23;
    person.Introduce();
}

}

