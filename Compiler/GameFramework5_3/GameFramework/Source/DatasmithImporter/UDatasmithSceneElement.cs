namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithBlueprintLibrary.h")]
public partial class UDatasmithSceneElement : UDatasmithSceneElementBase {
	public static UClass StaticClass() {return default;}
	///<summary>Open an existing UDatasmith file from disk.</summary>
	public static UDatasmithSceneElement ConstructDatasmithSceneFromFile(string FilePath) { return default; }
	///<summary>Open an existing Datasmith source from the SourceUri.</summary>
	public static UDatasmithSceneElement ConstructDatasmithSceneFromSourceUri(string SourceUri) { return default; }
	///<summary>Open set of CAD files as actors in a single datasmith scene</summary>
	public static UDatasmithSceneElement ConstructDatasmithSceneFromCADFiles(TArray<string> FilePaths) { return default; }
	///<summary>Open an existing DatasmithScene asset file from disk.</summary>
	public static UDatasmithSceneElement GetExistingDatasmithScene(string AssetPath) { return default; }
	///<summary>Trigger the translation phase, which populates the DatasmithScene.</summary>
	public bool TranslateScene() { return default; }
	///<summary>Import a Datasmith Scene created with ConstructDatasmithSceneFromFile.</summary>
	public FDatasmithImportFactoryCreateFileResult ImportScene(string DestinationFolder) { return default; }
	///<summary>Import a Datasmith Scene created with ConstructDatasmithSceneFromFiles into an array of scenes.</summary>
	public TArray<FDatasmithImportFactoryCreateFileResult> ImportScenes(string DestinationFolder) { return default; }
	///<summary>Reimport a scene opened with GetExistingDatasmithScene</summary>
	public FDatasmithImportFactoryCreateFileResult ReimportScene() { return default; }
	///<summary>Fetch the typed options for this scene</summary>
	public UObject GetOptions(UClass OptionType/*=nullptr*/) { return default; }
	///<summary>List all the options structures applicable on this scene</summary>
	public TMap<UClass,UObject> GetAllOptions() { return default; }
	///<summary>GetImportOptions</summary>
	public UDatasmithImportOptions GetImportOptions() { return default; }
	///<summary>Destroy reference to the udatasmith file. The Scene will no longer be available.</summary>
	public void DestroyScene() {}
}
