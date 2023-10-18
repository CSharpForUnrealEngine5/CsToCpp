namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A generic class for FBX parser warnings, with no additional metadata, and where the text is specified by the user</summary>
[CppInclude("Fbx/InterchangeFbxMessages.h")]
public partial class UInterchangeResultTextureWarning_TextureFileDoNotExist : UInterchangeResultTextureWarning {
	public static UClass StaticClass() {return default;}
	///<summary>Text</summary>
	public FText Text;
	///<summary>MaterialName</summary>
	public string MaterialName;
}
