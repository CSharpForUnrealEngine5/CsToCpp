#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper for programmatically adding scripts to a UNiagaraEmitter through a UNiagaraEmitterConversionContext.</summary>
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
public partial class UNiagaraScriptConversionContext : UObject {
	///<summary>Set a parameter on the Script this Script Conversion Context holds.</summary>
	public  bool SetParameter(string ParameterName,UNiagaraScriptConversionContextInput ParameterInput,bool bInHasEditCondition/*=false*/,bool bInEditConditionValue/*=false*/) { return default; }
	///<summary>Log a message to the stack and the niagara message log for the module associated with this script.</summary>
	public  void Log(string Message,ENiagaraMessageSeverity Severity,bool bIsVerbose/*=false*/) {}
	///<summary>SetModuleEnabled</summary>
	public  void SetModuleEnabled(bool bInModuleEnabled) {}
	///<summary>GetModuleEnabled</summary>
	public  bool GetModuleEnabled() { return default; }
}
