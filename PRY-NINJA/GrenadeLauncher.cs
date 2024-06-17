using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeLauncher : MonoBehaviour
{
    public GameObject grenadePrefab;
    public float launchForce = 10f;
    public float spawnRate = 2f;

    private float nextSpawnTime = 0f;

    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            LaunchGrenade();
            nextSpawnTime = Time.time + 1f / spawnRate;
        }
    }

    void LaunchGrenade()
    {
        GameObject grenade = Instantiate(grenadePrefab, transform.position, transform.rotation);
        Rigidbody rb = grenade.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * launchForce, ForceMode.VelocityChange);
    }
}

