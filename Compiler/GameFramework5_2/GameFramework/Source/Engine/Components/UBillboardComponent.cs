namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A 2d texture that will be rendered always facing the camera.</summary>
[CppInclude("Components/BillboardComponent.h")]
public partial class UBillboardComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Sprite</summary>
	public UTexture2D Sprite;
	///<summary>bIsScreenSizeScaled</summary>
	public bool bIsScreenSizeScaled;
	///<summary>ScreenSize</summary>
	public float ScreenSize;
	///<summary>U</summary>
	public float U;
	///<summary>UL</summary>
	public float UL;
	///<summary>V</summary>
	public float V;
	///<summary>VL</summary>
	public float VL;
	///<summary>The billboard is not rendered where texture opacity &lt; OpacityMaskRefVal</summary>
	public float OpacityMaskRefVal;
	///<summary>Sprite category that the component belongs to. Value serves as a key into the localization file.</summary>
	public string SpriteCategoryName_DEPRECATED;
	///<summary>Sprite category information regarding the component</summary>
	public FSpriteCategoryInfo SpriteInfo;
	///<summary>Whether to use in-editor arrow scaling (i.e. to be affected by the global arrow scale)</summary>
	public bool bUseInEditorScaling;
	///<summary>bShowLockedLocation</summary>
	public bool bShowLockedLocation;
	///<summary>Change the sprite texture used by this component</summary>
	public virtual void SetSprite(UTexture2D NewSprite) {}
	///<summary>Change the sprite&#39;s UVs</summary>
	public virtual void SetUV(int NewU,int NewUL,int NewV,int NewVL) {}
	///<summary>Change the sprite texture and the UV&#39;s used by this component</summary>
	public virtual void SetSpriteAndUV(UTexture2D NewSprite,int NewU,int NewUL,int NewV,int NewVL) {}
	///<summary>Changed the opacity masked used by this component</summary>
	public void SetOpacityMaskRefVal(float RefVal) {}
}
