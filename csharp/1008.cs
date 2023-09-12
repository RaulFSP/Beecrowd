int numero, horas;
float salarioHora, salario;
int.TryParse(Console.ReadLine(), out numero);
int.TryParse(Console.ReadLine(), out horas);
float.TryParse(Console.ReadLine(), out salarioHora);
salario = horas*salarioHora;
Console.WriteLine($"NUMBER = {numero}");
Console.WriteLine($"SALARY = U$ {salario:F2}");