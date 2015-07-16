using UnityEngine;
using System.Collections;

public class CameraOrientation : MonoBehaviour {

	Quaternion rotation = Quaternion.identity;

	void Start () {
		rotation = transform.rotation;
	}
	

	void LateUpdate () {
		transform.rotation = rotation;
	}
}
