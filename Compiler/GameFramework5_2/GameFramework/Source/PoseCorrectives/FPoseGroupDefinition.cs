namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Predefines what bones/curves are used by the pose in the rbf/algorithm</summary>
[CppInclude("PoseCorrectivesAsset.h")]
public partial struct FPoseGroupDefinition {
	public TArray<FName> DriverBones;
	public TArray<FName> DriverCurves;
	public TArray<FName> CorrectiveBones;
	public TArray<FName> CorrectiveCurves;
}
