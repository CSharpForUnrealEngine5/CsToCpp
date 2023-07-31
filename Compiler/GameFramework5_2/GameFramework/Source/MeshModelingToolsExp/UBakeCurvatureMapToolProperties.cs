#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeToolCommon.h")]
public partial class UBakeCurvatureMapToolProperties : UInteractiveToolPropertySet {
	///<summary>Type of curvature</summary>
	public EBakeCurvatureTypeMode CurvatureType;
	///<summary>How to map calculated curvature values to colors</summary>
	public EBakeCurvatureColorMode ColorMapping;
	///<summary>Multiplier for how the curvature values fill the available range in the selected Color Mapping; a larger value means that higher curvature is required to achieve the maximum color value.</summary>
	public float ColorRangeMultiplier;
	///<summary>Minimum for the curvature values to not be clamped to zero relative to the curvature for the maximum color value; a larger value means that higher curvature is required to not be considered as no curvature.</summary>
	public float MinRangeMultiplier;
	///<summary>Clamping applied to curvature values before color mapping</summary>
	public EBakeCurvatureClampMode Clamping;
}
