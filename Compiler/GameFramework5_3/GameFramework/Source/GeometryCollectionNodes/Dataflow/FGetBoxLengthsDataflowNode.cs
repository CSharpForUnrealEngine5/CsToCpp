namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Create an array of lengths of bounding boxes (measured along an axis, diagonal, or the max/min axes) from an array of bounding boxes</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FGetBoxLengthsDataflowNode {
	public TArray<FBox> Boxes;
	public TArray<float> Lengths;
	public EBoxLengthMeasurementMethod MeasurementMethod;
}
