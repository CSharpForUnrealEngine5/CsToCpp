namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A generic class for FBX parser errors, with no additional metadata, and where the text is specified by the user</summary>
[CppInclude("Fbx/InterchangeFbxMessages.h")]
public partial class UInterchangeResultMeshError_Generic : UInterchangeResultMeshError {
	public static UClass StaticClass() {return default;}
	///<summary>Text</summary>
	public FText Text;
}
