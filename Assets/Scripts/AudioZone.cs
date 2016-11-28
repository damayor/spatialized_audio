using UnityEngine;
using System.Collections;

public class AudioZone : MonoBehaviour {


	AudioSource audio;

	public AudioClip campanas;


	// Use this for initialization
	void Start () {
	
		audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onTriggerEnter (Collider other)
    {
		//if(other.gameObject.name.Contains("organo"))
		{ 
			//SetControlArbol(other.gameObject.GetComponent<ControlArbol>());
			//aSource.PlayOneShot(xmas);
			audio.enabled = true;
			audio.PlayOneShot(campanas);
		}

    }

    void onTriggerExit(Collider other)
    {
		if (other.gameObject.name.Contains ("organo")) {
			audio.Stop ();
		}

    }

}
