#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
///<summary>Transforms a mesh</summary>
public partial struct FTransformMeshDataflowNode {
// TransformMeshDataflowNode
	public UDynamicMesh Mesh;
	public FVector Translate;
	public ERotationOrderEnum RotationOrder;
	public FVector Rotate;
	public FVector Scale;
	public float UniformScale;
	public FVector RotatePivot;
	public FVector ScalePivot;
	public bool bInvertTransformation;
}
