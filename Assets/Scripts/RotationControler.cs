using UnityEngine;
using System.Collections;

public class RotationControler : MonoBehaviour {

	public float xSpeedR = 1;
	public float ySpeedR = 1;
	public float zSpeedR = 1;
    public float speed = 0;
    public float acceleration = 0;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(-Input.GetAxis("Horizontal") * xSpeedR, -Input.GetAxis("Vertical") * ySpeedR, 0,Space.World);
        acceleration = Input.GetAxis("Power");
        speed += acceleration * Time.deltaTime;
        transform.Translate(new Vector3(speed, 0, 0));
	
	}
}
