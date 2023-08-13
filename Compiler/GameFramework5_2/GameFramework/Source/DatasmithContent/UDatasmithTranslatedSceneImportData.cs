namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Import data and options specific to Datasmith scenes imported through the translator system</summary>
[CppInclude("DatasmithAssetImportData.h")]
public partial class UDatasmithTranslatedSceneImportData : UDatasmithSceneImportData {
	public static UClass StaticClass() {return default;}
	///<summary>AdditionalOptions</summary>
	public TArray<UDatasmithOptionsBase> AdditionalOptions;
}
