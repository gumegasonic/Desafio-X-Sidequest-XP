using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
	public GameObject shoot_effect;
	public GameObject hit_effect;
	public float duration;
	[HideInInspector]
	public GameObject spawner;
	
	void Start() 
	{
		GameObject obj = (GameObject) Instantiate(shoot_effect, transform.position  - new Vector3(0,0,5), Quaternion.identity);
		obj.GetComponent<Follow>().spawnPoint = spawner;
		Destroy(gameObject, duration);
	}
	
	void Update()
	{
	
	}
	
	
	void OnTriggerEnter2D(Collider2D col) 
	{

		if (col.gameObject.tag != "Projectile") 
		{
			Instantiate(hit_effect, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}
	
	
	
}
