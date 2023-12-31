namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An entry in a UPoseSearchDatabase.</summary>
[CppInclude("PoseSearch/PoseSearchDatabase.h")]
public partial struct FPoseSearchDatabaseSequence {
	public UAnimSequence Sequence;
	public bool bEnabled;
	public FFloatInterval SamplingRange;
	public EPoseSearchMirrorOption MirrorOption;
}
