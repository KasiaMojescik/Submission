﻿using UnityEngine.Audio;
using UnityEngine;

// created following tutorial https://www.youtube.com/watch?v=6OT43pvUyfY 
// this class specifies all the details about the sounds used for vocal cues
// class is marked as Serializable in order to appear in the inspector
[System.Serializable]
public class Sound {
    // for the name of the sound
	public string name;
    // for the actual recording
	public AudioClip clip;
    // define the volume between 0 and 1
	[Range(0f, 1f)]
	public float volume = .75f;
    // define pitch between 0.1 and 3
	[Range(.1f, 3f)]
	public float pitch = 1f;
    // serialize but don't show this variable in the inspector
	[HideInInspector]
	public AudioSource source;
}
