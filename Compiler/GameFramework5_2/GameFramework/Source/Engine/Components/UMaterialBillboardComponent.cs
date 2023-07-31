#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A 2d material that will be rendered always facing the camera.</summary>
[CppInclude("Components/MaterialBillboardComponent.h")]
public partial class UMaterialBillboardComponent : UPrimitiveComponent {
	///<summary>Current array of material billboard elements</summary>
	public TArray<FMaterialSpriteElement> Elements;
	///<summary>Set all elements of this material billboard component</summary>
	public  void SetElements(TArray<FMaterialSpriteElement> NewElements) {}
	///<summary>Adds an element to the sprite.</summary>
	public  void AddElement(UMaterialInterface Material,UCurveFloat DistanceToOpacityCurve,bool bSizeIsInScreenSpace,float BaseSizeX,float BaseSizeY,UCurveFloat DistanceToSizeCurve) {}
}
