#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LayoutScripts/DMXPixelMappingLayoutScript.h")]
///<summary>The position and size of a comoponent in a layout</summary>
public partial struct FDMXPixelMappingLayoutToken {
// DMXPixelMappingLayoutToken
	public float PositionX;
	public float PositionY;
	public float SizeX;
	public float SizeY;
	public TWeakObjectPtr<UDMXPixelMappingOutputComponent> Component;
	public int FixtureID;
}
