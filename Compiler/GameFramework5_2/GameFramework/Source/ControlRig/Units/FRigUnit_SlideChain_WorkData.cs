#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_SlideChain.h")]
public partial struct FRigUnit_SlideChain_WorkData {
	public float ChainLength;
	public TArray<float> ItemSegments;
	public TArray<FCachedRigElement> CachedItems;
	public TArray<FTransform> Transforms;
	public TArray<FTransform> BlendedTransforms;
}
