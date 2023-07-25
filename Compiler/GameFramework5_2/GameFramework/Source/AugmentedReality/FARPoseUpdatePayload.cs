#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial struct FARPoseUpdatePayload {
// ARPoseUpdatePayload
	public FTransform WorldTransform;
	public TArray<FTransform> JointTransforms;
}
