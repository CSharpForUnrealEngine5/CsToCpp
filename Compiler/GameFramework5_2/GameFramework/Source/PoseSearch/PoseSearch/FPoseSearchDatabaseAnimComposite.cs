#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/PoseSearchDatabase.h")]
///<summary>An entry in a UPoseSearchDatabase.</summary>
public partial struct FPoseSearchDatabaseAnimComposite {
// PoseSearchDatabaseAnimComposite
	public UAnimComposite AnimComposite;
	public bool bEnabled;
	public FFloatInterval SamplingRange;
	public EPoseSearchMirrorOption MirrorOption;
}
