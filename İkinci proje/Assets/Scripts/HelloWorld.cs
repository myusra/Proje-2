using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    void sayilar(int sayi1, int sayi2)
    {
        ArrayList liste1 = new ArrayList();
        string ilkStr = "Tüm Liste = ";
        string ikiStr = "Ýkiye Bölünenler = ";
        string üçStr = "Üçe Bölünenler = ";
        string dörtStr = "Dörde bölünenler = ";
        string beþStr = "Beþe bölünenler = ";
        for (int i = sayi1; i <= sayi2; i++)
        {
            liste1.Add(i);
            ilkStr += i.ToString();
            ilkStr += " ";
        }

        foreach (int i in liste1)
        {
            if (i % 2 == 0)
            {
                ikiStr += i.ToString();
                ikiStr += " ";

            }
            if (i % 3 == 0)
            {
                üçStr += i.ToString();
                üçStr += " ";

            }
            if (i % 4 == 0)
            {
                dörtStr += i.ToString();
                dörtStr += " ";

            }
            if (i % 5 == 0)
            {
                beþStr += i.ToString();
                beþStr += " ";

            }
        }
        print(ilkStr);
        print(ikiStr);
        print(üçStr);
        print(dörtStr);
        print(beþStr);
    }

    void Start()
    {
        sayilar(20, 44);

    }

    void Update()
    {
        
    }
}
