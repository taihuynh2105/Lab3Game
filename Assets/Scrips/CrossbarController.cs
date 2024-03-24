using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossbarController : MonoBehaviour
{
    private int direction = 1;
    private float moveSpeed = 4;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0f, direction, 0f);
        transform.Translate(movement * moveSpeed * Time.deltaTime);
        if (transform.position.y > 1.9f || transform.position.y < -1.8f)
        {
            direction *= -1;
        }

    }
}
