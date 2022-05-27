double C = 0;
double F = 0;
string nome = "";


Console.WriteLine("Olá qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine($"Olá, {nome} quantos graus quer converter?" );
C = Convert.ToDouble(Console.ReadLine());

F = (9 * C + 160) / 5;

Console.WriteLine($"{nome}, {C} gráus celius valem {F}  fahrenheit");

