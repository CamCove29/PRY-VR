using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeCollision : MonoBehaviour
{
    public GameObject explosionEffect; 
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (explosionEffect != null)
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
        }

        
        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Play();
        }

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Jugador impactado por la granada");

        }


        Destroy(gameObject, audioSource != null && audioSource.clip != null ? audioSource.clip.length : 0f);
    }
}
