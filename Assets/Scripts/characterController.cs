using UnityEngine;
using System.Collections;

public class characterController : MonoBehaviour {
	public Vector2 speed = new Vector2 (0,0);
	public Vector2 force = new Vector2 (-1,0);
	public Vector3 angles;
	Rigidbody2D body;
	GameObject obj;



	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D>();
		obj = GetComponent<GameObject> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		float move = Input.GetAxis ("Horizontal");
		speed = body.velocity;
		body.AddForce (force);

		transform.Rotate (new Vector3(0,0,-move));
		angles = transform.rotation.eulerAngles;
	}

}
