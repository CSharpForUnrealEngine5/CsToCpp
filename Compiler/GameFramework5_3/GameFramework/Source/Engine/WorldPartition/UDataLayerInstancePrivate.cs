namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/DataLayer/DataLayerInstancePrivate.h")]
public partial class UDataLayerInstancePrivate : UDataLayerInstance {
	public static UClass StaticClass() {return default;}
	///<summary>ShortName</summary>
	public string ShortName;
	///<summary>DataLayerAsset</summary>
	public UDataLayerAsset DataLayerAsset;
	///<summary>Whether actors assigned to this DataLayer are included by default when used in a filter</summary>
	public bool bIsIncludedInActorFilterDefault;
}
