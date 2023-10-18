namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects indices of a float array by range</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FSelectFloatArrayIndicesInRangeDataflowNode {
	public TArray<float> Values;
	public float Min;
	public float Max;
	public ERangeSettingEnum RangeSetting;
	public bool bInclusive;
	public TArray<int> Indices;
}
