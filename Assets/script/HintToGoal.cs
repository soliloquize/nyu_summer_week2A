using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HintToGoal : MonoBehaviour {

	public Text hintText;
	public Text currentText;
	bool firstGoThrough = false;
	public Transform landmark1;
	public Transform landmark2;
	public Transform landmark3;
	public Transform landmark4;
	public Transform landmark5;

	void Update () {


		if (transform.position.x < -115f || transform.position.z > 110f) {

			currentText.text = "Too far away to the treasure, come back!";

		} else 
	
		if ( transform.position.x < 10f && transform.position.x > -10f
		    && transform.position.z < 10f && transform.position.z > -10f ) {

		    if ( firstGoThrough == false){

			currentText.text = "Welcome to the mysterious islands of the Heart of Star!"
					+ "\n Well, what is the Heart of Star?"
					+ "\n It is the greatest treasure in this world!"
					+ "\n As a hunter, you are finding it, and " 
					+ "\n ... become the greatest hunter in this world!" ;

			} else if ( firstGoThrough == true){

				currentText.text = "Welcome back."
					+ "\n Seems like you are a little bit lost?" 
					+ "\n There are something you may interested in to the sourth.";

			}
		}

		if ( transform.position.x < 30f && transform.position.x > -20f &&  
		    transform.position.z > 18f && firstGoThrough == false) {

			currentText.text = "Yes, you do have magical strength to cross the montains,"
					+ "\n but hunter, remember,"
					+ "\n that does no good for your treasure hunting."
					+ "\n Believe me.";

			firstGoThrough = true;

		}


		if (transform.position.x < 30f && transform.position.x > -20f &&  
		    transform.position.z < -20f && firstGoThrough == false){

			currentText.text = "You are a good hunter, for now." 
					+ "\n There is a landmark aiming somewhere."
					+ "\n Which side?"
					+ "\n Well, you'll see";

		}
		if (transform.position.x < 30f && transform.position.x > -20f &&  
		    transform.position.z <  -18f && transform.position.z > -30f 
		    && firstGoThrough == true) {

			currentText.text = "That's right.  " ;

		}

		if ( Vector3.Distance (transform.position, landmark1.position) < 10f) {
			currentText.text = "Ahh, you find me."
					+ "\n I am your friend to guid you to the treasure."
					+ "\n I am trying my best to point to the way to go to the Heart of Star."
					+ "\n You will see my other siblings if you are on the right way!";

		}
		if ( Vector3.Distance (transform.position, landmark2.position) < 10f) {
			currentText.text = "Aha, you are smart!" +
				"\n You are on the right track." +
				"\n Keep going!" +
				"\n (And please do not go across the montains, please!";

		}

		if (transform.position.x < -59f && transform.position.x > -89f 
		    && transform.position.z > -20f) {

			currentText.text = "Hunter, hunter!" +
				"\n You may on the wrong way!" +
				"\n Try some way else!";
		}

		if ( Vector3.Distance (transform.position, landmark3.position) < 10f) {
			currentText.text = "See me = see the light!";

		}
		if ( Vector3.Distance (transform.position, landmark4.position) < 10f) {
			currentText.text = "I can make everyone great hunters, right?" +
				"\n I'm glad that you agree.";

		}
		if ( Vector3.Distance (transform.position, landmark4.position) < 10f) {
			currentText.text = " You are very close to the greatest treasure!"
				+ "\n Keep going this way!";

		}




		hintText.text = currentText.text;




	}
}
