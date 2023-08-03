#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Text3DComponent.h")]
public partial class UText3DComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The text to generate a 3d mesh</summary>
	public string Text;
	///<summary>Size of the extrude</summary>
	public float Extrude;
	///<summary>Size of bevel</summary>
	public float Bevel;
	///<summary>Bevel Type</summary>
	public EText3DBevelType BevelType;
	///<summary>Bevel Segments (Defines the amount of tesselation for the bevel part)</summary>
	public int BevelSegments;
	///<summary>Generate Outline</summary>
	public bool bOutline;
	///<summary>Outline expand/offset amount</summary>
	public float OutlineExpand;
	///<summary>Material for the front part</summary>
	public UMaterialInterface FrontMaterial;
	///<summary>Material for the bevel part</summary>
	public UMaterialInterface BevelMaterial;
	///<summary>Material for the extruded part</summary>
	public UMaterialInterface ExtrudeMaterial;
	///<summary>Material for the back part</summary>
	public UMaterialInterface BackMaterial;
	///<summary>Text font</summary>
	public UFont Font;
	///<summary>Horizontal text alignment</summary>
	public EText3DHorizontalTextAlignment HorizontalAlignment;
	///<summary>Vertical text alignment</summary>
	public EText3DVerticalTextAlignment VerticalAlignment;
	///<summary>Text kerning</summary>
	public float Kerning;
	///<summary>Extra line spacing</summary>
	public float LineSpacing;
	///<summary>Extra word spacing</summary>
	public float WordSpacing;
	///<summary>Enables a maximum width to the 3D Text</summary>
	public bool bHasMaxWidth;
	///<summary>Sets a maximum width to the 3D Text</summary>
	public float MaxWidth;
	///<summary>Enables a maximum height to the 3D Text</summary>
	public bool bHasMaxHeight;
	///<summary>Sets a maximum height to the 3D Text</summary>
	public float MaxHeight;
	///<summary>Should the mesh scale proportionally when Max Width/Height is set</summary>
	public bool bScaleProportionally;
	///<summary>Controls whether the text glyphs should cast a shadow or not.</summary>
	public bool bCastShadow;
	///<summary>Delegate called after text is rebuilt</summary>
	public  void FTextGenerated() {}
	///<summary>Set the text value and signal the primitives to be rebuilt</summary>
	public  void SetText(string Value) {}
	///<summary>Set the text font and signal the primitives to be rebuilt</summary>
	public  void SetFont(UFont InFont) {}
	///<summary>SetOutline</summary>
	public  void SetOutline(bool bValue) {}
	///<summary>SetOutlineExpand</summary>
	public  void SetOutlineExpand(float Value) {}
	///<summary>Set the text extrusion size and signal the primitives to be rebuilt</summary>
	public  void SetExtrude(float Value) {}
	///<summary>Set the 3d bevel value</summary>
	public  void SetBevel(float Value) {}
	///<summary>Set the 3d bevel type</summary>
	public  void SetBevelType(EText3DBevelType Value) {}
	///<summary>Set the amount of segments that will be used to tesselate the Bevel</summary>
	public  void SetBevelSegments(int Value) {}
	///<summary>Set the text front material</summary>
	public  void SetFrontMaterial(UMaterialInterface Value) {}
	///<summary>Set the text bevel material</summary>
	public  void SetBevelMaterial(UMaterialInterface Value) {}
	///<summary>Set the text extrude material</summary>
	public  void SetExtrudeMaterial(UMaterialInterface Value) {}
	///<summary>Set the text back material</summary>
	public  void SetBackMaterial(UMaterialInterface Value) {}
	///<summary>Set the kerning value and signal the primitives to be rebuilt</summary>
	public  void SetKerning(float Value) {}
	///<summary>Set the line spacing value and signal the primitives to be rebuilt</summary>
	public  void SetLineSpacing(float Value) {}
	///<summary>Set the word spacing value and signal the primitives to be rebuilt</summary>
	public  void SetWordSpacing(float Value) {}
	///<summary>Set the horizontal alignment value and signal the primitives to be rebuilt</summary>
	public  void SetHorizontalAlignment(EText3DHorizontalTextAlignment value) {}
	///<summary>Set the vertical alignment and signal the primitives to be rebuilt</summary>
	public  void SetVerticalAlignment(EText3DVerticalTextAlignment value) {}
	///<summary>Enable / Disable a Maximum Width</summary>
	public  void SetHasMaxWidth(bool Value) {}
	///<summary>Set the Maximum Width - If width is larger, mesh will scale down to fit MaxWidth value</summary>
	public  void SetMaxWidth(float Value) {}
	///<summary>Enable / Disable a Maximum Height</summary>
	public  void SetHasMaxHeight(bool Value) {}
	///<summary>Set the Maximum Height - If height is larger, mesh will scale down to fit MaxHeight value</summary>
	public  void SetMaxHeight(float Value) {}
	///<summary>Set if the mesh should scale proportionally when Max Width/Height is set</summary>
	public  void SetScaleProportionally(bool Value) {}
	///<summary>Freeze mesh rebuild, to avoid unnecessary mesh rebuilds when setting a few properties together</summary>
	public  void SetFreeze(bool bFreeze) {}
	///<summary>Changes the value of CastShadow.</summary>
	public  void SetCastShadow(bool NewCastShadow) {}
	///<summary>GetBounds</summary>
	public  void GetBounds(FVector Origin,FVector BoxExtent) {}
	///<summary>Gets the number of font glyphs that are currently used</summary>
	public  int GetGlyphCount() { return default; }
	///<summary>Gets the USceneComponent that a glyph is attached to</summary>
	public  USceneComponent GetGlyphKerningComponent(int Index) { return default; }
	///<summary>Gets all the glyph kerning components</summary>
	public  TArray<USceneComponent> GetGlyphKerningComponents() { return default; }
	///<summary>Gets the StaticMeshComponent of a glyph</summary>
	public  UStaticMeshComponent GetGlyphMeshComponent(int Index) { return default; }
	///<summary>Gets all the glyph meshes</summary>
	public  TArray<UStaticMeshComponent> GetGlyphMeshComponents() { return default; }
	///<summary>Gets the scale of actual text geometry, taking into account MaxWidth and MaxHeight constraints. This function will NOT return the component scale</summary>
	public  FVector GetTextScale() { return default; }
	///<summary>TextRoot</summary>
	public USceneComponent TextRoot;
	///<summary>TextGeneratedDelegate</summary>
	public FTextGenerated TextGeneratedDelegate;
	///<summary>CharacterKernings</summary>
	public TArray<USceneComponent> CharacterKernings;
	///<summary>CharacterMeshes</summary>
	public TArray<UStaticMeshComponent> CharacterMeshes;
}
