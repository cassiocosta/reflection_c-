using System.Reflection;
using DynamicObjectCreation;


internal class Program
{
    private static void Main(string[] args)
    {
        string className = "Car"; // Name of the class
        Type type = Type.GetType(className); // Get the class by name

        if (type != null)
        {
            // Create a new instance of Car
            object car = Activator.CreateInstance(type);

            // Set properties of the car
            PropertyInfo brandProp = type.GetProperty("Brand");
            PropertyInfo modelProp = type.GetProperty("Model");
            brandProp.SetValue(car, "Fusca");
            modelProp.SetValue(car, "Classic");

            // Invoke the Accelerate method
            MethodInfo accelerateMethod = type.GetMethod("Accelerate");
            accelerateMethod.Invoke(car, null);
        }
        else
        {
            Console.WriteLine("Class not found.");
        }
    }
}