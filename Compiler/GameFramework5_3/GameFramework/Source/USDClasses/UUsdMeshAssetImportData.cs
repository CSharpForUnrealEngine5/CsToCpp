namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>We assign these to UStaticMeshes or USkeletalMeshes generated from USD</summary>
[CppInclude("USDAssetImportData.h")]
public partial class UUsdMeshAssetImportData : UUsdAssetImportData {
	public static UClass StaticClass() {return default;}
	///<summary>Maps from a material slot index of an UStaticMesh or USkeletalMesh to a list of source prims that contain this</summary>
	public TMap<int,FUsdPrimPathList> MaterialSlotToPrimPaths;
}
