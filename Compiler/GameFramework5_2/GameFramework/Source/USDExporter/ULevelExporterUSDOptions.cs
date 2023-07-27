#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelExporterUSDOptions.h")]
///<summary>Options for exporting levels to USD format.</summary>
public partial class ULevelExporterUSDOptions : UObject {
// LevelExporterUSDOptions
	public FUsdStageOptions StageOptions;
	public float StartTimeCode;
	public float EndTimeCode;
	public FLevelExporterUSDOptionsInner Inner;
	public bool bReExportIdenticalLevelsAndSequences;
	public bool bReExportIdenticalAssets;
	public TWeakObjectPtr<UAssetExportTask> CurrentTask;
	public static TArray<string> GetUsdExtensions() { return default; }
}
