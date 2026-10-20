using System;

using Razlomak = System.Tuple<int, int>;

class R1_T09_02_Tuple_Razlomak
{
    static Razlomak ucitaj()
    {
        string[] s = Console.ReadLine().Split('/');
        int brojilac = int.Parse(s[0]);
        int imenilac = int.Parse(s[1]);
        Razlomak r = Tuple.Create(brojilac, imenilac);
        r = skrati(r);
        return r;
    }
    static void ispisi(Razlomak r)
    {
        Console.WriteLine(r.Item1 + "/" + r.Item2);
    }
    static Razlomak saberi(Razlomak r1, Razlomak r2)
    {
        Razlomak r = Tuple.Create(r1.Item1 * r2.Item2 + r1.Item2 * r2.Item1, r1.Item2 * r2.Item2);
        return skrati(r);
    }
    static Razlomak mnozi(Razlomak r1, Razlomak r2)
    {
        Razlomak r = Tuple.Create(r1.Item1 * r2.Item1, r1.Item2 * r2.Item2);
        return skrati(r);
    }
    static int NZD(int a, int b)
    {
        while (b != 0)
        {
            int p = a % b;
            a = b;
            b = p;
        }
        return a;
    }
    static Razlomak skrati(Razlomak r1)
    {
        int nzd = NZD(r1.Item1, r1.Item2);
        Razlomak r = Tuple.Create(r1.Item1 / nzd, r1.Item2 / nzd);
        return r;
    }
    static void Main()
    {
        Razlomak r1 = ucitaj();
        Razlomak r2 = ucitaj();
        ispisi(saberi(r1, r2));
        ispisi(mnozi(r1, r2));
    }
}

// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka/razlomci
// https://arena.petlja.org/sr-Latn-RS/competition/r2-t09-strukture-21#tab_132694
// https://arena.petlja.org/sr-Latn-RS/competition/r2-t09-strukture#tab_132694 
// https://arena.petlja.org/competition/r1-09-02-torke#tab_132694
