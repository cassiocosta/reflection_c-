using System.Reflection;

string className = "InvokeMethodsDynamically.Car"; // Full name of the class with namespace
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

    // Dynamically invoke methods
    InvokeMethodDynamically(car, "Accelerate");
}
else
{
    Console.WriteLine("Class not found.");
}


// Method to invoke methods dynamically
void InvokeMethodDynamically(object obj, string methodName)
{
    Type type = obj.GetType();
    MethodInfo methodInfo = type.GetMethod(methodName);
    
    if (methodInfo != null)
    {
        methodInfo.Invoke(obj, null);
    }
    else
    {
        Console.WriteLine($"Method '{methodName}' not found in {type.Name}.");
    }
}