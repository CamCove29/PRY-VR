using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class FruitSpawnerBehaviour : MonoBehaviour
{
	public float spawnInterval;
	private float timer, interval;
	public GameObject[] prefabs;
	public float shotStrength;
	private AudioTrigger shotSound;

    // Start is called before the first frame update
    void Start()
    {
        interval = spawnInterval;
		shotSound = GetComponent<AudioTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<interval)
		{
			timer += Time.deltaTime;
		}
		else
		{
			timer-=interval;
			interval = Random.Range(2.0f, 10.0f);
			spawnFruit();
		}
    }

	private void spawnFruit()
	{
		shotSound.PlayAudio();
		GameObject cannonFruit = Instantiate(prefabs[Random.Range(0,prefabs.Length)], gameObject.transform);
		Rigidbody rb = cannonFruit.GetComponent<Rigidbody>();
		rb.AddForce(cannonFruit.transform.forward*shotStrength, ForceMode.Impulse);
		rb.AddTorque(cannonFruit.transform.right * Random.Range(0.2f, 0.4f) + cannonFruit.transform.up * Random.Range(0.5f, 1f), ForceMode.Impulse);
	}
}
