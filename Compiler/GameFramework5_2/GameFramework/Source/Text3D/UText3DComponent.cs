#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Text3DComponent.h")]
public partial class UText3DComponent : USceneComponent {
// Text3DComponent
	public string Text;
	public float Extrude;
	public float Bevel;
	public EText3DBevelType BevelType;
	public int BevelSegments;
	public bool bOutline;
	public float OutlineExpand;
	public UMaterialInterface FrontMaterial;
	public UMaterialInterface BevelMaterial;
	public UMaterialInterface ExtrudeMaterial;
	public UMaterialInterface BackMaterial;
	public UFont Font;
	public EText3DHorizontalTextAlignment HorizontalAlignment;
	public EText3DVerticalTextAlignment VerticalAlignment;
	public float Kerning;
	public float LineSpacing;
	public float WordSpacing;
	public bool bHasMaxWidth;
	public float MaxWidth;
	public bool bHasMaxHeight;
	public float MaxHeight;
	public bool bScaleProportionally;
	public bool bCastShadow;
	public  void FTextGenerated() {}
	public  void SetText(string Value) {}
	public  void SetFont(UFont InFont) {}
	public  void SetOutline(bool bValue) {}
	public  void SetOutlineExpand(float Value) {}
	public  void SetExtrude(float Value) {}
	public  void SetBevel(float Value) {}
	public  void SetBevelType(EText3DBevelType Value) {}
	public  void SetBevelSegments(int Value) {}
	public  void SetFrontMaterial(UMaterialInterface Value) {}
	public  void SetBevelMaterial(UMaterialInterface Value) {}
	public  void SetExtrudeMaterial(UMaterialInterface Value) {}
	public  void SetBackMaterial(UMaterialInterface Value) {}
	public  void SetKerning(float Value) {}
	public  void SetLineSpacing(float Value) {}
	public  void SetWordSpacing(float Value) {}
	public  void SetHorizontalAlignment(EText3DHorizontalTextAlignment value) {}
	public  void SetVerticalAlignment(EText3DVerticalTextAlignment value) {}
	public  void SetHasMaxWidth(bool Value) {}
	public  void SetMaxWidth(float Value) {}
	public  void SetHasMaxHeight(bool Value) {}
	public  void SetMaxHeight(float Value) {}
	public  void SetScaleProportionally(bool Value) {}
	public  void SetFreeze(bool bFreeze) {}
	public  void SetCastShadow(bool NewCastShadow) {}
	public  void GetBounds(FVector Origin,FVector BoxExtent) {}
	public  int GetGlyphCount() { return default; }
	public  USceneComponent GetGlyphKerningComponent(int Index) { return default; }
	public  TArray<USceneComponent> GetGlyphKerningComponents() { return default; }
	public  UStaticMeshComponent GetGlyphMeshComponent(int Index) { return default; }
	public  TArray<UStaticMeshComponent> GetGlyphMeshComponents() { return default; }
	public  FVector GetTextScale() { return default; }
	public USceneComponent TextRoot;
	public FTextGenerated TextGeneratedDelegate;
	public TArray<USceneComponent> CharacterKernings;
	public TArray<UStaticMeshComponent> CharacterMeshes;
}
