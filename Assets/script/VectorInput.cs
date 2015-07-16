using UnityEngine;
using System.Collections;

public class VectorInput : MonoBehaviour {

	public float speed = 5f;
	public float shiftSpeed = 0f;


	void Update () {
	
		float actualSpeed = speed;
		if(Input.GetKey(KeyCode.LeftShift)){
			actualSpeed = shiftSpeed;
		} else if(Input.GetKeyUp(KeyCode.LeftShift)){
			actualSpeed = speed; 
		}
		//GetComponent<Transform>().position += new Vector3 (0f, 0f, 1f);

		//this code is FRAMERATE DEPENDENT
		// = behavior will be different based on your framerate
		//transform.position += new Vector3 ( 0f, 0f, 1f );

		// FRAME INDEPENDENT, multiply by Time.deltaTime
		// Time.deltaTime = "fraction of a second in between a frame"
		// 60 FPS >> Time.deltaTime =~ 16ms
		// 10 FPS >> Time.deltaTime =~ 100ms



		if (Input.GetKey(KeyCode.W)){
			transform.position += new Vector3 ( 0f, 1f, 0f ) * Time.deltaTime * actualSpeed;
		}
		if (Input.GetKey(KeyCode.S)){
			transform.position += new Vector3 ( 0f, -1f, 0f ) * Time.deltaTime * actualSpeed;
		}
		if (Input.GetKey(KeyCode.A)) {
			transform.position += new Vector3 ( -1f, 0f, 0f ) * Time.deltaTime * actualSpeed;
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 ( 1f, 0f, 0f ) * Time.deltaTime * actualSpeed;
		}

		
	}
}
