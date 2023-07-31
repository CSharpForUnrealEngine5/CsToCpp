#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Options for exporting levels to USD format.</summary>
[CppInclude("LevelExporterUSDOptions.h")]
public partial class ULevelExporterUSDOptions : UObject {
	///<summary>Basic options about the stage to export</summary>
	public FUsdStageOptions StageOptions;
	///<summary>StartTimeCode to be used for all exported layers</summary>
	public float StartTimeCode;
	///<summary>EndTimeCode to be used for all exported layers</summary>
	public float EndTimeCode;
	///<summary>Inner struct that actually contains most of the export options</summary>
	public FLevelExporterUSDOptionsInner Inner;
	///<summary>Whether to export levels and LevelSequences even if the existing files already describe the same versions of compatible assets.</summary>
	public bool bReExportIdenticalLevelsAndSequences;
	///<summary>Whether to export any asset (StaticMesh, Material, etc.) even if the existing file already describes the same version of a compatible asset.</summary>
	public bool bReExportIdenticalAssets;
	///<summary>We temporarily stash our export task here as a way of passing our options down to</summary>
	public TWeakObjectPtr<UAssetExportTask> CurrentTask;
	///<summary>GetUsdExtensions</summary>
	public static TArray<string> GetUsdExtensions() { return default; }
}
