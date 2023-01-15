// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//string name = Console.ReadLine();

//Console.WriteLine(name);

//int myNumber;
//int[] numbers = new int[] { 1, 2, 4, 3, 54, 6 };

//var even = numbers.Where(x => x % 2 == 0);

////dataType variableName;


//int result = AddTwoNumbers(5, 8);
//Console.WriteLine(result);


//int AddTwoNumbers(int firstNumber, int secondNumber)
//{
//    int result = firstNumber + secondNumber;
//    return result;
//}

using Class01Console;

Person sodiq = new Person(Guid.NewGuid(), "Sodiq", "Salaudeen");
Person ibrahim = new Person(Guid.NewGuid(), "Ibrahim", "Ademola");

Console.WriteLine(sodiq.SayMyName());
Console.WriteLine(ibrahim.SayMyName());

var firstName = sodiq.FirstName;
var lastName = sodiq.LastName;
Console.WriteLine($"my name is {firstName} {lastName}");

Console.WriteLine(ibrahim.SayMyName("Temitope", "Jubril"));

//string name = string.Empty;
// datatype variableName = value

Car car = new Car();
//car.SaySomething();
Car.SaySomething();