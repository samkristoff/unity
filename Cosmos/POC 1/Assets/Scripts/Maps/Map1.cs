using UnityEngine;
using System.Collections;

public class Map1 : Map
{
	public Map1()
	{
		Name = "Map 1!";

		StartX = 0;
		StartZ = 2;

		EndX = 2;
		EndZ = 0;

		MapNodes = new MapNode[3, 3];
		MapNodes [0, 0] = new MapNode (false, false, false, false);
		MapNodes [1, 0] = new MapNode (false, false, false, false);
		MapNodes [2, 0] = new MapNode (true, false, false, false);

		MapNodes [0, 1] = new MapNode (false, false, false, false);
		MapNodes [1, 1] = new MapNode (false, false, false, false);
		MapNodes [2, 1] = new MapNode (true, false, true, false);

		MapNodes [0, 2] = new MapNode (false, true, false, false);
		MapNodes [1, 2] = new MapNode (false, true, false, true);
		MapNodes [2, 2] = new MapNode (false, false, true, true);
	}
}
