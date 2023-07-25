#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceExporterUSDOptions.h")]
///<summary>Options for level sequences to the USD format.</summary>
public partial class ULevelSequenceExporterUsdOptions : UObject {
// LevelSequenceExporterUsdOptions
	public FUsdStageOptions StageOptions;
	public float TimeCodesPerSecond;
	public bool bOverrideExportRange;
	public int StartFrame;
	public int EndFrame;
	public bool bSelectionOnly;
	public bool bExportSubsequencesAsLayers;
	public bool bExportLevel;
	public bool bUseExportedLevelAsSublayer;
	public bool bReExportIdenticalLevelsAndSequences;
	public bool bReExportIdenticalAssets;
	public TWeakObjectPtr<UWorld> Level;
	public FLevelExporterUSDOptionsInner LevelExportOptions;
}
