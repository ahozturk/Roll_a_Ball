using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class topKontrol : MonoBehaviour
{
    public int hiz;
    Rigidbody fizik;
    int sayac = 0;
    public int toplanacakObjeSayisi;
    public Text sayacText;
    public Text oyunBitti;

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(yatay, 0, dikey);

        fizik.AddForce(vec*hiz);
        //Debug.Log("yatay = "+yatay+"          dikey = "+dikey);

        
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag=="engel")
        {
            Destroy(other.gameObject);
            sayac++;

            sayacText.text = "SAYAC = " + sayac;

            if(sayac == toplanacakObjeSayisi)
            {
                oyunBitti.text = "OYUN BITTI";
            }

        }
    }

}
