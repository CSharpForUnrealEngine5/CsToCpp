#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDAssetImportData.h")]
///<summary>We assign these to UStaticMeshes or USkeletalMeshes generated from USD</summary>
public partial class UUsdMeshAssetImportData : UUsdAssetImportData {
// UsdMeshAssetImportData
	public TMap<int,FUsdPrimPathList> MaterialSlotToPrimPaths;
}
