using System;
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
            if(year>9999){
                Console.WriteLine("Invalid Year");
                return;
            }    
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

        void PrimeFactors(int n){
            for(int i=2;i<n;i++){
                int j=2;
                for(;j<i;j++)
                    if(i%j==0)
                        break;
                if(j==i && n%i==0)
                    Console.WriteLine(i);
            }
        }
        void FQR(int n,int a){
            Console.WriteLine("Quotient = "+(n/a)+"\nRemainder = "+(n%a));
        }
        void Swap(int a,int b){
            Console.WriteLine("Before a and b: "+a+" "+b);
            a=a+b;
            b=a-b;
            a=a-b;
            Console.WriteLine("After a and b: "+a+" "+b);
        }
        void OddEven(int n){
            if(n%2==0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
        void VowelOrConsonent(char c){
            if(c=='A' || c=='E' || c=='I' || c=='O' || c=='U' || c=='a' || c=='e' || c=='i' || c=='o' || c=='u')
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Consonent");
        }
        public static void Main(string [] args){
            Program obj=new Program();
            //Console.Write("Enter number: ");
            //int n=Convert.ToInt32(Console.ReadLine());
            // obj.FlipCoin(flips);
            // obj.LeapYear(year);
            // obj.PowerofTwo(n);
            // obj.HarmonicNumber(n);
            // obj.PrimeFactors(n);

            // Console.Write("Enter Divisor: ");
            // int a=Convert.ToInt32(Console.ReadLine());
            // obj.FQR(n,a);

            // Console.Write("Enter another number: ");
            // int a=Convert.ToInt32(Console.ReadLine());
            // obj.Swap(n,a);

            // obj.OddEven(n);\
            Console.Write("Enter Character: ");
            char c=Convert.ToChar(Console.ReadLine());;
            obj.VowelOrConsonent(c);
        }
    }
}