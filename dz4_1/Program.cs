Console.WriteLine("Введите степень");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Введите число");
int x = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//double result = Math.Pow(x, n);
//Console.WriteLine(result);
string binary = Convert.ToString(n, 2); // перевод в двоичный код 
string kx_str = binary.Replace("0", "k"); // замена 0 на k
kx_str = kx_str.Replace("1", "kx"); // замена 1 на kx
kx_str = kx_str.Substring(2); // отсечение первых двух kx
int res = x;
foreach (char с in kx_str) // перебор символов строки
{
    if (с == 'k')
    {
        res *= res;
    }
    else res *= x;
}
Console.WriteLine(res);
