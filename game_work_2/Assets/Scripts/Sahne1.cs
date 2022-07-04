using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sahne1 : MonoBehaviour
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
            int SahneNo = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(SahneNo + 1);

        }
    }


}
