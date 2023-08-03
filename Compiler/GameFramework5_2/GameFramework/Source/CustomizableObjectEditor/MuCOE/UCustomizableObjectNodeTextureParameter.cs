#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeTextureParameter.h")]
public partial class UCustomizableObjectNodeTextureParameter : UCustomizableObjectNode {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultValue</summary>
	public UTexture2D DefaultValue;
	///<summary>ParameterName</summary>
	public string ParameterName;
	///<summary>ParamUIMetadata</summary>
	public FMutableParamUIMetadata ParamUIMetadata;
	///<summary>Set the width of the Texture when there is no texture reference.</summary>
	public int TextureSizeX;
	///<summary>Set the height of the Texture when there is no texture reference.</summary>
	public int TextureSizeY;
}
