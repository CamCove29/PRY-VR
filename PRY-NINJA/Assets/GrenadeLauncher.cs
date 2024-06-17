using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeLauncher : MonoBehaviour
{
    public GameObject grenadePrefab;
    public Transform launchPoint;
    public float launchForce = 10f;
    public float spawnInterval = 2f;

    private void Start()
    {
        StartCoroutine(SpawnGrenades());
    }

    private IEnumerator SpawnGrenades()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            LaunchGrenade();
        }
    }

    private void LaunchGrenade()
    {
        GameObject grenade = Instantiate(grenadePrefab, launchPoint.position, launchPoint.rotation);
        Rigidbody rb = grenade.GetComponent<Rigidbody>();
        rb.AddForce(launchPoint.forward * launchForce, ForceMode.VelocityChange);
    }
}
