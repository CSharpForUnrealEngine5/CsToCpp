namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects pieces based on their size</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionTransformSelectionBySizeDataflowNode {
	public FManagedArrayCollection Collection;
	public float SizeMin;
	public float SizeMax;
	public ERangeSettingEnum RangeSetting;
	public bool bInclusive;
	public bool bUseRelativeSize;
	public FDataflowTransformSelection TransformSelection;
}
