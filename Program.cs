internal class Program
{
    private static void Main(string[] args)
    {
        Recursive instance = new Recursive();
            int n = 5;
            instance.F(n);
            Console.WriteLine(instance.F(n));


            
            string cumle = "guzel bir gun";
            bool sonuc = cumle.boslukKontrol();
            Console.WriteLine(sonuc);

            if (sonuc)
            {
                Console.WriteLine(cumle.boslukSil());

            }

            Console.WriteLine(cumle.buyukHarfCevir());
            Console.WriteLine(cumle.KelimeKes();)
        
    }   

}
public class Recursive
{
    public int F(int n)
        {
            if (n > 0)
            {
                return 3 * F(n - 1);
            }
            return 1;
        }
}
public static class Extentions
  {

    public static bool boslukKontrol(this string param)
    {
        return param.Contains(" ");
    }

    public static string boslukSil(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("*",dizi);
    }

    public static string buyukHarfCevir (this string param)
    {
        return param.ToUpper();

    }

    public static string KelimeKes(this string param)
    {
        return param.Substring(1,2);
    }
  }
