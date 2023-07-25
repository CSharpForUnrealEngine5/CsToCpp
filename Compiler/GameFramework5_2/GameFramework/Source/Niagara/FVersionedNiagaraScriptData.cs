#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraScript.h")]
///<summary>Struct containing all of the data that can be different between different script versions.</summary>
public partial struct FVersionedNiagaraScriptData {
// VersionedNiagaraScriptData
	public FNiagaraAssetVersion Version;
	public string VersionChangeDescription;
	public int ModuleUsageBitmask;
	public string Category;
	public bool bSuggested;
	public TArray<string> ProvidedDependencies;
	public TArray<FNiagaraModuleDependency> RequiredDependencies;
	public bool bDeprecated;
	public string DeprecationMessage;
	public UNiagaraScript DeprecationRecommendation;
	public UClass ConversionUtility;
	public bool bExperimental;
	public string ExperimentalMessage;
	public string NoteMessage;
	public ENiagaraScriptLibraryVisibility LibraryVisibility;
	public ENiagaraNumericOutputTypeSelectionMode NumericOutputTypeSelectionMode;
	public string Description;
	public string Keywords;
	public string CollapsedViewFormat;
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
