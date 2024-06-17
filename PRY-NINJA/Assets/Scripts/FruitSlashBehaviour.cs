using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class FruitSlashBehaviour : MonoBehaviour
{
	private ParticleSystem particleSystem;
	private MeshRenderer meshRenderer;
	private bool played_particle;
	private AudioTrigger splashSound;

    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
		meshRenderer = GetComponent<MeshRenderer>();
		played_particle = false;
		splashSound = GetComponentInChildren<AudioTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnCollisionEnter(Collision collision)
	{
		if(!played_particle)
		{
			splashSound.PlayAudio();
			particleSystem.Play();
			played_particle = true;
			meshRenderer.enabled = false;
		}
	}
}
