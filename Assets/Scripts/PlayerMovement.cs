using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	
	
	public float speed = 5f;
	public GameObject menu;
	public float torque;
	public Rigidbody plane;


	private Rigidbody rb;
	private int score;

	// Use this for initialization
	void Start () {

			}

	void OnTriggerEnter(Collider other)
	{
		
	}

	void SetscoreText()
	{
		
	}

	
	// Update is called once per frame
	void Update () {
		float temp = Input.acceleration.x;

		transform.Translate (1 * 5f, 0, 0);
		transform.Rotate (-temp * speed, 0, 0);
	}

	void FixedUpdate() {
		float side = Input.GetAxis ("Vertical");
		plane.AddTorque (transform.forward * torque * side);
		float side2 = Input.GetAxis ("Horizontal");
		plane.AddTorque (transform.right * torque * side2);
	}
}
