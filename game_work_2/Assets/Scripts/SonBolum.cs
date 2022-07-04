using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SonBolum : MonoBehaviour
{
    Rigidbody rb;
    float guc;
    float yatay;
    float dikey;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        guc = 5.0f;
        yatay = 0.0f;
        dikey = 0.0f;

    }

    // Update is called once per frame
    void Update()
    {
        yatay = Input.GetAxis("Horizontal");
        dikey = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.AddForce(yatay * guc, 0, dikey * guc);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cikis")
        {
            string son = "Scenes/Sahne5";
            SceneManager.LoadScene(son);
            Debug.Log("TEBRİKLER");

        }
    }

}
