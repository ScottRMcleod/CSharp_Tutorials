using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float move_Speed;
	private Vector3 input;
	private float maxSpeed = 50f;
	private Vector3 spawn;
	public GameObject deathParticles;

	// Use this for initialization
	void Start () {
		spawn = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		input = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
		if(GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)
		{
			GetComponent<Rigidbody>().AddForce(input*move_Speed);
		}
		if (transform.position.y < - 2) 
		{
			Die();
		}

	}
	void OnCollisionEnter(Collision other)
	{
		if(other.transform.tag == "Enermy")
		{
			Die();
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Goal") 
		{
			GameManager.CompleteLevel();
		}
	}
	void Die()
	{
		Instantiate(deathParticles,transform.position,Quaternion.identity);
		transform.position = spawn;
	}
}

