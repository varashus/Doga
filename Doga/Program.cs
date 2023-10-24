namespace Doga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bolygok = new List<Bolygo>();
            using StreamReader sr = new StreamReader(
                path: @"..\..\..\src\solsys.txt",
                encoding: System.Text.Encoding.UTF8
                );
            while (!sr.EndOfStream)
            {
                bolygok.Add(new Bolygo(sr.ReadLine()));
            }



            //foreach (var x in bolygok)
            //{
            //    Console.WriteLine(x.bolygo);
            //}

            //1
            Console.WriteLine($"{bolygok.Count()} van a naprendszerben");
            //2
            double avarage = bolygok.Average(n => n.holdak);
            Console.WriteLine($"a naprendszerben egy bolygónak átlagosan {avarage} holdja van");
            //3
            var max = bolygok.OrderBy(n => n.terfogat).Last();
            Console.WriteLine($"A legnagyobb térfogatú bolygó a {max.bolygo}");
            //4
            Console.Write("Írd be a keresett bolygó nevét: ");
            var bolygonev = Console.ReadLine();
            Console.WriteLine(bolygok.SingleOrDefault(n => n.bolygo == bolygonev) != null ?
                "Van ilyen nevű bolygó a naprendszerben" :
                "Sajnos nincs ilyen nevű bolygó a naprendszerben");
            //5
            Console.Write("Írj be egy egész számot: ");
            var egesz = Convert.ToInt32(Console.ReadLine());
            var holdaktobb = bolygok.Where(b => b.holdak > egesz).Select(b => b.bolygo).ToArray();
            Console.WriteLine($"A következő bolygoknak van {egesz}-nél/nál több holdja:");
            foreach (var x in holdaktobb)
            {
                Console.Write($"{x},");
            }
        }
    }
}