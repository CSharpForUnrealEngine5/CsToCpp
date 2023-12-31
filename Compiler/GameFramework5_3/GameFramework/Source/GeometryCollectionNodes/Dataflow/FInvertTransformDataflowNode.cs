namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Invert a transform.</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FInvertTransformDataflowNode {
	public FTransform InTransform;
	public FTransform OutTransform;
}
