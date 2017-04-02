using UnityEngine;

public class HexCell : MonoBehaviour {

	public HexCoordinates coordinates;

	public Color color;

	[SerializeField]
	HexCell[] neighbors;

	public HexCell GetNeighbor (HexDirection dir)
	{
		return neighbors[(int)dir];
	}
	
	public void SetNeighbor (HexDirection dir, HexCell cell)
	{
		neighbors[(int)dir] = cell;
		cell.neighbors[(int)dir.Opposite()] = this;
	}
}