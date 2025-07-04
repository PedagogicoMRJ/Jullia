using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    private Animator anim;
    public float jumpforce;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collison)
    {
        if(collison.gameObject.tag == "Player")
        {
            collison.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);
            anim.SetTrigger("Pump");
        }
    }
}
