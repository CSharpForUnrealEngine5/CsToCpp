#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithAssetUserData.h")]
///<summary>Asset user data that can be used with Datasmith on Actors and other objects</summary>
public partial class UDatasmithAssetUserData : UAssetUserData {
// DatasmithAssetUserData
	public TMap<string,string> MetaData;
	public TMap<UClass,UDatasmithObjectTemplate> ObjectTemplates;
}
