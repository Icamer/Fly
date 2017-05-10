using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position = new Vector3 (0,2,0);
		transform.rotation = Quaternion.Euler (0.0f, 0.0f, 0.0f);
	}
}
