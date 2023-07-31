#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that can be passed to the Aruco generation function</summary>
[CppInclude("LedWallArucoGenerationOptions.h")]
public partial struct FLedWallArucoGenerationOptions {
	public int TextureWidth;
	public int TextureHeight;
	public EArucoDictionary ArucoDictionary;
	public int MarkerId;
	public int PlaceModulus;
}
