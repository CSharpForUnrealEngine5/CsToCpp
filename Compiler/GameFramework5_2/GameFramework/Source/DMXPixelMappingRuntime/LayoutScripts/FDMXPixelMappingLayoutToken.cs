#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The position and size of a comoponent in a layout</summary>
[CppInclude("LayoutScripts/DMXPixelMappingLayoutScript.h")]
public partial struct FDMXPixelMappingLayoutToken {
	public float PositionX;
	public float PositionY;
	public float SizeX;
	public float SizeY;
	public TWeakObjectPtr<UDMXPixelMappingOutputComponent> Component;
	public int FixtureID;
}
