#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Statistics for the Texture Analyzer</summary>
[CppInclude("MuCOE/CustomizableObjectEditor.h")]
public partial class UCustomizableObjectEditorTextureStats : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Texture - double click to open</summary>
	public string TextureName;
	///<summary>Texture - double click to open</summary>
	public string TextureParameterName;
	///<summary>Material - double click to open</summary>
	public string MaterialName;
	///<summary>Parent Material - double click to open</summary>
	public string MaterialParameterName;
	///<summary>Used to open the texture in the editor</summary>
	public UTexture Texture;
	///<summary>Used to open the material in the editor</summary>
	public UMaterialInterface Material;
	///<summary>Used to open the parent material in the editor</summary>
	public UMaterialInterface ParentMaterial;
	///<summary>Resolution of the texture</summary>
	public int ResolutionX;
	///<summary>ResolutionY</summary>
	public int ResolutionY;
	///<summary>The memory used in KB</summary>
	public string Size;
	///<summary>The texture format, e.g. PF_DXT1</summary>
	public EPixelFormat Format;
	///<summary>LOD Bias for this texture. (Texture LODBias + Texture group)</summary>
	public int LODBias;
	///<summary>Says if the texture is being streamed</summary>
	public string IsStreamed;
	///<summary>The Level of detail group of the texture</summary>
	public TextureGroup LODGroup;
	///<summary>The Component of the texture</summary>
	public int Component;
}
