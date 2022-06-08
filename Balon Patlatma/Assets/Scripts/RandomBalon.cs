using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBalon : MonoBehaviour
{
    public GameObject Balon,Balonk,Balonm,Balons,Balong,Balonh;
    float OlusturmaSuresi;
    float OlusturmaSuresik;
    float OlusturmaSuresim;
    float OlusturmaSuresis;
    float OlusturmaSuresig;
    float OlusturmaSuresih;
    float ZamanSayaci = 0f;
    float ZamanSayacik = 5f;
    float ZamanSayacim = 11f;
    float ZamanSayacis = 21f;
    float ZamanSayacig = 14f;
    float ZamanSayacih = 9f;
    ZamanKontrol ZamanKontrolS;
    int hizlanma;
    float olusum,olusun;
    void Start()
    {
        ZamanKontrolS = this.gameObject.GetComponent<ZamanKontrol>();
    }

    void Update()
    {
        int katsayi = (int)(ZamanKontrolS.ZamanSayaci / 10);
        if(katsayi<5 && katsayi >= 4)
        {
            hizlanma = 50;
            olusum = -0.2f;
            olusun = -0.3f;
        }
        else if (katsayi<4 && katsayi>=3)
        {
            hizlanma = 70;
            olusum = -0.2f;
            olusun = -0.7f;
        }
        else if (katsayi<3 && katsayi>=2)
        {
            hizlanma = 100;
            olusum = -0.3f;
            olusun = -1f;
        }
        else if (katsayi<2 && katsayi>=1)
        {
            hizlanma = 130;
            olusum = -0.3f;
            olusun = -1.3f;
        }
        else if (katsayi<1)
        {
            hizlanma = 170;
            olusum = -0.4f;
            olusun = -1.7f;
        }

        OlusturmaSuresi = Random.Range(0.6f+olusum, 0.8f + olusum);
        ZamanSayaci -= Time.deltaTime;
        if (ZamanSayaci<0 && ZamanKontrolS.ZamanSayaci>0)
        {
            GameObject go = Instantiate(Balon, new Vector3(Random.Range(-2f, 2f), -6.5f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(120f+hizlanma, 150f+hizlanma), 0));
            ZamanSayaci = OlusturmaSuresi;
        }

        OlusturmaSuresik = Random.Range(7f + olusun, 15f + olusun);
        ZamanSayacik -= Time.deltaTime;
        if(ZamanSayacik < 0 && ZamanKontrolS.ZamanSayaci > 0)
        {
            GameObject go1 = Instantiate(Balonk, new Vector3(Random.Range(-2f, 2f), -6.5f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go1.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(100f + hizlanma, 150f + hizlanma), 0));
            ZamanSayacik = OlusturmaSuresik;
        }

        OlusturmaSuresim = Random.Range(9f + olusun, 19f + olusun);
        ZamanSayacim -= Time.deltaTime;
        if (ZamanSayacim < 0 && ZamanKontrolS.ZamanSayaci > 0)
        {
            GameObject go2 = Instantiate(Balonm, new Vector3(Random.Range(-2f, 2f), -6.5f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go2.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(100f + hizlanma, 150f + hizlanma), 0));
            ZamanSayacim = OlusturmaSuresim;
        }

        OlusturmaSuresis = Random.Range(20f + olusun, 40f + olusun);
        ZamanSayacis -= Time.deltaTime;
        if (ZamanSayacis < 0 && ZamanKontrolS.ZamanSayaci > 0)
        {
            GameObject go3 = Instantiate(Balons, new Vector3(Random.Range(-2f, 2f), -6.5f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go3.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(100f + hizlanma, 150f + hizlanma), 0));
            ZamanSayacis = OlusturmaSuresis;
        }

        OlusturmaSuresig = Random.Range(10f + olusun, 20f + olusun);
        ZamanSayacig -= Time.deltaTime;
        if (ZamanSayacig < 0 && ZamanKontrolS.ZamanSayaci > 0)
        {
            GameObject go4 = Instantiate(Balong, new Vector3(Random.Range(-2f, 2f), -6.5f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go4.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(100f + hizlanma, 150f + hizlanma), 0));
            ZamanSayacig = OlusturmaSuresig;
        }

        OlusturmaSuresih = Random.Range(11f + olusun, 25f + olusun);
        ZamanSayacih -= Time.deltaTime;
        if (ZamanSayacih < 0 && ZamanKontrolS.ZamanSayaci > 0)
        {
            GameObject go5 = Instantiate(Balonh, new Vector3(Random.Range(-2f, 2f), -6.5f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go5.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(100f + hizlanma, 150f + hizlanma), 0));
            ZamanSayacih = OlusturmaSuresih;
        }
    }
}
