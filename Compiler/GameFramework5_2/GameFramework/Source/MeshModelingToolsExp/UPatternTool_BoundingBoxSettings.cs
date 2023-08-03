#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for Bounding Box adjustments in the Pattern Tool</summary>
[CppInclude("PatternTool.h")]
public partial class UPatternTool_BoundingBoxSettings : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>If true, pattern element bounding boxes are not changed to account for StartScale or StartRotation</summary>
	public bool bIgnoreTransforms;
	///<summary>Value added to the all pattern elements&#39; bounding boxes for adjusting the behavior of packed spacing mode manually</summary>
	public float Adjustment;
	///<summary>If true, the bounding boxes of each element are rendered in green and the combined bounding box of all source elements is rendered in red</summary>
	public bool bVisualize;
}
