using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour
{

	public float range;


	private
	// Use this for initialization
	void Start()
	{

		transform.position = new Vector3(transform.position.x,
		                                 transform.position.y - range * Random.value,
		                                 transform.position.z);

	}

	void Update()
	{

		transform.position = new Vector3(transform.position.x - 0.1f,
		                                 transform.position.y ,
		                                 transform.position.z);
		Destroy(gameObject,7.0f);
	}


}
