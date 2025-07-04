using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 1f;

    private Rigidbody2D rig;

    public GameObject gameover;

    public AudioSource audiofly;

    public AudioSource audiogameover;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            audiofly.Play();

            rig.velocity = Vector2.up * speed;
        }
    }

    private void OnCollisionEnter2D(Collision2D colission)
    {
        audiogameover.Play();

        gameover.SetActive(true);

        Time.timeScale = 0;
    }
}
