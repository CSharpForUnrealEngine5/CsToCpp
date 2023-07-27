#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithBlueprintLibrary.h")]
public partial class UDatasmithSceneElement : UDatasmithSceneElementBase {
// DatasmithSceneElement
	public static UDatasmithSceneElement ConstructDatasmithSceneFromFile(string FilePath) { return default; }
	public static UDatasmithSceneElement ConstructDatasmithSceneFromSourceUri(string SourceUri) { return default; }
	public static UDatasmithSceneElement ConstructDatasmithSceneFromCADFiles(TArray<string> FilePaths) { return default; }
	public static UDatasmithSceneElement GetExistingDatasmithScene(string AssetPath) { return default; }
	public  bool TranslateScene() { return default; }
	public  FDatasmithImportFactoryCreateFileResult ImportScene(string DestinationFolder) { return default; }
	public  TArray<FDatasmithImportFactoryCreateFileResult> ImportScenes(string DestinationFolder) { return default; }
	public  FDatasmithImportFactoryCreateFileResult ReimportScene() { return default; }
	public  UObject GetOptions(UClass OptionType/*=nullptr*/) { return default; }
	public  TMap<UClass,UObject> GetAllOptions() { return default; }
	public  UDatasmithImportOptions GetImportOptions() { return default; }
	public  void DestroyScene() {}
}
