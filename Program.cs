
MyDelegate myDelegate = Length;
myDelegate += Square;
myDelegate += Volume;
Console.WriteLine("Введите радиус");
double R = myDelegate(Convert.ToInt32(Console.ReadLine()));



static double Length (double R)
{ 
    double D =2*Math.PI * R;
    Console.WriteLine("Длина окружности: {0}", D);
    return D;
}
static double Square (double R)
{
    double S = Math.PI * Math.Pow(R, 2);
    Console.WriteLine("Площадь круга: {0}", S);
    return S;
}
static double Volume(double R)
{
    double V = 4 / 3 * Math.PI * Math.Pow(R, 3);
    Console.WriteLine("Объем шара: {0}", V);
    return V;
}
delegate double MyDelegate(double R);
