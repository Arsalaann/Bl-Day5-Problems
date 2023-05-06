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
        public static void Main(string [] args){
            Program obj=new Program();
            Console.Write("Enter number of flips: ");
            int flips=Convert.ToInt32(Console.ReadLine());
            obj.FlipCoin(flips);
        }
    }
}