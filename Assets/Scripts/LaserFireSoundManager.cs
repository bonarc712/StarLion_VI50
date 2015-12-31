using UnityEngine;
using System.Collections;

public class LaserFireSoundManager : MonoBehaviour {

	/**
	 * Le son sci_fi_lazer_shot est un son gratuit obtenu via freesfx.co.uk
	 * Le son fire_fusee_2 est un son gratuit obtenu via www.freesoundeffects.com,
	 *   auquel on a appliqué un filtre passe-bas et un raccourcissement pour un
	 *   meilleur effet de boucle.
	 * */
	
	public static AudioSource laserFire;
	
	// Use this for initialization
	void Start () {
		laserFire = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void PlaySound(string soundName){
		switch (soundName) {
		case "LaserFire" : laserFire.Play(); break;
		default : break;
		}
	}
}
