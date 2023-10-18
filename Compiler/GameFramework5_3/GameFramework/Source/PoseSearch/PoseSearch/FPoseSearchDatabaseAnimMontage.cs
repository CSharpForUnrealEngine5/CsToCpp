namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An anim montage entry in a UPoseSearchDatabase.</summary>
[CppInclude("PoseSearch/PoseSearchDatabase.h")]
public partial struct FPoseSearchDatabaseAnimMontage {
	public UAnimMontage AnimMontage;
	public bool bEnabled;
	public FFloatInterval SamplingRange;
	public EPoseSearchMirrorOption MirrorOption;
}
