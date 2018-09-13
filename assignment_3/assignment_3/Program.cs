using System;

namespace assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //(b)
            Pair<String, int> name1 = new Pair<string, int>("Bent", 1);

            //(c)
            Pair<String, double> name2 = new Pair<string, double>("Bente", 2.4);

            //(d)
            //You cannot implicitly convert the one pair type to the other.
            //the pairs doesn't know what it is supposed to do with the different types.
            //name2 = name1;
            Console.WriteLine("Name 1: "+name1);

            //(e)
            Pair<String, int> p1 = new Pair<String, int>("Alex", 1);
            Pair<String, int> p2 = new Pair<String, int>("Bo", 2);
            Pair<String, int> p3 = new Pair<String, int>("Chris", 3);
            Pair<String, int> p4 = new Pair<String, int>("Dennis", 4);
            Pair<String, int> p5 = new Pair<String, int>("Erik", 5);

            Pair<String, int>[] grades = new Pair<string, int>[5];
            grades[0] = p1;
            grades[1] = p2;
            grades[2] = p3;
            //grades[3] = p4;
            //grades[4] = p5;

            //(f)
            //The empty elements return a pair of an empty string (or null) and the number 0
            //String can be null, int cannot so it is 0.
            foreach (var item in grades)
            {
                Console.WriteLine(item.ToString());
            }

            //(g)
            //appointment.first.second is a int type. You can check with GetType().
            Pair<Pair<int, int>, String> appointment = new Pair<Pair<int, int>, string>(new Pair<int, int>(3, 4), "to hell with this");           
            Console.WriteLine(appointment.first.second.GetType());

            //(h)
            Pair<String, Boolean> swapPair = new Pair<string, bool>("watch me", false);
            Console.WriteLine(swapPair.Swap().ToString());
            Pair<Boolean, String> swapPair2 = swapPair.Swap();
        }
    }

    //(a)
    public struct Pair<T, U>
    {
        public readonly T first;
        public readonly U second;

        public Pair(T fst, U snd)
        {
            first = fst;
            second = snd;
        }
        
        //(h)
        public Pair<U,T> Swap()
        {
            return new Pair<U, T>(second, first);
        }

        public override string ToString()
        {
            return "(" + first + ", " + second + ")";
        }
    }
}
