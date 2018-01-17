using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {
    public float jumpForce = 100f;
    public float forwardSpeed = 2f;
    bool dead = false;
    public GameObject cam;
    Rigidbody2D rb;
    // Use this for initialization
    void Start () {
        //Debug.Log("Start");
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (dead == false)
        {
            cam.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
            rb.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(Vector2.up * jumpForce);
            }
        }
        if (rb.transform.position.x >25)
        {
            dead = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        dead = true;
    }

}
