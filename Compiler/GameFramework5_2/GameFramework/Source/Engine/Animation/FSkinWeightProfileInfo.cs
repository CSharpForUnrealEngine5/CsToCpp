#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/SkinWeightProfile.h")]
///<summary>Structure storing user facing properties, and is used to identify profiles at the SkeletalMesh level</summary>
public partial struct FSkinWeightProfileInfo {
// SkinWeightProfileInfo
	public string Name;
	public FPerPlatformBool DefaultProfile;
	public FPerPlatformInt DefaultProfileFromLODIndex;
	public TMap<int,string> PerLODSourceFiles;
}
