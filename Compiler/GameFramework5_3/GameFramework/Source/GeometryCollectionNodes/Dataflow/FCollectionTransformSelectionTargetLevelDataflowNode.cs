namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects the root bones in the Collection</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionTransformSelectionTargetLevelDataflowNode {
	public FManagedArrayCollection Collection;
	public int TargetLevel;
	public bool bSkipEmbedded;
	public FDataflowTransformSelection TransformSelection;
}
