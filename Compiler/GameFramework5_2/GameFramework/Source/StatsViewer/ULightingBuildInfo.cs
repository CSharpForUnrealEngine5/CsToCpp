#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Statistics page for lighting.</summary>
[CppInclude("LightingBuildInfo.h")]
public partial class ULightingBuildInfo : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The actor and/or object that is related to this info.</summary>
	public TWeakObjectPtr<UObject> Object;
	///<summary>The lighting time this object took.</summary>
	public float LightingTime;
	///<summary>The percentage of unmapped texels for this object.</summary>
	public float UnmappedTexelsPercentage;
	///<summary>The memory consumed by unmapped texels for this object, in KB</summary>
	public float UnmappedTexelsMemory;
	///<summary>The memory consumed by all texels for this object, in KB</summary>
	public float TotalTexelMemory;
	///<summary>The name of the level this object resides in</summary>
	public string LevelName;
}
