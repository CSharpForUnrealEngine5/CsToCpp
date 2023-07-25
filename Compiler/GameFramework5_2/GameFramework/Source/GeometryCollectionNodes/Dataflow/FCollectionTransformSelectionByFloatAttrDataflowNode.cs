#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
///<summary>Selects bones by a float attribute</summary>
public partial struct FCollectionTransformSelectionByFloatAttrDataflowNode {
// CollectionTransformSelectionByFloatAttrDataflowNode
	public FManagedArrayCollection Collection;
	public string GroupName;
	public string AttrName;
	public float Min;
	public float Max;
	public ERangeSettingEnum RangeSetting;
	public bool bInclusive;
	public FDataflowTransformSelection TransformSelection;
}
