using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DuraklatmaKontrol : MonoBehaviour
{
    public GameObject pauseButton;
    public Button PauseKontrol;
    public Sprite Pause;
    void Start()
    {
        pauseButton.SetActive(false);
        PauseKontrol.GetComponent<Image>().sprite = Pause;
    }


    void Update()
    {
        
    }

    public void ButtonControl(string buton)
    {
        if (buton == "Pause")
        {
            pauseButton.SetActive(true);
            Time.timeScale = 0;

        }
        else if (buton == "DevamEt")
        {
            pauseButton.SetActive(false);
            Time.timeScale = 1;
        }
        else if (buton == "YenidenBasla")
        {
            SceneManager.LoadScene("Oyun");
            Time.timeScale = 1;
        }
        else if (buton == "AnaMenu")
        {
            SceneManager.LoadScene("Baslangic");
            Time.timeScale = 1;
        }
    }
}
