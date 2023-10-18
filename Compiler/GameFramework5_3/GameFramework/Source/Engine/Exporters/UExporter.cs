namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Exporters/Exporter.h")]
public partial class UExporter : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Supported class of this exporter</summary>
	public UClass SupportedClass;
	///<summary>The root scope of objects to be exported, only used if PPF_ExportsNotFullyQualfied is set</summary>
	public UObject ExportRootScope;
	///<summary>File extension to use for this exporter</summary>
	public TArray<string> FormatExtension;
	///<summary>Descriptiong of the export format</summary>
	public TArray<string> FormatDescription;
	///<summary>Index into FormatExtension/FormatDescription of the preferred export format.</summary>
	public int PreferredFormatIndex;
	///<summary>Current indentation of spaces of the exported text</summary>
	public int TextIndent;
	///<summary>If true, this will export the data as text</summary>
	public bool bText;
	///<summary>If true, this will export only the selected objects</summary>
	public bool bSelectedOnly;
	///<summary>If true, this will force the exporter code to create a file-based Ar (this can keep large output files from taking too much memory)</summary>
	public bool bForceFileOperations;
	///<summary>ExportTask</summary>
	public UAssetExportTask ExportTask;
	///<summary>Export the given object to file.  Child classes do not override this, but they do provide an Export() function</summary>
	public static bool RunAssetExportTask(UAssetExportTask Task) { return default; }
	///<summary>Export the given object to file.  Overridden by script based exporters.</summary>
	public bool ScriptRunAssetExportTask(UAssetExportTask Task) { return default; }
	///<summary>Export the given objects to files.  Child classes do not override this, but they do provide an Export() function</summary>
	public static bool RunAssetExportTasks(TArray<UAssetExportTask> ExportTasks) { return default; }
}
