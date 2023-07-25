#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_DistributeRotation.h")]
public partial struct FRigUnit_DistributeRotation_WorkData {
// RigUnit_DistributeRotation_WorkData
	public TArray<FCachedRigElement> CachedItems;
	public TArray<int> ItemRotationA;
	public TArray<int> ItemRotationB;
	public TArray<float> ItemRotationT;
	public TArray<FTransform> ItemLocalTransforms;
}
