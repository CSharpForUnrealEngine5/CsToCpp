#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepAssetUserData.h")]
///<summary>A DataprepAssetUserData is used to mark assets or actors created through a Dataprep pipeline</summary>
public partial class UDataprepAssetUserData : UAssetUserData {
// DataprepAssetUserData
	public TSoftObjectPtr<UDataprepEditingOperation> DataprepOperationPtr;
	public TSoftObjectPtr<UDataprepAssetInterface> DataprepAssetPtr;
}
