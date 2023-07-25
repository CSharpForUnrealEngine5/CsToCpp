#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDStageEditorBlueprintLibrary.h")]
///<summary>Library of functions that can be used from scripting to interact with the USD Stage Editor UI</summary>
public partial class UUsdStageEditorBlueprintLibrary : UBlueprintFunctionLibrary {
// UsdStageEditorBlueprintLibrary
	public bool OpenStageEditor() { return default; }
	public bool CloseStageEditor() { return default; }
	public UObject GetAttachedStageActor() { return default; }
	public bool SetAttachedStageActor(UObject NewActor) { return default; }
	public TArray<string> GetSelectedLayerIdentifiers() { return default; }
	public void SetSelectedLayerIdentifiers(TArray<string> NewSelection) {}
	public TArray<string> GetSelectedPrimPaths() { return default; }
	public void SetSelectedPrimPaths(TArray<string> NewSelection) {}
	public TArray<string> GetSelectedPropertyNames() { return default; }
	public void SetSelectedPropertyNames(TArray<string> NewSelection) {}
	public void FileNew() {}
	public void FileOpen(string FilePath) {}
	public void FileSave(string OutputFilePathIfUnsaved) {}
	public void FileExportAllLayers(string OutputDirectory) {}
	public void FileExportFlattenedStage(string OutputLayer) {}
	public void FileReload() {}
	public void FileReset() {}
	public void FileClose() {}
	public void ActionsImport(string OutputContentFolder,UObject Options) {}
	public void ExportSelectedLayers(string OutputDirectory) {}
}
