#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Transforms a Collection</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FTransformCollectionDataflowNode {
	public FManagedArrayCollection Collection;
	public FVector Translate;
	public ERotationOrderEnum RotationOrder;
	public FVector Rotate;
	public FVector Scale;
	public float UniformScale;
	public FVector RotatePivot;
	public FVector ScalePivot;
	public bool bInvertTransformation;
}
