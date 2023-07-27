#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/TextRenderComponent.h")]
///<summary>Renders text in the world with given font. Contains usual font related attributes such as Scale, Alignment, Color etc.</summary>
public partial class UTextRenderComponent : UPrimitiveComponent {
// TextRenderComponent
	public string Text;
	public UMaterialInterface TextMaterial;
	public UFont Font;
	public EHorizTextAligment HorizontalAlignment;
	public EVerticalTextAligment VerticalAlignment;
	public FColor TextRenderColor;
	public float XScale;
	public float YScale;
	public float WorldSize;
	public float InvDefaultSize;
	public float HorizSpacingAdjust;
	public float VertSpacingAdjust;
	public bool bAlwaysRenderAsText;
	public  void K2_SetText(string Value) {}
	public  void SetTextMaterial(UMaterialInterface Material) {}
	public  void SetFont(UFont Value) {}
	public  void SetHorizontalAlignment(EHorizTextAligment Value) {}
	public  void SetVerticalAlignment(EVerticalTextAligment Value) {}
	public  void SetTextRenderColor(FColor Value) {}
	public  void SetXScale(float Value) {}
	public  void SetYScale(float Value) {}
	public  void SetHorizSpacingAdjust(float Value) {}
	public  void SetVertSpacingAdjust(float Value) {}
	public  void SetWorldSize(float Value) {}
	public  FVector GetTextLocalSize() { return default; }
	public  FVector GetTextWorldSize() { return default; }
}
