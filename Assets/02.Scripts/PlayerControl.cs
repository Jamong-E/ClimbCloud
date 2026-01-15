using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameObject Goal;
    public GameObject Camera;
    float walkSpeed = 2.5f;
    float jumpForce = 500.0f;

    void Start()
    {
        SceneManager.UnloadSceneAsync("ClearScene");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)) { rb.velocity = new Vector2(-1 * walkSpeed, rb.velocity.y); }
        else if (!Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)) { rb.velocity = new Vector2(walkSpeed, rb.velocity.y); }
        if (Input.GetKeyDown(KeyCode.Space)) { rb.AddForce(transform.up * jumpForce); }
        if (transform.position.y < -5) { transform.Translate(0, 0 - transform.position.y, 0); }


        Camera.transform.Translate(0, transform.position.y - Camera.transform.position.y, 0);
    }

    void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("가동");
        if (collision.gameObject.name == "flag") {
            SceneManager.LoadScene("ClearScene");
        }
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
        VertMove(0.75f + h - transform.position.y);        // Ű 0.75����
        vert = 0;
        Debug.Log("��");
    }
    public void Landed (float h)
    {
        VertMove(h - transform.position.y);
        vert = 0;
        jump = false;
    }*/
}
