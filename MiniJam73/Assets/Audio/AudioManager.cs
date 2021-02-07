using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
	#region Singleton
	public static AudioManager _instance;
	public static AudioManager Instance { get { return _instance; } }

	private void Awake()
	{
		DontDestroyOnLoad(gameObject);
		if (_instance != null && _instance != this)
		{
			Destroy(this.gameObject);
		}
		else
		{
			_instance = this;
			DontDestroyOnLoad(gameObject);
		}
	}
	#endregion

	public AudioMixer mixer;

	public string changedValue;

	public Sound[] sounds;

	[HideInInspector]
	public Dictionary<string, float> paramValue = new Dictionary<string, float>();

	public string[] paramNames;

	public bool tickTock = true;

	private void Start()
	{
		LoadAllSounds();
		SetAudioLevels();
	}

	private void FixedUpdate()
	{
		if (tickTock)
		{
			TickTockVolume();
		}
	}

	private void LoadAllSounds()
	{
		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.name = s.name;
			s.source.clip = s.clip;
			s.source.volume = s.volume;
			s.source.pitch = s.pitch;
			s.source.loop = s.loop;
			s.source.outputAudioMixerGroup = s.channel;
		}
	}

	public AudioSource GetAudioSource(string _name)
	{
		AudioSource[] audioSources = GetComponents<AudioSource>();

		foreach (AudioSource s in audioSources)
		{
			if (s.clip != null)
			{

				if (s.clip.name == _name)
				{
					return s;
				}
				else
				{
					Debug.LogWarning("Sound: " + name + " not found!");
				}
			}
		}
		return null;
	}

	public void Play(string name, bool loop=false)
	{
		Sound s = Array.Find(sounds, sound => sound.name == name);

		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}

		s.loop = loop;

		Debug.Log("Playing " + name);
		s.source.Play();
	}

	public void PlayTheme()
	{
		Play("MainTheme", true);
		tickTock = true;
	}

	public void TickTockVolume()
	{
		AudioSource[] audioSources = GetComponents<AudioSource>();

		foreach (AudioSource s in audioSources)
		{
			if (s.clip == null) { return; }

			if (s.clip.name == "soundtrack")
			{
				if(Power.Instance.power >= 80)
				{
					s.volume = 0.1f;
				}
				else
				{
					s.volume = 1 - (Power.Instance.power / 100);
				}

			}
		}
	}

	#region not needed
	public void Muted()
	{
		// Add a muted function that toggle sound volume.
	}




	private void SetAudioLevels()
	{
		foreach (KeyValuePair<string, float> entry in paramValue)
		{
			mixer.SetFloat(entry.Key, entry.Value);
		}
	}

	// Currently not in use, might be needed at some point.
	private void GetAudioLevels()
	{
		foreach (string soundLevel in paramNames)
		{
			float volume;
			bool result = mixer.GetFloat(soundLevel, out volume);

			if (result)
			{
				paramValue[soundLevel] = volume;
			}
			else
			{
				Debug.Log("The parameter: " + soundLevel + " was not found in the AudioMixer");
			}
		}
	}

	public void ChangedValue(string name)
	{
		changedValue = name + "Volume";
	}

	public void FromSlider(float sliderValue)
	{
		mixer.SetFloat(changedValue, Mathf.Log10(sliderValue) * 30);
		paramValue[changedValue] = Mathf.Log10(sliderValue) * 30;
	}

	public Dictionary<string, float> AudioLevels()
	{
		return paramValue;
	}
	#endregion
}
