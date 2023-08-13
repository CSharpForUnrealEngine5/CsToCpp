namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An entry in a UPoseSearchDatabase.</summary>
[CppInclude("PoseSearch/PoseSearchDatabase.h")]
public partial struct FPoseSearchDatabaseAnimComposite {
	public UAnimComposite AnimComposite;
	public bool bEnabled;
	public FFloatInterval SamplingRange;
	public EPoseSearchMirrorOption MirrorOption;
}
