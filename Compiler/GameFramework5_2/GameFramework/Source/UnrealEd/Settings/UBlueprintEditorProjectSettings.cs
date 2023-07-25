#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/BlueprintEditorProjectSettings.h")]
public partial class UBlueprintEditorProjectSettings : UDeveloperSettings {
// BlueprintEditorProjectSettings
	public bool bForceAllDependenciesToRecompile;
	public bool bValidateUnloadedSoftActorReferences;
	public bool bEnableChildActorExpansionInTreeView;
	public EChildActorComponentTreeViewVisualizationMode DefaultChildActorTreeViewMode;
	public TArray<string> NamespacesToAlwaysInclude;
	public TArray<string> DisabledCompilerMessagesExceptEditor;
	public TArray<string> DisabledCompilerMessages;
	public TArray<string> SuppressedDeprecationMessages;
	public TArray<TSoftObjectPtr<UClass>> BaseClassesToAllowRecompilingDuringPlayInEditor;
}
