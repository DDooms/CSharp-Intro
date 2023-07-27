using SharpYaml.Serialization;

namespace YAML;

using System.Collections.Generic;

public class Employee
{
    [YamlMember("id")] // Map the YAML property "id" to the C# property "Id"
    public int Id { get; set; }

    [YamlMember("name")] // Map the YAML property "name" to the C# property "Name"
    public string Name { get; set; }

    [YamlMember("age")] // Map the YAML property "age" to the C# property "Age"
    public int Age { get; set; }

    [YamlMember("department")] // Map the YAML property "department" to the C# property "Department"
    public string Department { get; set; }

    [YamlMember("skills")] // Map the YAML property "skills" to the C# property "Skills"
    public List<string> Skills { get; set; }
}

public class EmployeeData
{
    // Map the YAML property "employees" to the C# property "Employees"
    [YamlMember("employees")]
    public List<Employee> Employees { get; set; }
}

// Adding comments