#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset user data for Actors in an MVR Scene</summary>
[CppInclude("MVR/DMXMVRAssetUserData.h")]
public partial class UDMXMVRAssetUserData : UAssetUserData {
	///<summary>MVR Meta Data for the Actor</summary>
	public TMap<string,string> MetaData;
}
