#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple arrow rendered using lines. Useful for indicating which way an object is facing.</summary>
[CppInclude("Components/ArrowComponent.h")]
public partial class UArrowComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Color to draw arrow</summary>
	public FColor ArrowColor;
	///<summary>Relative size to scale drawn arrow by</summary>
	public float ArrowSize;
	///<summary>Total length of drawn arrow including head</summary>
	public float ArrowLength;
	///<summary>The size on screen to limit this arrow to (in screen space)</summary>
	public float ScreenSize;
	///<summary>Set to limit the screen size of this arrow</summary>
	public bool bIsScreenSizeScaled;
	///<summary>If true, don&#39;t show the arrow when EngineShowFlags.BillboardSprites is disabled.</summary>
	public bool bTreatAsASprite;
	///<summary>Sprite category that the arrow component belongs to, if being treated as a sprite. Value serves as a key into the localization file.</summary>
	public string SpriteCategoryName_DEPRECATED;
	///<summary>Sprite category information regarding the arrow component, if being treated as a sprite.</summary>
	public FSpriteCategoryInfo SpriteInfo;
	///<summary>If true, this arrow component is attached to a light actor</summary>
	public bool bLightAttachment;
	///<summary>Whether to use in-editor arrow scaling (i.e. to be affected by the global arrow scale)</summary>
	public bool bUseInEditorScaling;
	///<summary>Updates the arrow&#39;s colour, and tells it to refresh</summary>
	public  void SetArrowColor(FLinearColor NewColor) {}
	///<summary>SetArrowFColor</summary>
	public  void SetArrowFColor(FColor NewColor) {}
	///<summary>SetArrowSize</summary>
	public  void SetArrowSize(float NewSize) {}
	///<summary>SetArrowLength</summary>
	public  void SetArrowLength(float NewLength) {}
	///<summary>SetScreenSize</summary>
	public  void SetScreenSize(float NewScreenSize) {}
	///<summary>SetIsScreenSizeScaled</summary>
	public  void SetIsScreenSizeScaled(bool bNewValue) {}
	///<summary>SetTreatAsASprite</summary>
	public  void SetTreatAsASprite(bool bNewValue) {}
	///<summary>SetUseInEditorScaling</summary>
	public  void SetUseInEditorScaling(bool bNewValue) {}
}
