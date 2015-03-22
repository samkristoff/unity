using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour 
{
	//Game Coordinate Data Type
	public struct Coords
	{
		public int x;
		public int z;
	}

	public Text DebugText;
	private Coords location;

	public GameObject MapObj;
	private Map map;
	// Use this for initialization
	void Start () 
	{
		//Get a refernce to the MapController
		map = MapObj.GetComponent<MapController>().Map;
		DebugText.text = map.Name;

		//Goto Start Location
		location.x = map.StartX;
		location.z = map.StartZ;
		gameObject.transform.position = new Vector3 (location.x, 0, location.z);

	} 
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown ("Up") && map.MapNodes[location.x, location.z].Top)
		{
			moveUp();
		}
		else if (Input.GetButtonDown ("Right") && map.MapNodes[location.x, location.z].Right)
		{
			moveRight();
		}
		else if (Input.GetButtonDown ("Down") && map.MapNodes[location.x, location.z].Bottom)
		{
			moveDown();
		}
		else if (Input.GetButtonDown ("Left") && map.MapNodes[location.x, location.z].Left)
		{
			moveLeft();
		} 

		DebugText.text = "(" + location.x + ", " + location.z + ")";
	}

	void moveUp()
	{
		iTween.MoveTo(gameObject, (new Vector3(location.x, 0, location.z+1)), 1);
		location.z++;
	}

	void moveRight()
	{
		iTween.MoveTo(gameObject, (new Vector3(location.x + 1, 0, location.z)), 1);
		location.x++;
	}

	void moveDown()
	{
		iTween.MoveTo(gameObject, (new Vector3(location.x, 0, location.z-1)), 1);
		location.z--;
	}

	void moveLeft() 
	{
		iTween.MoveTo(gameObject, (new Vector3(location.x - 1, 0, location.z)), 1);
		location.x--;
	}


}
