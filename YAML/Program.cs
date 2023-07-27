using SharpYaml.Serialization;

namespace YAML
{
    class Program
    {
        static void Main()
        {
            // Read the YAML data from the file
            const string yamlFilePath = @"C:\Users\Beray\RiderProjects\c sharp start\YAML\data.yaml";
            var yourYamlString = File.ReadAllText(yamlFilePath);

            // Create a new instance of the SharpYamlSerializer
            var serializer = new Serializer();

            // Deserialize the YAML string into the EmployeeData object
            var employeeData = serializer.Deserialize<EmployeeData>(yourYamlString);

            // Access and display the deserialized data
            foreach (var employee in employeeData.Employees)
            {
                Console.WriteLine($"ID: {employee.Id}");
                Console.WriteLine($"Name: {employee.Name}");
                Console.WriteLine($"Age: {employee.Age}");
                Console.WriteLine($"Department: {employee.Department}");
                Console.Write("Skills: ");
                Console.WriteLine(string.Join(", ", employee.Skills));
                Console.WriteLine();
            }
        }
    }
}
// Adding comments