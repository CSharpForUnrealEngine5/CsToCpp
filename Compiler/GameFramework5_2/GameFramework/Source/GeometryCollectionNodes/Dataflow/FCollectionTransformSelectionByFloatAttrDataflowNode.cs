namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects bones by a float attribute</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionTransformSelectionByFloatAttrDataflowNode {
	public FManagedArrayCollection Collection;
	public string GroupName;
	public string AttrName;
	public float Min;
	public float Max;
	public ERangeSettingEnum RangeSetting;
	public bool bInclusive;
	public FDataflowTransformSelection TransformSelection;
}
