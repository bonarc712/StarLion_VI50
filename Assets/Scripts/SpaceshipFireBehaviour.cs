using UnityEngine;
using System.Collections;

public class SpaceshipFireBehaviour : MonoBehaviour {

	public ParticleSystem particle;

	// Use this for initialization
	void Start () {
		particle = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			particle.Play();
			LaserFireSoundManager.PlaySound("LaserFire");
		}
	}
}
