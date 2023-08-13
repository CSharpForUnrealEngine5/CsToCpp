namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/BlueprintEditorProjectSettings.h")]
public partial class UBlueprintEditorProjectSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>bForceAllDependenciesToRecompile</summary>
	public bool bForceAllDependenciesToRecompile;
	///<summary>If enabled, the editor will load packages to look for soft references to actors when deleting/renaming them. This can be slow in large projects so disable this to improve performance but increase the chance of breaking blueprints/sequences that use soft actor references</summary>
	public bool bValidateUnloadedSoftActorReferences;
	///<summary>Enable the option to expand child actor components within component tree views (experimental).</summary>
	public bool bEnableChildActorExpansionInTreeView;
	///<summary>Default view mode to use for child actor components in a Blueprint actor&#39;s component tree hierarchy (experimental).</summary>
	public EChildActorComponentTreeViewVisualizationMode DefaultChildActorTreeViewMode;
	///<summary>A list of namespace identifiers that all Blueprint assets in the project should import by default. Requires Blueprint namespace features to be enabled in editor preferences. Editing this list will also cause any visible Blueprint editor windows to be closed.</summary>
	public TArray<string> NamespacesToAlwaysInclude;
	///<summary>List of compiler messages that have been suppressed outside of full, interactive editor sessions for</summary>
	public TArray<string> DisabledCompilerMessagesExceptEditor;
	///<summary>List of compiler messages that have been suppressed completely - message suppression is only</summary>
	public TArray<string> DisabledCompilerMessages;
	///<summary>List of deprecated UProperties/UFunctions to supress warning messages for - useful for source changes</summary>
	public TArray<string> SuppressedDeprecationMessages;
	///<summary>Any blueprint deriving from one of these base classes will be allowed to recompile during Play-in-Editor</summary>
	public TArray<TSoftObjectPtr<UClass>> BaseClassesToAllowRecompilingDuringPlayInEditor;
}
