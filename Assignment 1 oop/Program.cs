namespace Assignment_1_oop
{
    #region weekdayes
    //internal enum WeekDayes
    //{
    //    Monday ,
    //    Tuesday ,
    //    Wednesday ,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    sunday
    //}
    #endregion

    #region Season
    //internal enum Season
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter
    //}
    #endregion

    #region permission
    //[Flags]
    //internal enum Permissions : byte
    //{
    //    Read = 1,
    //    write = 2,
    //    Delete = 4,
    //    Execute = 8
    //}
    #endregion

    #region Colors
    //internal enum Colors
    //{
    //    Red = 1, Green = 2, Blue = 3
    //}
    #endregion

    #region struct 
    //internal struct Points
    //{
    //    int X;
    //    int Y;
    //    public Points(int a, int b)
    //    {
    //        X = a;
    //        Y = b;
    //    }
    //    public void distance ()
    //    {
    //        double d =  Math.Sqrt (Math.Pow (X, 2) + Math.Pow (Y, 2));
    //        Console.WriteLine (d);
    //    }
    //}
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region print enum of dayes

            //string[] dayes = Enum.GetNames(typeof(WeekDayes));
            //for (int i = 0; i < dayes.Length; i++) 
            //    Console.WriteLine(dayes[i]);
            //*********************************
            //foreach (WeekDayes dayes in Enum.GetValues(typeof(WeekDayes)))
            //{
            //    Console.WriteLine(dayes);
            //}
            #endregion

            #region displays the corresponding month range for that season

            //Enum.TryParse<Season>(Console.ReadLine(),true, out Season season);
            //if (season == Season.Spring)
            //    Console.WriteLine("spring march to may");
            //else if (season == Season.Autumn)
            //    Console.WriteLine("autumn September to November");
            //else if (season == Season.Winter)
            //    Console.WriteLine("winter December to February");
            //else if (season == Season.Summer)
            //    Console.WriteLine("summer june to august");
            #endregion

            #region Add and Remove Permission 
            //Permissions permission = Permissions.Read;
            //Enum .TryParse<Permissions>(Console.ReadLine(),true,out Permissions p);
            //if (( permission & p ) == permission )
            //{
            //    Console.WriteLine("Permission is existed inside variable");
            //}
            //else
            //{
            //    Console.WriteLine("Permission is not existed inside variable");
            //}
            //permission = permission ^ p;
            //Console.WriteLine(permission);
            #endregion

            #region displays a message  is a primary color or not
            //Enum.TryParse<Colors>(Console.ReadLine(),true , out Colors color);
            //if ((color & Colors.Red) == Colors.Red)
            //    Console.WriteLine($"{color} is a primary color");
            //else if ((color & Colors.Blue) == Colors.Blue)
            //    Console.WriteLine($"{color} is a primary color");
            //else if ((color & Colors.Green) == Colors.Green)
            //    Console.WriteLine($"{color} is a primary color");
            //else
            //    Console.WriteLine("the input color is not a primary color");

            #endregion

            #region calculates the distance between them.
            //int a = int.Parse (Console.ReadLine ());
            //int b = int.Parse(Console.ReadLine());
            //Points s = new Points (a, b);
            //s.distance ();
            #endregion


        }
    }
}
