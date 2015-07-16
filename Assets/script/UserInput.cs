using UnityEngine;
using System.Collections;

public class UserInput : MonoBehaviour {

	public float curSpeed = 0f;

	void Update () {
	
		if(Input.GetKey(KeyCode.W)){
			transform.forward = new Vector3( 0f, 0f, 1f );
			transform.position += new Vector3( 0f, 0f, 1f ) * Time.deltaTime * curSpeed;


		}

		if(Input.GetKey(KeyCode.S)){
			transform.forward = new Vector3( 0f, 0f, -1f );
			transform.position += new Vector3( 0f, 0f, -1f ) * Time.deltaTime * curSpeed;


		}

		if(Input.GetKey(KeyCode.A)){
			transform.forward = new Vector3 ( -1f, 0f, 0f);
			transform.position += new Vector3( -1f, 0f, 0f ) * Time.deltaTime * curSpeed;
		}

		if(Input.GetKey(KeyCode.D)){
			transform.forward = new Vector3( 1f, 0f, 0f );
			transform.position += new Vector3( 1f, 0f, 0f ) * Time.deltaTime * curSpeed;
		}

	}
}
