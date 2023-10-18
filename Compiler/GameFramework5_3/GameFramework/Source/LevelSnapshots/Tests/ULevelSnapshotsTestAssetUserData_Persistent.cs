namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>These classes do nothing special. See UActorComponent::AddAssetUserData: it only allows one instance per unique class... this is why we must create a few additional classes.</summary>
[CppInclude("Tests/Types/LevelSnapshotsTestAssetUserData.h")]
public partial class ULevelSnapshotsTestAssetUserData_Persistent : UAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>Value</summary>
	public int Value;
}
