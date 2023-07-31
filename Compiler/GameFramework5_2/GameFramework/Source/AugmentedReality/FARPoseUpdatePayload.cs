#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial struct FARPoseUpdatePayload {
	public FTransform WorldTransform;
	public TArray<FTransform> JointTransforms;
}
