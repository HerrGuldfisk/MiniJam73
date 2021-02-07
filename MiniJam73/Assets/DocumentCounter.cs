using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocumentCounter : MonoBehaviour
{
	#region Singleton
	public static DocumentCounter _instance;
	public static DocumentCounter Instance { get { return _instance; } }

	private void Awake()
	{
		DontDestroyOnLoad(gameObject);
		if (_instance != null && _instance != this)
		{
			Destroy(this.gameObject);
		}
		else
		{
			_instance = this;s
		}
	}
	#endregion

	public List<GameObject> documents = new List<GameObject>();
}
