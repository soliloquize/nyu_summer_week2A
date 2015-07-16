using UnityEngine;
using System.Collections;

public class LandMarkDir : MonoBehaviour {

	public Transform goal;

	void Start () {
	
		Vector3 dir = goal.position - transform.position;
		transform.forward = dir;
	}

}
