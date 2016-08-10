using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour {
	private const float Y_ANGLE_MIN = 0.0f;
	private const float Y_ANGLE_MAX = 200.0f;
	private const float X_ANGLE_MIN = 0.0f;
	private const float X_ANGLE_MAX = 200.0f;
	public Transform lookAt;
	public Transform camTransform;

	private Camera cam;

	private float distance = 10.0f;
	private float currentX = -15.0f;
	private float currentY = 15.0f;
	private float currentZ = 15.0f;
	private float sensitityX = -10.0f;
	private float sensitityY = -10.0f;

	private void start()
	{
		camTransform = transform;
		cam = Camera.main;
	}
	private void Update()
	{
		currentX += Input.GetAxis ("Mouse X");
		currentY += Input.GetAxis ("Mouse Y");
		currentY = Mathf.Clamp (currentY,Y_ANGLE_MIN,Y_ANGLE_MAX);
		currentX = Mathf.Clamp (currentX,X_ANGLE_MIN,X_ANGLE_MAX);
	}
	private void LateUpdate()
	{
		Vector3 dir = new Vector3 (0,1,-distance);
		Quaternion rotation = Quaternion.Euler (currentX,currentX,currentZ);
		camTransform.position = lookAt.position + rotation * dir;
		camTransform.LookAt (lookAt.position);

	}
}
