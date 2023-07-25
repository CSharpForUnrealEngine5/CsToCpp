#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
///<summary>Selects bones by an int attribute</summary>
public partial struct FCollectionTransformSelectionByIntAttrDataflowNode {
// CollectionTransformSelectionByIntAttrDataflowNode
	public FManagedArrayCollection Collection;
	public string GroupName;
	public string AttrName;
	public int Min;
	public int Max;
	public ERangeSettingEnum RangeSetting;
	public bool bInclusive;
	public FDataflowTransformSelection TransformSelection;
}
