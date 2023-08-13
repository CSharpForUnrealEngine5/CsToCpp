namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Description for this node</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FMakeTransformDataflowNode {
	public FVector InTranslation;
	public FVector InRotation;
	public FVector InScale;
	public FTransform OutTransform;
}
