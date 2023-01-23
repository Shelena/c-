Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[5];
for (int i = 0; i < 5; i++)
{

    int num = a % 10;
    a /= 10;
    myArray[i] = num;
}
if (myArray[0] == myArray[4] & myArray[1] == myArray[3])
{
    Console.WriteLine("это палиндром");
}
else Console.WriteLine("это не палиндром");
