public enum HexDirection 
{
		NE, E, SE, SW, W, NW
}

public static class HexDirectionExtensions
{
	public static HexDirection Opposite (this HexDirection dir)
	{
		return (int)dir < 3 ? (dir + 3) : (dir - 3);
	}
}