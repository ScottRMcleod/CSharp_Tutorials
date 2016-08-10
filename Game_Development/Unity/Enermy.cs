using UnityEngine;
using System.Collections;
public class Enermy : MonoBehaviour {
	public Transform[] Partol_Point;
	public float moveSpeed;
	private int currentPoint;
	// Use this for initialization
	void Start () {
		transform.position = Partol_Point[0].position;
		currentPoint = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position == Partol_Point[currentPoint].position)
		{
			//increments points
			currentPoint++;
		}

		if (currentPoint >= Partol_Point.Length) 
		{
			currentPoint = 0;
		}

		transform.position = Vector3.MoveTowards (transform.position, Partol_Point [currentPoint].position, moveSpeed = Time.deltaTime);
	}
}
