namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Namespaced user data which provides access to a linked data asset</summary>
[CppInclude("RigVMCore/RigVMAssetUserData.h")]
public partial class UDataAssetLink : UNameSpacedUserData {
	public static UClass StaticClass() {return default;}
	///<summary>If assigned, the data asset link will provide access to the data asset&#39;s content.</summary>
	public UDataAsset DataAsset;
	///<summary>GetDataAsset</summary>
	public UDataAsset GetDataAsset() { return default; }
	///<summary>SetDataAsset</summary>
	public void SetDataAsset(UDataAsset InDataAsset) {}
}
