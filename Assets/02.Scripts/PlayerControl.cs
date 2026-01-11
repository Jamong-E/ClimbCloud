using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameObject Camera;
    float jumpForce = 680.0f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A)) { rb.AddForce(transform.right * -1, ForceMode2D.Force); }
        if (Input.GetKey(KeyCode.D)) { rb.AddForce(transform.right * 1, ForceMode2D.Force); }
        if (Input.GetKeyDown(KeyCode.Space)) { rb.AddForce(transform.up * jumpForce); }


        Camera.transform.Translate(0, transform.position.y - Camera.transform.position.y, 0);
    }

    /*public GameObject Camera;
    static float vertPower = 0.5f;
    bool jump = false;
    float vert = 0;
    float velocity = 0.1f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;

        if (Input.GetKey(KeyCode.A)) { transform.Translate(velocity * -1, 0, 0); }
        if (Input.GetKey(KeyCode.D)) { transform.Translate(velocity, 0, 0); }
        if (!jump && Input.GetKeyDown(KeyCode.Space)) { jump = true; vert = vertPower; }
        if (jump)
        {
            VertMove(vert);
            if (vert > -1.0f) { vert -= 0.02f; }
        }
        if (transform.position.y < -1) { VertMove(3 - transform.position.y); }
    }
    public void VertMove(float v)
    {
        Camera.transform.Translate(0, v, 0);
        transform.Translate(0, v, 0);
    }
    public void Heading (float h)
    {
        VertMove(0.75f + h - transform.position.y);        // Å° 0.75Á¤µµ
        vert = 0;
        Debug.Log("²á");
    }
    public void Landed (float h)
    {
        VertMove(h - transform.position.y);
        vert = 0;
        jump = false;
    }*/
}
