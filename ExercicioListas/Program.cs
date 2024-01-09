using ExercicioListas;

Console.Write("Digite a quantidade de funcionários que vai cadastrar: ");
int n = int.Parse(Console.ReadLine());

List<Employee> employees = new List<Employee>();

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Funcionário #" + (i + 1));
    Console.Write("Digite o id do funcionário: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Digite o nome do funcionário: ");
    string name = Console.ReadLine();
    Console.Write("Digite o salário do funcionário: ");
    double salary = int.Parse(Console.ReadLine());
    employees.Add(new Employee(id, name, salary));
    Console.WriteLine();
}


Console.Write("Digite o id do funcionário que vai receber aumento: ");
int searchId = int.Parse(Console.ReadLine());
Employee emp = employees.Find(x => x.Id == searchId);
if(emp != null)
{
    Console.Write("Digite a porcentagem de aumento: ");
    double percentage = double.Parse(Console.ReadLine());
    emp.IncreaseSalary(percentage);    
}
else
{
    Console.WriteLine("Este id não existe");
}

Console.WriteLine();
Console.WriteLine("Lista atualizada: ");
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
}
