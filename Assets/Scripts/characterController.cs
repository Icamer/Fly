using UnityEngine;
using System.Collections;

public class characterController : MonoBehaviour {
	public Vector2 speed = new Vector2 (0,0);
	public Vector2 force = new Vector2 (-200,0);
	public Vector3 angles;
	bool land = false;
	int counter = 0;
	Time start, stop;
	Rigidbody2D body;
	GameObject obj;




	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D>();
		obj = GetComponent<GameObject> ();
	}
	void Update(){
		
	}
	// Update is called once per frame


	void FixedUpdate () {
		float move = Input.GetAxis ("Horizontal");
		speed = body.velocity;
		body.AddForce (force);

		transform.Rotate (new Vector3(0,0,-move));
		angles = transform.rotation.eulerAngles;

		Booster ();

	}
	void OnCollisionExit2D(Collision2D c){

		land = false;
	}
	void OnCollisionStay2D(Collision2D c){
		if (c.gameObject.tag == "floor") {
			counter++;

			land = true;
			if (counter > 300) {
				counter = 0;
				Debug.Log ("READDY");
				//Application.LoadLevel("Level");
			}


		}
	}

	void ProvideItemset(){
		body.mass = 1;
		body.gravityScale = 5;
	}
	void Booster(){
		if (Input.GetKey ("space") && land == false ){
			Debug.Log ("wow");
//			body.AddForce (new Vector2 (100,0));
			body.AddForce(transform.right * 500);
		}
	}




}
/*

if (start < 0.0f) {
				start = Time.time;
			} else{
				if (stop < 0.0f) {
					stop = Time.time;
				} else {
					if (stop - start > 2) {
						Debug.Log ("READDY");
						//Application.LoadLevel("Levelname");
						start = 0.0f;
						stop = 0.0f;
					}
				}
				
			}
*/