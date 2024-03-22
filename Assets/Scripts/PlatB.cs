using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatB : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            colisao.transform.SetParent(this.transform);
        }

    }
    void OnCollisionExit2D(Collision2D colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            colisao.transform.SetParent(null);
        }
    }
}
