using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntoGecis : MonoBehaviour
{
    public GameObject intro;
    void Start()
    {
        intro.SetActive(true);
    }

    void Update()
    {
        StartCoroutine(Baslangic());
    }

    IEnumerator Baslangic()
    {
        yield return new WaitForSeconds(4.59f);
        intro.SetActive(false);
        SceneManager.LoadScene("Baslangic");
    }
}
