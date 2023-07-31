#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure storing user facing properties, and is used to identify profiles at the SkeletalMesh level</summary>
[CppInclude("Animation/SkinWeightProfile.h")]
public partial struct FSkinWeightProfileInfo {
	public string Name;
	public FPerPlatformBool DefaultProfile;
	public FPerPlatformInt DefaultProfileFromLODIndex;
	public TMap<int,string> PerLODSourceFiles;
}
