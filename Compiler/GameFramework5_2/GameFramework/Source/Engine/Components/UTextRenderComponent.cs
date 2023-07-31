#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Renders text in the world with given font. Contains usual font related attributes such as Scale, Alignment, Color etc.</summary>
[CppInclude("Components/TextRenderComponent.h")]
public partial class UTextRenderComponent : UPrimitiveComponent {
	///<summary>Text content, can be multi line using &lt;br&gt; as line separator</summary>
	public string Text;
	///<summary>Text material</summary>
	public UMaterialInterface TextMaterial;
	///<summary>Text font</summary>
	public UFont Font;
	///<summary>Horizontal text alignment</summary>
	public EHorizTextAligment HorizontalAlignment;
	///<summary>Vertical text alignment</summary>
	public EVerticalTextAligment VerticalAlignment;
	///<summary>Color of the text, can be accessed as vertex color</summary>
	public FColor TextRenderColor;
	///<summary>Horizontal scale, default is 1.0</summary>
	public float XScale;
	///<summary>Vertical scale, default is 1.0</summary>
	public float YScale;
	///<summary>Vertical size of the fonts largest character in world units. Transform, XScale and YScale will affect final size.</summary>
	public float WorldSize;
	///<summary>The inverse of the Font&#39;s character height.</summary>
	public float InvDefaultSize;
	///<summary>Horizontal adjustment per character, default is 0.0</summary>
	public float HorizSpacingAdjust;
	///<summary>Vertical adjustment per character, default is 0.0</summary>
	public float VertSpacingAdjust;
	///<summary>Allows text to draw unmodified when using debug visualization modes. *</summary>
	public bool bAlwaysRenderAsText;
	///<summary>Change the text value and signal the primitives to be rebuilt</summary>
	public  void K2_SetText(string Value) {}
	///<summary>Change the text material and signal the primitives to be rebuilt</summary>
	public  void SetTextMaterial(UMaterialInterface Material) {}
	///<summary>Change the font and signal the primitives to be rebuilt</summary>
	public  void SetFont(UFont Value) {}
	///<summary>Change the horizontal alignment and signal the primitives to be rebuilt</summary>
	public  void SetHorizontalAlignment(EHorizTextAligment Value) {}
	///<summary>Change the vertical alignment and signal the primitives to be rebuilt</summary>
	public  void SetVerticalAlignment(EVerticalTextAligment Value) {}
	///<summary>Change the text render color and signal the primitives to be rebuilt</summary>
	public  void SetTextRenderColor(FColor Value) {}
	///<summary>Change the text X scale and signal the primitives to be rebuilt</summary>
	public  void SetXScale(float Value) {}
	///<summary>Change the text Y scale and signal the primitives to be rebuilt</summary>
	public  void SetYScale(float Value) {}
	///<summary>Change the text horizontal spacing adjustment and signal the primitives to be rebuilt</summary>
	public  void SetHorizSpacingAdjust(float Value) {}
	///<summary>Change the text vertical spacing adjustment and signal the primitives to be rebuilt</summary>
	public  void SetVertSpacingAdjust(float Value) {}
	///<summary>Change the world size of the text and signal the primitives to be rebuilt</summary>
	public  void SetWorldSize(float Value) {}
	///<summary>Get local size of text</summary>
	public  FVector GetTextLocalSize() { return default; }
	///<summary>Get world space size of text</summary>
	public  FVector GetTextWorldSize() { return default; }
}
