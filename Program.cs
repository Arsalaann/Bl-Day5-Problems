namespace BlDay5Problems{
    class Program{
        void FlipCoin(int flips){
            Random rnd=new Random();
            int outcome,heads=0,tails=0;
            for(int i=1;i<=flips;i++){
                outcome=rnd.Next(2);
                if(outcome==0)
                    tails++;
                else
                    heads++;
            }
            Console.WriteLine("Heads % = "+(heads*100/flips));
            Console.WriteLine("Tails % = "+(tails*100/flips));
        }
        void LeapYear(int year){
            if(year%4==0)
                Console.WriteLine("Yes");
            else   
                Console.WriteLine("No");
        }
        void PowerofTwo(int n){
            for(int i=1;i<=n && i<32;i++)
                Console.WriteLine(Math.Pow(Convert.ToDouble(2),Convert.ToDouble(i)));
        }
        void HarmonicNumber(int n){
            double ans=0;
            for(int i=1;i<=n;i++)
                ans+=Convert.ToDouble(1)/Convert.ToDouble(i);
            Console.WriteLine(ans);
        }
        public static void Main(string [] args){
            Program obj=new Program();
            // Console.Write("Enter number of flips: ");
            // int flips=Convert.ToInt32(Console.ReadLine());
            // obj.FlipCoin(flips);

            // int year=Convert.ToInt32(Console.ReadLine());;
            // if(year>9999)
            //     Console.WriteLine("Invalid year");
            // else
            //     obj.LeapYear(year);

            // Console.Write("Enter a number less than 32: ");
            // int n=Convert.ToInt32(Console.ReadLine());
            // obj.PowerofTwo(n);

            Console.Write("Enter a number: ");
            int n=Convert.ToInt32(Console.ReadLine());
            obj.HarmonicNumber(n);
        }
    }
}