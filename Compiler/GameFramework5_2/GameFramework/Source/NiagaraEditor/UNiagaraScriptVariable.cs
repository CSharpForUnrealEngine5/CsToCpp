#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraScriptVariable.h")]
///<summary>* Used to store variable data and metadata per graph.</summary>
public partial class UNiagaraScriptVariable : UObject {
// NiagaraScriptVariable
	public ENiagaraDefaultMode DefaultMode;
	public FNiagaraScriptVariableBinding DefaultBinding;
	public FNiagaraVariable Variable;
	public FNiagaraVariableMetaData Metadata;
	public FNiagaraVariant DefaultValueVariant;
	public int StaticSwitchDefaultValue;
	public bool bIsStaticSwitch;
	public bool bSubscribedToParameterDefinitions;
	public FGuid ChangeId;
	public bool bOverrideParameterDefinitionsDefaultValue;
}
