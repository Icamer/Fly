using UnityEngine;
using System.Collections;

public class itemController : MonoBehaviour {
	public int xAdd=1000, yAdd=1000;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D c){

		Debug.Log ("Worked22");
		if (c.gameObject.tag == "Player") {
			Destroy (this.gameObject);
		}
		c.gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (xAdd, yAdd));

	}


}
