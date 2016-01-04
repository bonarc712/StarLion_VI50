using UnityEngine;
using System.Collections;

public class RotationControler : MonoBehaviour {

	public float xSpeedR = 2;
	public float ySpeedR = 2;
	public float zSpeedR = 2;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Input.GetAxis("Horizontal") * xSpeedR, Input.GetAxis("Vertical") * ySpeedR, 0);
	}
}
