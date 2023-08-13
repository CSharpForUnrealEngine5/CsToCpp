namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A DataprepAssetUserData is used to mark assets or actors created through a Dataprep pipeline</summary>
[CppInclude("DataprepAssetUserData.h")]
public partial class UDataprepAssetUserData : UAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>Dataprep operation which was used to generate the hosting object, if applicable</summary>
	public TSoftObjectPtr<UDataprepEditingOperation> DataprepOperationPtr;
	///<summary>Dataprep asset which was used to generate the hosting object</summary>
	public TSoftObjectPtr<UDataprepAssetInterface> DataprepAssetPtr;
}
