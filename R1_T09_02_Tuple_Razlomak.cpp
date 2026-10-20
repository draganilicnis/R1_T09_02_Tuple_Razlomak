#include <iostream>
#include <cmath>
#include <tuple>

using namespace std;

using Razlomak = tuple<int, int>;

int NZD(int a, int b)
{
    while (b != 0)
    {
        int tmp = a % b;
        a = b;
        b = tmp;
    }
    return a;
}

void skrati(Razlomak &r)
{
    int nzd = NZD(get<0>(r), get<1>(r));
    int br = get<0>(r) / nzd;
    int im = get<1>(r) / nzd;

    r = make_tuple(br, im);
    // return r;
}

Razlomak ucitaj()
{
    char c;
    int br, im;
    cin >> br >> c >> im;
    Razlomak r = make_tuple(br, im);
    skrati(r);
    return r;
}

void ispisi(const Razlomak &r)
{
    cout << get<0>(r) << "/" << get<1>(r) << endl;
}

Razlomak saberi(const Razlomak &a, const Razlomak &b)
{
    int br = get<0>(a) * get<1>(b) + get<1>(a) * get<0>(b);
    int im = get<1>(a) * get<1>(b);
    Razlomak r = make_tuple(br, im);
    skrati(r);
    return r;
}

Razlomak mnozi(const Razlomak &a, const Razlomak &b)
{
    int br = get<0>(a) * get<0>(b);
    int im = get<1>(a) * get<1>(b);
    Razlomak r = make_tuple(br, im);
    skrati(r);
    return r;
}

int main()
{
    Razlomak a = ucitaj();
    Razlomak b = ucitaj();
    ispisi(saberi(a, b));
    ispisi(mnozi(a, b));
    return 0;
}
