#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A volume representing a location in the world</summary>
[CppInclude("LocationVolume.h")]
public partial class ALocationVolume : AVolume {
	public static UClass StaticClass() {return default;}
	///<summary>Load this location volume</summary>
	public  void Load() {}
	///<summary>Unload this location volume</summary>
	public  void Unload() {}
	///<summary>Return if this location volume is loaded</summary>
	public  bool IsLoaded() { return default; }
	///<summary>DebugColor</summary>
	public FColor DebugColor;
	///<summary>bIsRuntime</summary>
	public bool bIsRuntime;
}
