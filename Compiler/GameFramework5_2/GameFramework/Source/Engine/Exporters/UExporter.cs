#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Exporters/Exporter.h")]
public partial class UExporter : UObject {
// Exporter
	public UClass SupportedClass;
	public UObject ExportRootScope;
	public TArray<string> FormatExtension;
	public TArray<string> FormatDescription;
	public int PreferredFormatIndex;
	public int TextIndent;
	public bool bText;
	public bool bSelectedOnly;
	public bool bForceFileOperations;
	public UAssetExportTask ExportTask;
	public static bool RunAssetExportTask(UAssetExportTask Task) { return default; }
	public  bool ScriptRunAssetExportTask(UAssetExportTask Task) { return default; }
	public static bool RunAssetExportTasks(TArray<UAssetExportTask> ExportTasks) { return default; }
}
