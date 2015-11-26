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
		transform.Rotate(0,Input.GetAxis("Mouse X") * xSpeedR,0);
	}
}
