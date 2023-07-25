#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/MaterialBillboardComponent.h")]
///<summary>A 2d material that will be rendered always facing the camera.</summary>
public partial class UMaterialBillboardComponent : UPrimitiveComponent {
// MaterialBillboardComponent
	public TArray<FMaterialSpriteElement> Elements;
	public void SetElements(TArray<FMaterialSpriteElement> NewElements) {}
	public void AddElement(UObject Material,UObject DistanceToOpacityCurve,bool bSizeIsInScreenSpace,float BaseSizeX,float BaseSizeY,UObject DistanceToSizeCurve) {}
}
