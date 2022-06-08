using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KacanBalonKontrol : MonoBehaviour
{
    public Text canSayisi;
    public GameObject Patlama;
    public float can;
    public AudioClip canAlma;
    void Start()
    {
        can = 3;
    }

    public void Update()
    {
        canSayisi.text = can.ToString();
        if(can <= 0)
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for (int i = 0; i < go.Length; i++)
            {
                Instantiate(Patlama, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
                SceneManager.LoadScene("Bitis");
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Balon(Clone)"))
        {
            can--;
        }
    }

    public void CanEkle()
    {
        if (can < 3)
        {
            can++;
            AudioSource.PlayClipAtPoint(canAlma, transform.position);
        }
    }

    public void CanAzalt()
    {
        can--;
    }
}
