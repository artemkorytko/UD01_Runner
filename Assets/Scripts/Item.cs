using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item : MonoBehaviour
{
	[SerializeField] public enum ItemTypes { Jewel, Health };
	[SerializeField] private ItemTypes CollectibleType;
	[SerializeField] private bool rotate;
	[SerializeField] private float rotationSpeed;
	[SerializeField] private AudioClip collectSound;
	[SerializeField] private GameObject collectEffect;

	private void Update()
	{
		if (rotate)
			transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Collect();
		}
	}

	private void Collect()
	{
		if (collectSound)
			AudioSource.PlayClipAtPoint(collectSound, transform.position);
		if (collectEffect)
			Instantiate(collectEffect, transform.position, Quaternion.identity);


		if (CollectibleType == ItemTypes.Jewel)
		{
			Debug.Log("Jewel");
		}
		if (CollectibleType == ItemTypes.Health)
		{
			Debug.Log("Health");
		}
		
		Destroy(gameObject);
	}
}
