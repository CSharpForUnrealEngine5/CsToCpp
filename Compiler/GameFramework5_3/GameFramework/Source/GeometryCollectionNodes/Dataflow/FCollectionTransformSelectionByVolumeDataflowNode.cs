namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects pieces based on their volume</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionTransformSelectionByVolumeDataflowNode {
	public FManagedArrayCollection Collection;
	public float VolumeMin;
	public float VolumeMax;
	public ERangeSettingEnum RangeSetting;
	public bool bInclusive;
	public FDataflowTransformSelection TransformSelection;
}
