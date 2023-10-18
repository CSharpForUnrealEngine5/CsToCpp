namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for FBX parser warnings</summary>
[CppInclude("Fbx/InterchangeFbxMessages.h")]
public partial class UInterchangeResultTextureWarning : UInterchangeResultWarning {
	public static UClass StaticClass() {return default;}
	///<summary>TextureName</summary>
	public string TextureName;
}
