using UnityEngine;
using System.Collections;

public abstract class Map 
{
	public string Name = "Generic Map";
	public MapNode[,] MapNodes;

	public int StartX;
	public int StartZ;
	public int EndX;
	public int EndZ;
}

public class MapNode
{
	public bool Top;
	public bool Right;
	public bool Bottom;
	public bool Left;

	public MapNode(bool topConnected, bool rightConnected, bool bottomConnected, bool leftConnected)
	{
		Top = topConnected;
		Right = rightConnected;
		Bottom = bottomConnected;
		Left = leftConnected;
	}
}
