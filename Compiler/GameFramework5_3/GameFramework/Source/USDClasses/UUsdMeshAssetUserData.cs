namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>We assign these to UStaticMeshes or USkeletalMeshes generated from USD</summary>
[CppInclude("USDAssetUserData.h")]
public partial class UUsdMeshAssetUserData : UUsdAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>Maps from a material slot index of an UStaticMesh or USkeletalMesh to a list of source prims that contain this</summary>
	public TMap<int,FUsdPrimPathList> MaterialSlotToPrimPaths;
	///<summary>Describes which primvars should be assigned to each UV index.</summary>
	public TMap<string,int> PrimvarToUVIndex;
}
