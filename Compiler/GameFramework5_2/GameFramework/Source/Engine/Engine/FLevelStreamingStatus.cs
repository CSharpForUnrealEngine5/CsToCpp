#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Engine.h")]
///<summary>level streaming updates that should be applied immediately after committing the map change</summary>
public partial struct FLevelStreamingStatus {
// LevelStreamingStatus
	public string PackageName;
	public bool bShouldBeLoaded;
	public bool bShouldBeVisible;
	public uint LODIndex;
}
