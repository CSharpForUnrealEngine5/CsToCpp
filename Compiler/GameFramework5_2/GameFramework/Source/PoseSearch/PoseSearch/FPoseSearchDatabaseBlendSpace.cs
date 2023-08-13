namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An blend space entry in a UPoseSearchDatabase.</summary>
[CppInclude("PoseSearch/PoseSearchDatabase.h")]
public partial struct FPoseSearchDatabaseBlendSpace {
	public UBlendSpace BlendSpace;
	public bool bEnabled;
	public EPoseSearchMirrorOption MirrorOption;
	public bool bUseGridForSampling;
	public int NumberOfHorizontalSamples;
	public int NumberOfVerticalSamples;
}
