using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Baslangic : MonoBehaviour
{
    public Text HighScore;
    ZamanKontrol ZamanKontrolS;
    void Start()
    {
        ZamanKontrolS = GameObject.Find("Scripts").GetComponent<ZamanKontrol>();
        HighScore.text = "" + PlayerPrefs.GetInt("puan1");
    }

 
    public void DigerSahne()
    {
        SceneManager.LoadScene("Oyun");
    }

    public void OgreticiSahne()
    {
        SceneManager.LoadScene("Ogretici");
    }
}
