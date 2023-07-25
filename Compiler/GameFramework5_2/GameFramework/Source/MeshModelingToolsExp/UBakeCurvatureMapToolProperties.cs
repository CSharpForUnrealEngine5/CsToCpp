#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeToolCommon.h")]
public partial class UBakeCurvatureMapToolProperties : UInteractiveToolPropertySet {
// BakeCurvatureMapToolProperties
	public EBakeCurvatureTypeMode CurvatureType;
	public EBakeCurvatureColorMode ColorMapping;
	public float ColorRangeMultiplier;
	public float MinRangeMultiplier;
	public EBakeCurvatureClampMode Clamping;
}
