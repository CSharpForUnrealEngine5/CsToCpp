namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset user data that can be used with Datasmith on Actors and other objects</summary>
[CppInclude("DatasmithAssetUserData.h")]
public partial class UDatasmithAssetUserData : UAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>MetaData</summary>
	public TMap<FName,string> MetaData;
	///<summary>ObjectTemplates</summary>
	public TMap<UClass,UDatasmithObjectTemplate> ObjectTemplates;
}
