namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Transforms a mesh</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FTransformMeshDataflowNode {
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
