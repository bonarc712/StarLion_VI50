using UnityEngine;
using System.Collections;

public class ShipCreationScript : MonoBehaviour {

	public float interval = 30;
	private float timer;
	public Transform prefab;
	public Transform o;
	public Transform spawn;
	// Use this for initialization
	void Start () {
		timer =0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= timer) 
		{
			Transform t = (Transform) Instantiate(prefab,-o.transform.localPosition + spawn.transform.position,spawn.transform.localRotation);
				
			t.transform.parent = o;
			t.Rotate (new Vector3(0,0,-90));
			timer = Time.time + interval; 
		}
	}
}
