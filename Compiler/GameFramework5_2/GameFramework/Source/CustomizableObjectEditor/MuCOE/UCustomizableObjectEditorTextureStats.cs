#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/CustomizableObjectEditor.h")]
///<summary>Statistics for the Texture Analyzer</summary>
public partial class UCustomizableObjectEditorTextureStats : UObject {
// CustomizableObjectEditorTextureStats
	public string TextureName;
	public string TextureParameterName;
	public string MaterialName;
	public string MaterialParameterName;
	public UTexture Texture;
	public UMaterialInterface Material;
	public UMaterialInterface ParentMaterial;
	public int ResolutionX;
	public int ResolutionY;
	public string Size;
	public EPixelFormat Format;
	public int LODBias;
	public string IsStreamed;
	public TextureGroup LODGroup;
	public int Component;
}
