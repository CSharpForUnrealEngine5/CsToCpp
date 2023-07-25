#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/BillboardComponent.h")]
///<summary>A 2d texture that will be rendered always facing the camera.</summary>
public partial class UBillboardComponent : UPrimitiveComponent {
// BillboardComponent
	public UTexture2D Sprite;
	public bool bIsScreenSizeScaled;
	public float ScreenSize;
	public float U;
	public float UL;
	public float V;
	public float VL;
	public float OpacityMaskRefVal;
	public string SpriteCategoryName_DEPRECATED;
	public FSpriteCategoryInfo SpriteInfo;
	public bool bUseInEditorScaling;
	public bool bShowLockedLocation;
	public void SetSprite(UObject NewSprite) {}
	public void SetUV(int NewU,int NewUL,int NewV,int NewVL) {}
	public void SetSpriteAndUV(UObject NewSprite,int NewU,int NewUL,int NewV,int NewVL) {}
	public void SetOpacityMaskRefVal(float RefVal) {}
}
