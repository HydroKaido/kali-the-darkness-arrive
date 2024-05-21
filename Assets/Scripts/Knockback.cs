using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback1 : MonoBehaviour
{
public float knockbackForce = 10f;
    public float knockbackDuration = 0.5f;
    public float knockbackTimer;

    // Start is called before the first frame update
    void Start()
    {
        knockbackTimer = knockbackDuration;
    }

    // Update is called once per frame
    void Update()
    {
        if (knockbackTimer > 0)
        {
            knockbackTimer -= Time.deltaTime;
        }
    }

    public void KnockbackOn(Vector3 direction)
    {
        knockbackTimer = knockbackDuration;

        // Apply the knockback force
        GetComponent<Rigidbody>().AddForce(direction * knockbackForce, ForceMode.Impulse);
    }
}

