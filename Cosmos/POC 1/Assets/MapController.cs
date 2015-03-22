using UnityEngine;
using System.Collections;

public class MapController : MonoBehaviour {

	public Map Map;

	// Use this for initialization
	void Start () 
	{
		Map = new Map1 (); 
	}
	
	// Update is called once per frame
	void Update () {
	 
	}

	public string getText()
	{
		return "happy text!";
	}
}
