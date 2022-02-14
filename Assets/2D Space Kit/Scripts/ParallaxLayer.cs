using UnityEngine;
using System.Collections;

public class ParallaxLayer : MonoBehaviour {

	Vector3 wantedPosition;
	public float movement_resistance = 1f;

	void Start () 
	{
	
	}
	
	void FixedUpdate () {
		wantedPosition = Camera.main.transform.position * movement_resistance;
			wantedPosition.z = transform.position.z;
			transform.position = wantedPosition;
			
	}
}
