using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    void sayilar(int sayi1, int sayi2)
    {
        ArrayList liste1 = new ArrayList();
        string ilkStr = "T�m Liste = ";
        string ikiStr = "�kiye B�l�nenler = ";
        string ��Str = "��e B�l�nenler = ";
        string d�rtStr = "D�rde b�l�nenler = ";
        string be�Str = "Be�e b�l�nenler = ";
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
                ��Str += i.ToString();
                ��Str += " ";

            }
            if (i % 4 == 0)
            {
                d�rtStr += i.ToString();
                d�rtStr += " ";

            }
            if (i % 5 == 0)
            {
                be�Str += i.ToString();
                be�Str += " ";

            }
        }
        print(ilkStr);
        print(ikiStr);
        print(��Str);
        print(d�rtStr);
        print(be�Str);
    }

    void Start()
    {
        sayilar(20, 44);

    }

    void Update()
    {
        
    }
}
