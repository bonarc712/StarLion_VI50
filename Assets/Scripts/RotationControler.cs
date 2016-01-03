using UnityEngine;
using System.Collections;

public class RotationControler : MonoBehaviour {

	public float xSpeedR = 1;
	public float ySpeedR = 1;
	public float zSpeedR = 1;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Input.GetAxis("Horizontal") * xSpeedR, Input.GetAxis("Vertical") * ySpeedR, 0);
		//transform.Rotate(
		//transform.rotation = ;
	}
}
