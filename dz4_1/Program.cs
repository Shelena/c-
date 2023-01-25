Console.WriteLine("Введите степень");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Введите число");
int x = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//double result = Math.Pow(x, n);
//Console.WriteLine(result);
string binary = Convert.ToString(n, 2);
string kx_str = binary.Replace("0", "k");
kx_str = kx_str.Replace("1", "kx");
kx_str = kx_str.Substring(2);
int res = x;
foreach (char с in kx_str)
{
    if (с == 'k')
    {
        res *= res;
    }
    else res *= x;
}
Console.WriteLine(res);
