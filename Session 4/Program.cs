using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

internal class Session_4 ()
{
    public static void Main ()
    {
        //random();
        //Session_4_ex_01();
        //Session_4_ex_02();
        //Session_4_ex_03();
        Session_4_ex_10();
    }
    public static void random()
    {
       
        Random rnd= new Random ();
        Console.Write("Nhap so ngau nhien:");
        int n =int.Parse(Console.ReadLine());
        int comp_num = rnd.Next(0, 10) + 1;
        bool ctn = true;
        while (ctn == true)
        {
            if (n == comp_num)
            {
                Console.WriteLine("Doan dung");
                Console.WriteLine("-----------------------");
                Console.Write("Choi nua ko(Co:C,Ko:K):");
                string a = Console.ReadLine();
                if (a.ToUpper().Equals("K"))
                {
                    Console.WriteLine("The thoi bye");
                    ctn = false;
                    return;
                }
                else
                {
                    Console.Write("Nhap so ngau nhien");
                    n = int.Parse(Console.ReadLine());
                    comp_num = int.Parse(Console.ReadLine());
                    continue;
                }

            }
            else
            {
                if (n < comp_num)
                {
                    Console.Write("So ban nhap be qua, nhap lai di:");
                    n = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("So ban nhap lon qua, nhap lai di:");
                    n = int.Parse(Console.ReadLine());
                }

            }

        }   
    }
    public static void Session_4_ex_01()
    {
        Console.Write("Nhap so:");
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 1) { Console.Write("So ban nhap la so le"); }
        else { Console.Write("So ban nhap la so chan"); }
    }
    public static void Session_4_ex_02() 
    {
        Console.Write("Nhap so thu nhat:");
        double a= double.Parse(Console.ReadLine());
        Console.Write("Nhap so thu hai:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhap so thu ba:");
        double c = double.Parse(Console.ReadLine());
        double d = 0;
        if (a > b) 
        {
            if (a>c) { Console.WriteLine("So thu nhat la so lon nhat"); }
        } 
        else
        {
            if (b < c) { Console.WriteLine("So thu ba la so lon nhat"); }
            else { Console.WriteLine("So thu hai la so lon nhat"); }
        }
    }
    public static void Session_4_ex_03() 
    {
        Console.Write("Nhap hoanh do:");
        double x= double.Parse(Console.ReadLine());
        Console.Write("Nhap tung do:");
        double y= double.Parse(Console.ReadLine());
        if (x > 0) 
        {
            if (y > 0) { Console.WriteLine("Diem nam o goc phan tu thu nhat"); }
            else
            {
                if (y < 0) { Console.WriteLine("Diem nam o goc phan tu thu tu"); }
                else { Console.WriteLine("Diem nam tren truc tung"); }
            }
        }
        else 
        {
            if (x==0)
            {
                if (y == 0) { Console.WriteLine("Diem la goc toa do"); }
                else { Console.WriteLine("Diem nam tren truc hoanh"); }
            }
            else
                {
                    if (y > 0) { Console.WriteLine("Diem nam o goc phan tu thu hai"); }
                    else
                    {
                        if (y < 0) { Console.WriteLine("Diem nam o goc phan tu thu ba"); }
                        else { Console.WriteLine("Diem nam tren truc tung"); }
                    }
                } 
                    
        }
                
    }
    public static void Session_4_ex_04() 
    {
        Console.Write("Nhap do dai canh dau tien:");
        double a= double.Parse(Console.ReadLine());
        Console.Write("Nhap do dai canh thu hai:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhap do dai canh thu ba:");
        double c = double.Parse(Console.ReadLine());
        if (a <= 0 || b <= 0 || c <= 0)
        {
            Console.WriteLine("Do dai khong hop le");
            return;
        }
        if (a + b <= c || a + c <= b || b + c <= a) 
        {
            Console.WriteLine("Do dai khong hop le");
            return;
        }
        if (a==b && b==c)
        {
            Console.WriteLine("Day la tam giac deu");
            return;
        }
        else
        {
            if (a==b||b==c||c==a) 
            {
                Console.WriteLine("Day la tam giac can");
                return;
            }
            else
            {
                Console.WriteLine("Day la tam giac khong can");
                return;
            } 
                
        } 
            
    }
    public static void Session_4_ex_05()
    {
        double i = 0;
        double s = 0;
        for (i=1;i<=10;i++)
        {
            Console.Write("Nhap so:");
            double n= double.Parse(Console.ReadLine());
            s = s + n;
        }
        Console.WriteLine($"Tong 10 so vua nhap la:{s}");
        Console.WriteLine($"TB 10 so vua nhap la:{s / 10}");
    }
    public static void Session_4_ex_06()
    {
        Console.Write("Nhap so nguyen");
        int n=int.Parse(Console.ReadLine());   
        for (int i=1;i<=10;i++)
        {
            Console.WriteLine($"{n}*{i}={n*i}");
        }    
    }
    public static void Session_4_ex_08() 
    {
        Console.Write("Nhap so :");
        double n=double.Parse(Console.ReadLine());
        double s = 0;
        for (double i = 1; i <= n; i++)
        {
            s = s+1 / i;
        } 
        Console.WriteLine($"Tong la:{s}");
    }
    public static void Session_4_ex_09()
    {
        Console.Write("Nhap so :");
        double n = double.Parse(Console.ReadLine());
        double s = 0;
        for (double i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                s = s + i + n / i;
            }
        }
        if (n % Math.Sqrt(n) == 0) { s = s - Math.Sqrt(n); }
        if (s/n==2) { Console.WriteLine("Day la so hoan hao"); }
        else  { Console.WriteLine("Day la khong so hoan hao"); }
    }
    public static void Session_4_ex_10()
    {
        Console.Write("Nhap so :");
        double n = double.Parse(Console.ReadLine());
        for (double i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine("Day khong phai so nguyen to");
                return;
            }
        }
    }
}
