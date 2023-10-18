namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for FBX parser errors</summary>
[CppInclude("Fbx/InterchangeFbxMessages.h")]
public partial class UInterchangeResultMeshError : UInterchangeResultError {
	public static UClass StaticClass() {return default;}
	///<summary>MeshName</summary>
	public string MeshName;
}
