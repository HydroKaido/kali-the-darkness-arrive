using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
        public float speed = 5f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal1");

        Vector2 pos = transform.position;

        pos.x += h * speed * Time.deltaTime;

        transform.position = pos;
    }

} // class
