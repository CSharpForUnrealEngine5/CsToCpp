namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct containing all of the data needed to run a Niagara VM executable script.</summary>
[CppInclude("NiagaraScript.h")]
public partial struct FNiagaraVMExecutableData {
	public FNiagaraVMExecutableByteCode ByteCode;
	public FNiagaraVMExecutableByteCode OptimizedByteCode;
	public int NumTempRegisters;
	public int NumUserPtrs;
	public FNiagaraParameters Parameters;
	public FNiagaraParameters InternalParameters;
	public TArray<FNiagaraCompileDependency> ExternalDependencies;
	public TArray<FNiagaraVariable> BakedRapidIterationParameters;
	public TArray<FNiagaraCompilerTag> CompileTagsEditorOnly;
	public TArray<FNiagaraCompilerTag> CompileTags;
	public TArray<byte> ScriptLiterals;
	public TArray<FNiagaraVariableBase> Attributes;
	public FNiagaraScriptDataUsageInfo DataUsage;
	public TMap<FName,FNiagaraParameters> DataSetToParameters;
	public TArray<FNiagaraFunctionSignature> AdditionalExternalFunctions;
	public TArray<FNiagaraScriptUObjectCompileInfo> UObjectInfos;
	public TArray<FNiagaraScriptDataInterfaceCompileInfo> DataInterfaceInfo;
	public TArray<FVMExternalFunctionBindingInfo> CalledVMExternalFunctions;
	public TArray<FNiagaraDataSetID> ReadDataSets;
	public TArray<FNiagaraDataSetProperties> WriteDataSets;
	public TArray<FNiagaraStatScope> StatScopes;
	public string LastHlslTranslation;
	public string LastHlslTranslationGPU;
	public string LastAssemblyTranslation;
	public uint LastOpCount;
	public FNiagaraShaderScriptParametersMetadata ShaderScriptParametersMetadata;
	public TArray<string> ParameterCollectionPaths;
	public ENiagaraScriptCompileStatus LastCompileStatus;
	public TArray<FSimulationStageMetaData> SimulationStageMetaData;
	public bool bReadsAttributeData;
	public TArray<FNiagaraVariableBase> AttributesWritten;
	public TArray<FNiagaraVariable> StaticVariablesWritten;
	public string ErrorMsg;
	public TArray<FNiagaraCompileEvent> LastCompileEvents;
	public TArray<byte> ExperimentalContextData;
	public bool bReadsSignificanceIndex;
	public bool bNeedsGPUContextInit;
}
