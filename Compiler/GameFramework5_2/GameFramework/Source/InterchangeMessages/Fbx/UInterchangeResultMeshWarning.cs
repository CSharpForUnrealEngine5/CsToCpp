namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for FBX parser warnings</summary>
[CppInclude("Fbx/InterchangeFbxMessages.h")]
public partial class UInterchangeResultMeshWarning : UInterchangeResultWarning {
	public static UClass StaticClass() {return default;}
	///<summary>MeshName</summary>
	public string MeshName;
}
