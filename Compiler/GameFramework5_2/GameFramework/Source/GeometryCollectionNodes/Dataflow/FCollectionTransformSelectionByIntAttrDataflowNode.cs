namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects bones by an int attribute</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionTransformSelectionByIntAttrDataflowNode {
	public FManagedArrayCollection Collection;
	public string GroupName;
	public string AttrName;
	public int Min;
	public int Max;
	public ERangeSettingEnum RangeSetting;
	public bool bInclusive;
	public FDataflowTransformSelection TransformSelection;
}
