using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonKontrol : MonoBehaviour
{
    public Text Score,HighScore;
    ZamanKontrol ZamanKontrolS;

    private void Start()
    {
        ZamanKontrolS = GameObject.Find("Scripts").GetComponent<ZamanKontrol>();
        Score.text = ""+PlayerPrefs.GetInt("puan");
        HighScore.text = "" + PlayerPrefs.GetInt("puan1");
    }
    public void DigerSahne()
    {
        SceneManager.LoadScene("Oyun");
    }

    public void AnaMenuSahne()
    {
        SceneManager.LoadScene("Baslangic");
    }
}
