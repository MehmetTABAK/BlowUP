using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ZamanKontrol : MonoBehaviour
{
    public float ZamanSayaci = 60;
    int patlayanBalon = 0;
    public Text zaman,balon;
    public GameObject Patlama;

    void Update()
    {
        if (ZamanSayaci>0)
        {
            ZamanSayaci -= Time.deltaTime;
            zaman.text = "SÜRE : " + (int)ZamanSayaci + "";
            if (ZamanSayaci < 13 && ZamanSayaci > 11)
            {
                GetComponent<AudioSource>().Play();
            }
        }

        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for (int i = 0; i < go.Length; i++)
            {
                Instantiate(Patlama, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
                SceneManager.LoadScene("Bitis");
            }
        }
        if (patlayanBalon < PlayerPrefs.GetInt("puan1"))
        {
            PlayerPrefs.SetInt("puan", patlayanBalon);
        }
        else
        {
            PlayerPrefs.SetInt("puan", patlayanBalon);
            PlayerPrefs.SetInt("puan1", patlayanBalon);
        }
    }

    public void BalonEkle()
    {
        if (ZamanSayaci > 30)
        {
            patlayanBalon += 1;
            balon.text = "BALON : " + patlayanBalon;
        }
        else if(ZamanSayaci>=15 && ZamanSayaci<30)
        {
            patlayanBalon += 2;
            balon.text = "BALON : " + patlayanBalon;
        }
        else if(ZamanSayaci<15)
        {
            patlayanBalon += 3;
            balon.text = "BALON : " + patlayanBalon;
        }
    }

    public void SureEkle()
    {
        if(ZamanSayaci<=50)
        ZamanSayaci += 10;
    }

    public void SureAzalt()
    {
        ZamanSayaci -= 10;
    }
}
