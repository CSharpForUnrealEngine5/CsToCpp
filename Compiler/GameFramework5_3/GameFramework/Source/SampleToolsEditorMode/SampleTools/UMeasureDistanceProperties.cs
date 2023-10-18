namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Property set for the UMeasureDistanceSampleTool</summary>
[CppInclude("SampleTools/MeasureDistanceSampleTool.h")]
public partial class UMeasureDistanceProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>First point of measurement</summary>
	public FVector StartPoint;
	///<summary>Second point of measurement</summary>
	public FVector EndPoint;
	///<summary>Current distance measurement</summary>
	public float Distance;
}
