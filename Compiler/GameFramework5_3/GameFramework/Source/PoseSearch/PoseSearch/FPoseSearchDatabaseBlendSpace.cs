namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An blend space entry in a UPoseSearchDatabase.</summary>
[CppInclude("PoseSearch/PoseSearchDatabase.h")]
public partial struct FPoseSearchDatabaseBlendSpace {
	public UBlendSpace BlendSpace;
	public EPoseSearchMirrorOption MirrorOption;
	public bool bUseSingleSample;
	public bool bUseGridForSampling;
	public int NumberOfHorizontalSamples;
	public int NumberOfVerticalSamples;
	public float BlendParamX;
	public float BlendParamY;
	public bool bEnabled;
}
