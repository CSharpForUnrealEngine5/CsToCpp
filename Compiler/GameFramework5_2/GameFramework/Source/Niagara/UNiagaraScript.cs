namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Runtime script for a Niagara system</summary>
[CppInclude("NiagaraScript.h")]
public partial class UNiagaraScript : UNiagaraScriptBase {
	public static UClass StaticClass() {return default;}
	///<summary>A set of rules to apply when this script is used in the stack. To create your own rules, write a custom class that extends UNiagaraValidationRule.</summary>
	public TArray<UNiagaraValidationRule> ValidationRules;
	///<summary>how this script is to be used. cannot be private due to use of GET_MEMBER_NAME_CHECKED</summary>
	public ENiagaraScriptUsage Usage;
	///<summary>Specifies a unique id for use when there are multiple scripts with the same usage, e.g. events.</summary>
	public FGuid UsageId;
	///<summary>The exposed version is the version that is used by default when a user adds this script somewhere. It is basically the published version and allows a script maintainer to create and test newer versions that are not used by normal users.</summary>
	public FGuid ExposedVersion;
	///<summary>If true then this script asset uses active version control to track changes.</summary>
	public bool bVersioningEnabled;
	///<summary>Contains all of the versioned script data.</summary>
	public TArray<FVersionedNiagaraScriptData> VersionData;
	///<summary>Contains all of the top-level values that are iterated on in the UI. These are usually &quot;Module&quot; variables in the graph. They don&#39;t necessarily have to be in the order that they are expected in the uniform table.</summary>
	public FNiagaraParameterStore RapidIterationParameters;
	///<summary>RapidIterationParametersCookedEditorCache</summary>
	public FNiagaraParameterStore RapidIterationParametersCookedEditorCache;
	///<summary>This is used as a transient value to open a specific version in the graph editor</summary>
	public FGuid VersionToOpenInEditor;
	///<summary>Which instance of the usage in the graph to use.  This is now deprecated and is handled by UsageId.</summary>
	public int UsageIndex_DEPRECATED;
	///<summary>Use property in struct returned from GetScriptData() instead</summary>
	public int ModuleUsageBitmask_DEPRECATED;
	///<summary>Use property in struct returned from GetScriptData() instead</summary>
	public FText Category_DEPRECATED;
	///<summary>Use property in struct returned from GetScriptData() instead</summary>
	public TArray<string> ProvidedDependencies_DEPRECATED;
	///<summary>Use property in struct returned from GetScriptData() instead</summary>
	public TArray<FNiagaraModuleDependency> RequiredDependencies_DEPRECATED;
	///<summary>Use property in struct returned from GetScriptData() instead</summary>
	public bool bDeprecated_DEPRECATED;
	///<summary>Use property in struct returned from GetScriptData() instead</summary>
	public FText DeprecationMessage_DEPRECATED;
	///<summary>Use property in struct returned from GetScriptData() instead</summary>
	public UNiagaraScript DeprecationRecommendation_DEPRECATED;
	///<summary>Use property in struct returned from GetScriptData() instead</summary>
	public UClass ConversionUtility_DEPRECATED;
	///<summary>Use property in struct returned from GetScriptData() instead</summary>
	public bool bExperimental_DEPRECATED;
	///<summary>Use property in struct returned from GetScriptData() instead</summary>
	public FText ExperimentalMessage_DEPRECATED;
	///<summary>Use property in struct returned from GetScriptData() instead</summary>
	public FText NoteMessage_DEPRECATED;
	///<summary>Deprecated, use LibraryVisibility instead.</summary>
	public bool bExposeToLibrary_DEPRECATED;
	///<summary>Use property in struct returned from GetScriptData() instead</summary>
	public ENiagaraScriptLibraryVisibility LibraryVisibility_DEPRECATED;
	///<summary>Use property in struct returned from GetScriptData() instead</summary>
	public ENiagaraNumericOutputTypeSelectionMode NumericOutputTypeSelectionMode_DEPRECATED;
	///<summary>Use property in struct returned from GetScriptData() instead</summary>
	public FText Description_DEPRECATED;
	///<summary>Use property in struct returned from GetScriptData() instead</summary>
	public FText Keywords_DEPRECATED;
	///<summary>Deprecated, use LibraryVisibility instead.</summary>
	public FText CollapsedViewFormat_DEPRECATED;
	///<summary>Deprecated, use LibraryVisibility instead.</summary>
	public TMap<string,string> ScriptMetaData_DEPRECATED;
	///<summary>&#39;Source&#39; data/graphs for this script</summary>
	public UNiagaraScriptSourceBase Source_DEPRECATED;
	///<summary>RaiseOnGPUCompilationComplete</summary>
	public void RaiseOnGPUCompilationComplete() {}
	///<summary>ScriptExecutionParamStoreCPU</summary>
	public FNiagaraScriptExecutionParameterStore ScriptExecutionParamStoreCPU;
	///<summary>ScriptExecutionParamStoreGPU</summary>
	public FNiagaraScriptExecutionParameterStore ScriptExecutionParamStoreGPU;
	///<summary>The equivalent of ScriptExecutionParamStoreCPU (or GPU) cooked for the given platform.</summary>
	public FNiagaraScriptExecutionParameterStore ScriptExecutionParamStore;
	///<summary>The cooked binding data between ScriptExecutionParamStore and RapidIterationParameters.</summary>
	public TArray<FNiagaraBoundParameter> ScriptExecutionBoundParameters;
	///<summary>Adjusted every time that we compile this script. Lets us know that we might differ from any cached versions.</summary>
	public FNiagaraVMExecutableDataId CachedScriptVMId;
	///<summary>ActiveCompileRoots</summary>
	public TArray<UObject> ActiveCompileRoots;
	///<summary>Compiled VM bytecode and data necessary to run this script.</summary>
	public FNiagaraVMExecutableData CachedScriptVM;
	///<summary>CachedParameterCollectionReferences</summary>
	public TArray<UNiagaraParameterCollection> CachedParameterCollectionReferences;
	///<summary>CachedDefaultDataInterfaces</summary>
	public TArray<FNiagaraScriptDataInterfaceInfo> CachedDefaultDataInterfaces;
}
