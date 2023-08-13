namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UMeasureDistanceSampleTool is an example Tool that allows the user to measure the</summary>
[CppInclude("SampleTools/MeasureDistanceSampleTool.h")]
public partial class UMeasureDistanceSampleTool : UInteractiveTool {
	public static UClass StaticClass() {return default;}
	///<summary>Properties of the tool are stored here</summary>
	public UMeasureDistanceProperties Properties;
}
