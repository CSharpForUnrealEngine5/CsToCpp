namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct containing all of the data that can be different between different script versions.</summary>
[CppInclude("NiagaraScript.h")]
public partial struct FVersionedNiagaraScriptData {
	public FNiagaraAssetVersion Version;
	public FText VersionChangeDescription;
	public int ModuleUsageBitmask;
	public FText Category;
	public bool bSuggested;
	public TArray<string> ProvidedDependencies;
	public TArray<FNiagaraModuleDependency> RequiredDependencies;
	public bool bDeprecated;
	public FText DeprecationMessage;
	public UNiagaraScript DeprecationRecommendation;
	public UClass ConversionUtility;
	public bool bExperimental;
	public FText ExperimentalMessage;
	public FText NoteMessage;
	public ENiagaraScriptLibraryVisibility LibraryVisibility;
	public ENiagaraNumericOutputTypeSelectionMode NumericOutputTypeSelectionMode;
	public FText Description;
	public FText Keywords;
	public FText CollapsedViewFormat;
	public bool bCanBeUsedForTypeConversions;
	public TMap<string,string> ScriptMetaData;
	public TArray<FNiagaraStackSection> InputSections;
	public FNiagaraVMExecutableDataId LastGeneratedVMId;
	public ENiagaraPythonUpdateScriptReference UpdateScriptExecution;
	public string PythonUpdateScript;
	public FFilePath ScriptAsset;
	public TArray<FParameterDefinitionsSubscription> ParameterDefinitionsSubscriptions;
	public UNiagaraScriptSourceBase Source;
}
