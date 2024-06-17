using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class SaberHitBehaviour : MonoBehaviour
{
	private AudioTrigger sliceSound;
    // Start is called before the first frame update
    void Start()
    {
		sliceSound = GetComponent<AudioTrigger>();
	}

    // Update is called once per frame
    void Update()
    {

    }
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Fruit"))
		{
			sliceSound.PlayAudio();
		//print("Slice!!!");
		}
	}
}
