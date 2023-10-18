namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial struct FARPoseUpdatePayload {
	public FTransform WorldTransform;
	public TArray<FTransform> JointTransforms;
}
