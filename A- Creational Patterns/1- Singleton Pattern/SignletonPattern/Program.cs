using SignletonPattern;

//var instance1 = Singleton.Instance;
//instance1.SomeBusinessLogic();

//var instance2 = Singleton.Instance;
//instance2.SomeBusinessLogic();


//var instance1 = SingletonWithLazy.Instance;
//instance1.SomeBusinessLogic();

//var instance2 = SingletonWithLazy.Instance;
//instance2.SomeBusinessLogic();


//var instance1 = SingletonWithLock.Instance;
//instance1.SomeBusinessLogic();

//var instance2 = SingletonWithLock.Instance;
//instance2.SomeBusinessLogic();

var instance1 = SingletonGeneric<Logger>.Instance;
Console.WriteLine(instance1.LogInformation());

var instance2 = SingletonGeneric<Logger>.Instance;
Console.WriteLine(instance2.LogInformation());

if (instance1 == instance2)
    Console.WriteLine("yes");

Console.ReadLine();


public class Logger
{
    public string LogInformation() => "Log Information";
}