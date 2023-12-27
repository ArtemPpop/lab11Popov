//try {Console.WriteLine("Введите название алмаза:");
//string name = Console.ReadLine();

//Console.WriteLine("Введите вес алмаза в каратах:");
//double weight = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Введите качество огранки алмаза (в баллах):");
//int cutQuality = Convert.ToInt32(Console.ReadLine());

//Diamond алмаз = new Diamond(name, weight, cutQuality);
//double Q = алмаз.Q();
//Console.WriteLine($"Значение Q для алмаза: {Q}");
//Console.WriteLine(алмаз.ToString());
// }
//catch ( Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//class Diamond
//{
//    public string Name { get; set; }        
//    public double Weight { get; set; }
//    public int CutQuality { get; set; }

//    public Diamond(string name, double weight, int cutQuality)
//    {
//        Name = name;
//        Weight = weight;
//        CutQuality = cutQuality;
//    }
//    public double Q()
//    {
//        return 0.4 * Weight + 0.6 * CutQuality;
//    }
//    public override string ToString()
//    {
//        return $"Diamond '{Name}': Вес={Weight} карат, Качество огранки={CutQuality} баллов";
//    }
//}

//class DiamondColor : Diamond
//{
//    public string Color { get; set; }
//    public DiamondColor(string name, double weight, int cutQuality, string color) : base(name, weight, cutQuality)
//    {
//        Color = color;

//    }
//    public override double Q()
//    {
//        if (Color == "голубой")
//        {
//            return base.Q() * 1.5;
//        }
//        else if (Color == "желтый")
//        {
//            return base.Q() - 0.5;
//        }
//        else
//        {
//            return base.Q();
//        }
//    }

//    public override string ToString()
//    {
//        return base.ToString() + $", Цвет: {Color}, Qp: {Q()}";
//    }

//}




try
{
    Console.WriteLine("Введите название diamond:");
    string name = Console.ReadLine()!;

    Console.WriteLine("Введите вес diamond в каратах:");
    double weight = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите качество огранки diamond (в баллах):");
    int cutQuality = Convert.ToInt32(Console.ReadLine());

    Diamond diamond = new Diamond(name!, weight, cutQuality);
    double Q = diamond.Q();
    Console.WriteLine($"Значение Q для diamond: {Q}");
    Console.WriteLine(diamond.ToString());

    Console.WriteLine("\nВведите цвет diamond:");
    string color = Console.ReadLine()!;

    DiamondColor diamondColor = new DiamondColor(name!, weight, cutQuality, color!);
    double Qp = diamondColor.Q();
    Console.WriteLine($"Значение Q для diamond второго класса: {Qp}");
    Console.WriteLine(diamondColor.ToString());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
    
class Diamond
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public int CutQuality { get; set; }

    public Diamond(string name, double weight, int cutQuality)
    {
        Name = name;
        Weight = weight;
        CutQuality = cutQuality;
    }

    public virtual double Q()
    {
        return 0.4 * Weight + 0.6 * CutQuality;
    }

    public override string ToString()
    {
        return $"Алмаз '{Name}': Вес={Weight} карат, Качество огранки={CutQuality} баллов";
    }
}

class DiamondColor : Diamond
{
    public string Color { get; set; }

    public DiamondColor(string name, double weight, int cutQuality, string color) : base(name, weight, cutQuality)
    {
        Color = color;
    }

    public  double Qp()
    {
        double Q = base.Q();

        if (Color == "blue")
        {
            return Q + 1;
        }
        else if (Color == "yellow")
        {
            return Q - 0.5;
        }
        else
        {
            return Q;
        }
    }


    public override string ToString()
    {
        return base.ToString() + $", Цвет={Color}";
    }
}
