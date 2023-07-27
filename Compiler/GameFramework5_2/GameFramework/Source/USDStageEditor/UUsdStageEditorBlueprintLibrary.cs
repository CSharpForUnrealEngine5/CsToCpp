#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDStageEditorBlueprintLibrary.h")]
///<summary>Library of functions that can be used from scripting to interact with the USD Stage Editor UI</summary>
public partial class UUsdStageEditorBlueprintLibrary : UBlueprintFunctionLibrary {
// UsdStageEditorBlueprintLibrary
	public static bool OpenStageEditor() { return default; }
	public static bool CloseStageEditor() { return default; }
	public static AUsdStageActor GetAttachedStageActor() { return default; }
	public static bool SetAttachedStageActor(AUsdStageActor NewActor) { return default; }
	public static TArray<string> GetSelectedLayerIdentifiers() { return default; }
	public static void SetSelectedLayerIdentifiers(TArray<string> NewSelection) {}
	public static TArray<string> GetSelectedPrimPaths() { return default; }
	public static void SetSelectedPrimPaths(TArray<string> NewSelection) {}
	public static TArray<string> GetSelectedPropertyNames() { return default; }
	public static void SetSelectedPropertyNames(TArray<string> NewSelection) {}
	public static void FileNew() {}
	public static void FileOpen(string FilePath) {}
	public static void FileSave(string OutputFilePathIfUnsaved) {}
	public static void FileExportAllLayers(string OutputDirectory) {}
	public static void FileExportFlattenedStage(string OutputLayer) {}
	public static void FileReload() {}
	public static void FileReset() {}
	public static void FileClose() {}
	public static void ActionsImport(string OutputContentFolder,UUsdStageImportOptions Options) {}
	public static void ExportSelectedLayers(string OutputDirectory) {}
}
