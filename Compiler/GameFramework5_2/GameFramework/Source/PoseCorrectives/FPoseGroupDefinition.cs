#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Predefines what bones/curves are used by the pose in the rbf/algorithm</summary>
[CppInclude("PoseCorrectivesAsset.h")]
public partial struct FPoseGroupDefinition {
	public TArray<string> DriverBones;
	public TArray<string> DriverCurves;
	public TArray<string> CorrectiveBones;
	public TArray<string> CorrectiveCurves;
}
