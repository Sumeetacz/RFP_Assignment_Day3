Console.WriteLine("Welcome to Line Comparison Computation Program");
int x1 = 2;
int x2 = 2;
int y1 = 3;
int y2 = 4;

int a1 = 2;
int a2 = 0;
int b1 = 3;
int b2 = 4;

double lgth1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
Console.WriteLine("Length of first line is :" + lgth1);

double lgth2 = Math.Sqrt((a2 - a1) * (a2 - a1) + (b2 - b1) * (b2 - b1));
Console.WriteLine("Length of second line is :" + lgth2);

int val1 = (int)lgth1;
int val2 = (int)lgth2;

if (val1 == val2)
{
	Console.WriteLine("Lines are equal");
}
else
{
	Console.WriteLine("Lines are not equal");
}