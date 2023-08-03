#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint function library for autocasting from a base camera shake to a legacy camera shake.</summary>
[CppInclude("LegacyCameraShake.h")]
public partial class ULegacyCameraShakeFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Conv_LegacyCameraShake</summary>
	public static ULegacyCameraShake Conv_LegacyCameraShake(UCameraShakeBase CameraShake) { return default; }
}
