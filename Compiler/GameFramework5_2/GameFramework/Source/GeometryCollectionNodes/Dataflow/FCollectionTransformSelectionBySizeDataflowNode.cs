#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
///<summary>Selects pieces based on their size</summary>
public partial struct FCollectionTransformSelectionBySizeDataflowNode {
// CollectionTransformSelectionBySizeDataflowNode
	public FManagedArrayCollection Collection;
	public float SizeMin;
	public float SizeMax;
	public ERangeSettingEnum RangeSetting;
	public bool bInclusive;
	public FDataflowTransformSelection TransformSelection;
}
