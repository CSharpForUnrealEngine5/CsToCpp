#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/MaterialBillboardComponent.h")]
public partial struct FMaterialSpriteElement {
	public UMaterialInterface Material;
	public UCurveFloat DistanceToOpacityCurve;
	public bool bSizeIsInScreenSpace;
	public float BaseSizeX;
	public float BaseSizeY;
	public UCurveFloat DistanceToSizeCurve;
}
