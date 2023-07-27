#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LedWallArucoGenerationOptions.h")]
///<summary>Structure that can be passed to the Aruco generation function</summary>
public partial struct FLedWallArucoGenerationOptions {
// LedWallArucoGenerationOptions
	public int TextureWidth;
	public int TextureHeight;
	public EArucoDictionary ArucoDictionary;
	public int MarkerId;
	public int PlaceModulus;
}
