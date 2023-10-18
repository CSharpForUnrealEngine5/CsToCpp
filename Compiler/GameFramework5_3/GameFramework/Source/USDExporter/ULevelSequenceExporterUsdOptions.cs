namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Options for level sequences to the USD format.</summary>
[CppInclude("LevelSequenceExporterUSDOptions.h")]
public partial class ULevelSequenceExporterUsdOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Export options to use for the layer where the animation is emitted</summary>
	public FUsdStageOptions StageOptions;
	///<summary>Value to bake all generated USD layers with</summary>
	public float TimeCodesPerSecond;
	///<summary>If checked will cause StartFrame and EndFrame to be used as the frame range for the level sequence export.</summary>
	public bool bOverrideExportRange;
	///<summary>Initial frame of the level sequence to bake out to USD (inclusive)</summary>
	public int StartFrame;
	///<summary>Final frame of the level sequence to bake out to USD (inclusive)</summary>
	public int EndFrame;
	///<summary>Whether to export animations exclusively from selected actors or components</summary>
	public bool bSelectionOnly;
	///<summary>The effect of subsequences is always included on the main exported layer, but if this option is true we will also</summary>
	public bool bExportSubsequencesAsLayers;
	///<summary>Exports the provided level alongside the layer that represents the exported Level Sequence</summary>
	public bool bExportLevel;
	///<summary>If checked this will also add the exported level as a sublayer to the USD files emitted for all exported level sequences</summary>
	public bool bUseExportedLevelAsSublayer;
	///<summary>Whether to export levels and LevelSequences even if the existing files already describe the same versions of compatible assets.</summary>
	public bool bReExportIdenticalLevelsAndSequences;
	///<summary>Whether to export any asset (StaticMesh, Material, etc.) even if the existing file already describes the same version of a compatible asset.</summary>
	public bool bReExportIdenticalAssets;
	///<summary>Level</summary>
	public TWeakObjectPtr<UWorld> Level;
	///<summary>LevelExportOptions</summary>
	public FLevelExporterUSDOptionsInner LevelExportOptions;
}
