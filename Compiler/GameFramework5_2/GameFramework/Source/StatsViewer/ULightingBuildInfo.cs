#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LightingBuildInfo.h")]
///<summary>Statistics page for lighting.</summary>
public partial class ULightingBuildInfo : UObject {
// LightingBuildInfo
	public TWeakObjectPtr<UObject> Object;
	public float LightingTime;
	public float UnmappedTexelsPercentage;
	public float UnmappedTexelsMemory;
	public float TotalTexelMemory;
	public string LevelName;
}
