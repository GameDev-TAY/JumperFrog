using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float maxSpeed = 3f;
	public float rotSpeed = 90f;

	void Start () {
	
	}

	void Update() {
		
		var controler = GameObject.FindGameObjectWithTag("Frog").GetComponent<FrogController>();
		if (Input.GetKey(KeyCode.UpArrow))
		{
			controler.Jump();
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			controler.TurnRight();
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			controler.TurnLeft();
		}

		// ROTATE the ship.

		// Grab our rotation quaternion
		Quaternion rot = transform.rotation;

		// Grab the Z euler angle
		float z = rot.eulerAngles.z;

		// Change the Z angle based on input
		z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

		// Recreate the quaternion
		rot = Quaternion.Euler( 0, 0,z );

		// Feed the quaternion into our rotation
		transform.rotation = rot;

		// MOVE the frog.
		Vector3 pos = transform.position;
		Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);
		pos += rot * velocity;
		
		// Finally, update our position!!
		transform.position = pos;


	}
}
