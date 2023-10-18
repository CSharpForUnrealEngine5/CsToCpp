namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/DataLayer/DataLayerInstanceWithAsset.h")]
public partial class UDataLayerInstanceWithAsset : UDataLayerInstance {
	public static UClass StaticClass() {return default;}
	///<summary>DataLayerAsset</summary>
	public UDataLayerAsset DataLayerAsset;
	///<summary>Whether actors assigned to this DataLayer are included by default when used in a filter</summary>
	public bool bIsIncludedInActorFilterDefault;
}
