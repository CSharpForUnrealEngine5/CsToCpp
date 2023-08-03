#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Used to store variable data and metadata per graph.</summary>
[CppInclude("NiagaraScriptVariable.h")]
public partial class UNiagaraScriptVariable : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The default mode. Can be Value, Binding or Custom.</summary>
	public ENiagaraDefaultMode DefaultMode;
	///<summary>The default binding. Only used if DefaultMode == ENiagaraDefaultMode::Binding.</summary>
	public FNiagaraScriptVariableBinding DefaultBinding;
	///<summary>Variable type, name and data. The data is not persistent, but used as a buffer when interfacing elsewhere.</summary>
	public FNiagaraVariable Variable;
	///<summary>The metadata associated with this script variable.</summary>
	public FNiagaraVariableMetaData Metadata;
	///<summary>DefaultValueVariant</summary>
	public FNiagaraVariant DefaultValueVariant;
	///<summary>StaticSwitchDefaultValue</summary>
	public int StaticSwitchDefaultValue;
	///<summary>bIsStaticSwitch</summary>
	public bool bIsStaticSwitch;
	///<summary>bSubscribedToParameterDefinitions</summary>
	public bool bSubscribedToParameterDefinitions;
	///<summary>ChangeId</summary>
	public FGuid ChangeId;
	///<summary>bOverrideParameterDefinitionsDefaultValue</summary>
	public bool bOverrideParameterDefinitionsDefaultValue;
}
