using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
	private Rigidbody2D rb;
	// The force which is added when the player jumps
	// This can be changed in the Inspector window
	public Vector2 jumpForce = new Vector2(0, 300);
	
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();

	}
	// Update is called once per frame
	void Update ()
	{
		// Touch jump
		foreach(Touch touch in Input.touches){	// Jump
			// need to try!!!
			if (touch.phase == TouchPhase.Began){
				rb.velocity = Vector2.zero;
				rb.AddForce(jumpForce);
			}
		}

		// Keyboard Jump
		if (Input.GetKeyUp("space"))
		{
			rb.velocity = Vector2.zero;
			rb.AddForce(jumpForce);
		}
	
		Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);

		// Die by being off screen
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			Die();
		}
	}
	
	// Die by collision
	void OnCollisionEnter2D(Collision2D other)
	{
		Die();
	}
	
	void Die()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}