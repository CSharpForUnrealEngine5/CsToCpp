#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
	public FDataflowTransformSelection TransformSelection;
}
