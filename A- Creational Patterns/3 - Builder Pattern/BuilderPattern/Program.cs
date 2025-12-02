namespace BuilderPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            // When not use the Builder Pattern
            // 1. When you have class and all the properties are required
            // 2. When you have simple object
            // 3. When you are writing boilerplate code


            // When to use the Builder Pattern
            // 1. When you have class with optional properties
            // 2. When you have class with complex object creation
            // 3. When you have class but you need immutable object
            // 4. When you have class and keep the object creation logic in one place with condition

            // Benefits
            // 1. Threadsafety
            // 2. Easy to use 
            // 3. We have chaining way using it. so it will not be error pron.


            var employee = new EmployeeBuilder()
                           .SetEmployeeId(1)
                           .SetEmployeeName("Test")
                           .SetJobDescription("Test user")
                           .Build();
            Console.WriteLine($"EmployeeId: {employee.Id}, Name: {employee.Name}");
            Console.ReadLine();
        }
    }
}
