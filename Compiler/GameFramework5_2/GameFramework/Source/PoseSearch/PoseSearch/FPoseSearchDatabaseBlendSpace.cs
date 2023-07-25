#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/PoseSearchDatabase.h")]
///<summary>An blend space entry in a UPoseSearchDatabase.</summary>
public partial struct FPoseSearchDatabaseBlendSpace {
// PoseSearchDatabaseBlendSpace
	public UBlendSpace BlendSpace;
	public bool bEnabled;
	public EPoseSearchMirrorOption MirrorOption;
	public bool bUseGridForSampling;
	public int NumberOfHorizontalSamples;
	public int NumberOfVerticalSamples;
}
