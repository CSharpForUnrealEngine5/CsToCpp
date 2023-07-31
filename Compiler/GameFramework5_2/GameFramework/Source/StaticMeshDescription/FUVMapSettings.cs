#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UV map generation settings that are exposed to the user for scripting and through the editor</summary>
[CppInclude("UVMapSettings.h")]
public partial struct FUVMapSettings {
	public FVector Size;
	public FVector2D UVTile;
	public FVector Position;
	public FRotator Rotation;
	public FVector Scale;
}
