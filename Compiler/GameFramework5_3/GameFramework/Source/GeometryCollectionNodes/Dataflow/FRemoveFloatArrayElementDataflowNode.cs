namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Removes the specified element from an array</summary>
[CppInclude("Dataflow/GeometryCollectionArrayNodes.h")]
public partial struct FRemoveFloatArrayElementDataflowNode {
	public int Index;
	public bool bPreserveOrder;
	public TArray<float> FloatArray;
}
