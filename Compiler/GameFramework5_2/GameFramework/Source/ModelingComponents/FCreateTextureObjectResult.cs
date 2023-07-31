#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FCreateTextureObjectResult is returned by UModelingObjectsCreationAPI::CreateTextureObject()</summary>
[CppInclude("ModelingObjectsCreationAPI.h")]
public partial struct FCreateTextureObjectResult {
	public ECreateModelingObjectResult ResultCode;
	public UObject NewAsset;
}
