using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed;
    //public int damage;
    public Rigidbody2D rb;
    //public Collider2D target; //was gonna use this to save sharks prefab
    public int damage = 100;

    // Use this for initialization
    void Start()
    {
        rb.linearVelocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        Shark shark = hit.GetComponent<Shark>();
        Debug.Log(hit.name); //used this to find the target exact name lol
        if (hit.name == "Shark(Clone)") {//theres a probably more accurate way to do this but this works
            Destroy(gameObject);
            //shark.Die(); //destroy shark
            shark.TakeDamage(damage); //or use the damage system instead
        }
    }

}