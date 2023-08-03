#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset user data that can be used with Datasmith on Actors and other objects</summary>
[CppInclude("DatasmithAssetUserData.h")]
public partial class UDatasmithAssetUserData : UAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>MetaData</summary>
	public TMap<string,string> MetaData;
	///<summary>ObjectTemplates</summary>
	public TMap<UClass,UDatasmithObjectTemplate> ObjectTemplates;
}
