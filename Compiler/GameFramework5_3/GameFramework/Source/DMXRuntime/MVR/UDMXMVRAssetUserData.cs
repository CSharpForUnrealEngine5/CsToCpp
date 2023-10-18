namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset user data for Actors in an MVR Scene</summary>
[CppInclude("MVR/DMXMVRAssetUserData.h")]
public partial class UDMXMVRAssetUserData : UAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>MVR Meta Data for the Actor</summary>
	public TMap<FName,string> MetaData;
}
