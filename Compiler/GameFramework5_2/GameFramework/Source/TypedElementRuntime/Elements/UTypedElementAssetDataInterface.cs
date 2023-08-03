#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Interfaces/TypedElementAssetDataInterface.h")]
public partial class UTypedElementAssetDataInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Returns any asset datas for content objects referenced by handle.</summary>
	public  TArray<FAssetData> GetAllReferencedAssetDatas(FScriptTypedElementHandle InElementHandle) { return default; }
	///<summary>Returns the asset data for the given handle, if it exists.</summary>
	public  FAssetData GetAssetData(FScriptTypedElementHandle InElementHandle) { return default; }
}
