#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ArrowComponent.h")]
///<summary>A simple arrow rendered using lines. Useful for indicating which way an object is facing.</summary>
public partial class UArrowComponent : UPrimitiveComponent {
// ArrowComponent
	public FColor ArrowColor;
	public float ArrowSize;
	public float ArrowLength;
	public float ScreenSize;
	public bool bIsScreenSizeScaled;
	public bool bTreatAsASprite;
	public string SpriteCategoryName_DEPRECATED;
	public FSpriteCategoryInfo SpriteInfo;
	public bool bLightAttachment;
	public bool bUseInEditorScaling;
	public  void SetArrowColor(FLinearColor NewColor) {}
	public  void SetArrowFColor(FColor NewColor) {}
	public  void SetArrowSize(float NewSize) {}
	public  void SetArrowLength(float NewLength) {}
	public  void SetScreenSize(float NewScreenSize) {}
	public  void SetIsScreenSizeScaled(bool bNewValue) {}
	public  void SetTreatAsASprite(bool bNewValue) {}
	public  void SetUseInEditorScaling(bool bNewValue) {}
}
