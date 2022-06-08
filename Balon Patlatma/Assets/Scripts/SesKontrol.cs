using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SesKontrol : MonoBehaviour
{
    public AudioSource ArkaPlanMuzik;
    public GameObject muzikButton;
    public Button SesKontolButon;
    public Sprite SesAcik;
    public Sprite SesKapali;
    public Button MuzikKontrolButon;
    public Sprite MuzikAcik;
    public Sprite MuzikKapali;
    bool ButonKontrolBool;
    bool MuzikKontrolBool;
    public Button SesKontrolu;
    public Sprite SesButon;

    void Start()
    {
        muzikButton.SetActive(false);
        SesKontrolu.GetComponent<Image>().sprite = SesButon;
        ButonKontrolBool = false;
        SesKontolButon.GetComponent<Image>().sprite = SesAcik;
        MuzikKontrolBool = false;
        MuzikKontrolButon.GetComponent<Image>().sprite = MuzikAcik;
        AudioListener.pause = false;
        if (PlayerPrefs.GetInt("sesDurum") == 1)
        {
            ButonKontrolBool = true;
            AudioListener.pause = true;
            SesKontolButon.GetComponent<Image>().sprite = SesKapali;
        }
        else if (PlayerPrefs.GetInt("sesDurum") == 0)
        {
            ButonKontrolBool = false;
            AudioListener.pause = false;
            SesKontolButon.GetComponent<Image>().sprite = SesAcik;
        }
        else if (PlayerPrefs.GetInt("sesDurum") == 3)
        {
            MuzikKontrolBool = true;
            ArkaPlanMuzik.GetComponent<AudioSource>().Pause();
            MuzikKontrolButon.GetComponent<Image>().sprite = MuzikKapali;
        }
        else if (PlayerPrefs.GetInt("sesDurum") == 2)
        {
            MuzikKontrolBool = false;
            ArkaPlanMuzik.GetComponent<AudioSource>().Play();
            MuzikKontrolButon.GetComponent<Image>().sprite = MuzikAcik;
        }
    }


    void Update()
    {

    }

    public void ButtonKontrol(string buton)
    {
        if (buton == "SesMenu")
        {
            muzikButton.SetActive(true);
        }
        else if (ButonKontrolBool == false)
        {
            ButonKontrolBool = true;
            AudioListener.pause = true;
            SesKontolButon.GetComponent<Image>().sprite = SesKapali;
            muzikButton.SetActive(false);
            PlayerPrefs.SetInt("sesDurum", 1);
        }
        else
        {
            ButonKontrolBool = false;
            AudioListener.pause = false;
            SesKontolButon.GetComponent<Image>().sprite = SesAcik;
            muzikButton.SetActive(false);
            PlayerPrefs.SetInt("sesDurum", 0);
        }
    }

    public void MuzikKontrol()
    {
        if (MuzikKontrolBool == false)
        {
            MuzikKontrolBool = true;
            ArkaPlanMuzik.GetComponent<AudioSource>().Pause();
            MuzikKontrolButon.GetComponent<Image>().sprite = MuzikKapali;
            muzikButton.SetActive(false);
            PlayerPrefs.SetInt("sesDurum", 3);
        }
        else
        {
            MuzikKontrolBool = false;
            ArkaPlanMuzik.GetComponent<AudioSource>().Play();
            MuzikKontrolButon.GetComponent<Image>().sprite = MuzikAcik;
            muzikButton.SetActive(false);
            PlayerPrefs.SetInt("sesDurum", 2);
        }
    }
}
