using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BalonPatlatma : MonoBehaviour
{
    public GameObject Patlama;
    ZamanKontrol ZamanKontrolS;
    KacanBalonKontrol kacanBalonK;
    public AudioClip patlama;
    private void Start()
    {
        ZamanKontrolS = GameObject.Find("Scripts").GetComponent<ZamanKontrol>();
        kacanBalonK = GameObject.Find("KaçanBalonKontrolü").GetComponent<KacanBalonKontrol>();
    }
    private void OnMouseDown()
    {
        GameObject go = Instantiate(Patlama, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.517f);
        if (this.gameObject.name.Equals("Balon(Clone)"))
        {
            ZamanKontrolS.BalonEkle();
        }
        else if (this.gameObject.name.Equals("Balong(Clone)"))
        {
            ZamanKontrolS.BalonEkle();
            ZamanKontrolS.SureEkle();
        }
        else if (this.gameObject.name.Equals("Balonm(Clone)"))
        {
            ZamanKontrolS.BalonEkle();
            kacanBalonK.CanEkle();
        }
        else if (this.gameObject.name.Equals("Balonk(Clone)"))
        {
            kacanBalonK.CanAzalt();
            AudioSource.PlayClipAtPoint(patlama, transform.position);
        }
        else if (this.gameObject.name.Equals("Balonh(Clone)"))
        {
            ZamanKontrolS.SureAzalt();
            AudioSource.PlayClipAtPoint(patlama, transform.position);
        }
        else if (this.gameObject.name.Equals("Balons(Clone)"))
        {
            SceneManager.LoadScene("Bitis");
        }
    }
}
