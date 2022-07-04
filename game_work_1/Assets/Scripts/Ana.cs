using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ana : MonoBehaviour
{
    Rigidbody rb;
    float guc;

    float yatay;
    float dikey;

    void Start() //sadece bir defa calisir..
    {
        //script dosyasınını hangi nesneye atıyorsak onun butun ozelliklerini cekmek ıcın yazdıgımı yapı "gameobject"..
        rb = gameObject.GetComponent<Rigidbody>();  //bir nesnenin herhangi bir bileşenini alabilmek icin getcomponent kullanılır..

        //varsayılan ilk degerleri..
        guc = 5.0f;
        yatay = 0.0f;
        dikey = 0.0f;

    }

    
    void Update() //fiziksel kurala gore hareket etmez..
    {
        //degiskenin degerlerini almak icin..
        yatay = Input.GetAxis("Horizontal"); //saga sola hareket..
        //Debug.Log(yatay);  //yataydaki hareketini gormek icin..
        dikey = Input.GetAxis("Vertical"); //ileri geri hareket..
    }

    private void FixedUpdate() //fiziksel hareket vardır..
    {
        //klavyeden once degerleri alıp sonra haerket ettiriyoruz..
        //kureye guc uygulayıp nesneyi hareket ettiriyoruz..
        rb.AddForce(yatay * guc, 0, dikey * guc); //x ve z eksenlerine deger verip y eksenini sabit tutuyoruz..
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cube")
        {
            Debug.Log("Duvara carptınız");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Cube")
        {
            Debug.Log("Duvardan çıktınız");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Cube")
        {
            Debug.Log("Duvarın içindesiniz");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ozel")
        {
            Debug.Log("Ozel alana girdiniz.");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ozel")
        {
            Debug.Log("Ozel alandan çıktınız.");
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ozel")
        {
            Debug.Log("Ozel alan içerisindesiniz.");
        }
    }





}
