using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public Text MapName;

	public GameObject Map;
	private MapController other;
	// Use this for initialization
	void Start () 
	{
		other = Map.GetComponent<MapController>();
		MapName.text = other.Map.Name;
	} 
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown ("Fire1")) 
		{
			iTween.MoveTo(gameObject, transform.position + new Vector3(1, 0, 0), 2);
			//transform.position += new Vector3(1, 0, 0);
		}

	}
}
