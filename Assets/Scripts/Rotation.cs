using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	public float xSpeedR = 10;
	public float ySpeedR = 10;
	public float zSpeedR = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Input.GetAxis("Mouse Y") * ySpeedR,Input.GetAxis("Mouse X") * xSpeedR,0);
		//transform.Rotate(Input.GetAxis("Horizontal") * ySpeedR,Input.GetAxis("Vertical") * xSpeedR,0);
	}
}   
