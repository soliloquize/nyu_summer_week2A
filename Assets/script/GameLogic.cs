using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameLogic : MonoBehaviour {

	public Transform player;
	public Text winText;

	void Update () {

		if (Input.GetKey(KeyCode.Space) && Vector3.Distance(player.position, transform.position) <= 5f ){
			winText.text = "YOU WIN!";
		}

	}
}
