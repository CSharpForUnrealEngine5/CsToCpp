namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains data for a group of assets to import</summary>
[CppInclude("SequencerExportTask.h")]
public partial class USequencerExportTask : UAssetExportTask {
	public static UClass StaticClass() {return default;}
	///<summary>A UWorld for LevelSequences, UUserWidget for WidgetAnimations, or AActor for Actor Sequences, etc...</summary>
	public UObject SequencerContext;
}
