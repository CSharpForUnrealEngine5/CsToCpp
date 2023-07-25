#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_FitChainToCurve.h")]
public partial struct FRigUnit_FitChainToCurve_WorkData {
// RigUnit_FitChainToCurve_WorkData
	public float ChainLength;
	public TArray<FVector> ItemPositions;
	public TArray<float> ItemSegments;
	public TArray<FVector> CurvePositions;
	public TArray<float> CurveSegments;
	public TArray<FCachedRigElement> CachedItems;
	public TArray<int> ItemRotationA;
	public TArray<int> ItemRotationB;
	public TArray<float> ItemRotationT;
	public TArray<FTransform> ItemLocalTransforms;
}
