using UnityEngine;
using System.Collections;

public class LaserFireSoundManager : MonoBehaviour {
	
	public static AudioSource laserFire;
	
	// Use this for initialization
	void Start () {
		laserFire = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Le son LaserFire est un son gratuit obtenu via freesfx.co.uk
	public static void PlaySound(string soundName){
		switch (soundName) {
		case "LaserFire" : laserFire.Play(); break;
		default : break;
		}
	}
}
