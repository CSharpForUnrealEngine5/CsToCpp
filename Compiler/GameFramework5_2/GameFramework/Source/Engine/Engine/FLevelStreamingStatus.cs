#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>level streaming updates that should be applied immediately after committing the map change</summary>
[CppInclude("Engine/Engine.h")]
public partial struct FLevelStreamingStatus {
	public string PackageName;
	public bool bShouldBeLoaded;
	public bool bShouldBeVisible;
	public uint LODIndex;
}
