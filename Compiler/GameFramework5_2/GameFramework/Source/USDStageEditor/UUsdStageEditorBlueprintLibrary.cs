namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Library of functions that can be used from scripting to interact with the USD Stage Editor UI</summary>
[CppInclude("USDStageEditorBlueprintLibrary.h")]
public partial class UUsdStageEditorBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Opens the the USD Stage Editor window, or focus it in case it is already open.</summary>
	public static bool OpenStageEditor() { return default; }
	///<summary>Closes the USD Stage Editor window if it is opened. Does nothing in case it is already closed.</summary>
	public static bool CloseStageEditor() { return default; }
	///<summary>Gets which actor is currently attached to the USD Stage Editor, if any.</summary>
	public static AUsdStageActor GetAttachedStageActor() { return default; }
	///<summary>Sets which actor is currently attached to the USD Stage Editor.</summary>
	public static bool SetAttachedStageActor(AUsdStageActor NewActor) { return default; }
	///<summary>Returns the full identifiers of all layers that are currently selected on the USD Stage Editor.</summary>
	public static TArray<string> GetSelectedLayerIdentifiers() { return default; }
	///<summary>Sets the USD Stage Editor layer selection to all occurences of the layers with identifiers</summary>
	public static void SetSelectedLayerIdentifiers(TArray<string> NewSelection) {}
	///<summary>Returns the full paths to all prims currently selected on the USD Stage Editor.</summary>
	public static TArray<string> GetSelectedPrimPaths() { return default; }
	///<summary>Sets the USD Stage Editor prim selection to the prims with paths contained in NewSelection.</summary>
	public static void SetSelectedPrimPaths(TArray<string> NewSelection) {}
	///<summary>Returns the names of the currently selected properties on the right panel of the USD Stage Editor.</summary>
	public static TArray<string> GetSelectedPropertyNames() { return default; }
	///<summary>Sets the USD Stage Editor property selection to the properties with names contained in NewSelection.</summary>
	public static void SetSelectedPropertyNames(TArray<string> NewSelection) {}
	///<summary>Creates a new memory-only layer and opens an USD Stage with that layer as its root.</summary>
	public static void FileNew() {}
	///<summary>Opens an USD Stage from a file on disk.</summary>
	public static void FileOpen(string FilePath) {}
	///<summary>Saves the currently opened USD Stage back to disk, or to a new file in case it hasn&#39;t been saved yet.</summary>
	public static void FileSave(string OutputFilePathIfUnsaved) {}
	///<summary>Exports all layers of the currently opened USD Stage to brand new files in a new location.</summary>
	public static void FileExportAllLayers(string OutputDirectory) {}
	///<summary>Exports the currently opened USD Stage to a single &quot;flattened&quot; USD layer.</summary>
	public static void FileExportFlattenedStage(string OutputLayer) {}
	///<summary>Reloads all layers of the current USD Stage.</summary>
	public static void FileReload() {}
	///<summary>Resets the state of the current USD Stage (which layers are muted, the current edit target, etc.).</summary>
	public static void FileReset() {}
	///<summary>Closes the currently opened USD Stage (by clearing the attached Stage Actor&#39;s RootLayer property).</summary>
	public static void FileClose() {}
	///<summary>Imports the currently opened USD Stage into persistent UE assets, actors and components on the level.</summary>
	public static void ActionsImport(string OutputContentFolder,UUsdStageImportOptions Options) {}
	///<summary>Exports the currently selected layers on the USD Stage Editor to brand new files in a new location.</summary>
	public static void ExportSelectedLayers(string OutputDirectory) {}
}
