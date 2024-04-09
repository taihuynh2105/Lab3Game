using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {

            Debug.Log("va cham bullet");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        
    }
}
