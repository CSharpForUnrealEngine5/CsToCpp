#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains data for a group of assets to import</summary>
[CppInclude("SequencerExportTask.h")]
public partial class USequencerExportTask : UAssetExportTask {
	///<summary>A UWorld for LevelSequences, UUserWidget for WidgetAnimations, or AActor for Actor Sequences, etc...</summary>
	public UObject SequencerContext;
}
