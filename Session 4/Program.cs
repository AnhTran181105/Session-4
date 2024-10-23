internal class Session_4 ()
{
    public static void Main ()
    {
        rd();
    }
    public static void rd()
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
}
