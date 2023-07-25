#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
///<summary>Selects pieces based on their volume</summary>
public partial struct FCollectionTransformSelectionByVolumeDataflowNode {
// CollectionTransformSelectionByVolumeDataflowNode
	public FManagedArrayCollection Collection;
	public float VolumeMin;
	public float VolumeMax;
	public ERangeSettingEnum RangeSetting;
	public bool bInclusive;
	public FDataflowTransformSelection TransformSelection;
}
