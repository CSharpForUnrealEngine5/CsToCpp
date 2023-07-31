#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MSAssetImportData.h")]
public partial struct FMeshInfo {
	public string meshID;
	public string name;
	public string path;
	public short numberOfLods;
	public TArray<FMaterialUsage> materialUsage;
}
