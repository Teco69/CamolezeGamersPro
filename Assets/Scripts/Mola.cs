using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mola : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D colidir)
    {
        if (colidir.gameObject.CompareTag("Player"))
        {
            colidir.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 15, ForceMode2D.Impulse);
        }
    }
}
