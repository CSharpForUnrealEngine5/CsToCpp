namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FCreateMaterialObjectResult is returned by UModelingObjectsCreationAPI::CreateMaterialObject()</summary>
[CppInclude("ModelingObjectsCreationAPI.h")]
public partial struct FCreateMaterialObjectResult {
	public ECreateModelingObjectResult ResultCode;
	public UObject NewAsset;
}
