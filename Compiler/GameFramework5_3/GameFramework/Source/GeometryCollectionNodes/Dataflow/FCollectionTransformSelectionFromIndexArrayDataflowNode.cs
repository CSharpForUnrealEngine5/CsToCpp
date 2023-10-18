namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Convert index array to a transform selection</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionTransformSelectionFromIndexArrayDataflowNode {
	public FManagedArrayCollection Collection;
	public TArray<int> BoneIndices;
	public FDataflowTransformSelection TransformSelection;
}
