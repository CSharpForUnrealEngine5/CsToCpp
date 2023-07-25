#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
///<summary>Wrapper for modifying a UNiagaraEmitter by adding Scripts and Renderers through UNiagaraScriptConversionContexts and</summary>
public partial class UNiagaraEmitterConversionContext : UObject {
// NiagaraEmitterConversionContext
	public void FOnPasteScript(int ScriptIdx) {}
	public void Cleanup() {}
	public UObject FindOrAddModuleScript(string ScriptNameString,FCreateScriptContextArgs CreateScriptContextArgs,EScriptExecutionCategory ModuleScriptExecutionCategory) { return default; }
	public UObject FindOrAddModuleEventScript(string ScriptNameString,FCreateScriptContextArgs CreateScriptContextArgs,FNiagaraEventHandlerAddAction EventScriptProps) { return default; }
	public UObject FindModuleScript(string ScriptNameString) { return default; }
	public void AddModuleScript(string ScriptNameString,UObject ScriptConversionContext,EScriptExecutionCategory ModuleScriptExecutionCategory) {}
	public void AddModuleEventScript(string ScriptNameString,UObject ScriptConversionContext,FNiagaraEventHandlerAddAction EventScriptProps) {}
	public void SetParameterDirectly(string ParameterNameString,UObject ParameterInput,EScriptExecutionCategory SetParameterExecutionCategory) {}
	public void AddRenderer(string RendererNameString,UObject NewRendererProperties) {}
	public UObject FindRenderer(string RendererNameString) { return default; }
	public TArray<UObject> GetAllRenderers() { return default; }
	public void Log(string Message,ENiagaraMessageSeverity Severity,bool bIsVerbose/*=false*/) {}
	public void Finalize() {}
	public UObject GetEmitter() { return default; }
	public void SetSimTarget(ENiagaraSimTarget InTarget) {}
	public void SetLocalSpace(bool bLocalSpace) {}
	public void SetEnabled(bool bInEnabled) {}
	public bool GetEnabled() { return default; }
	public void AddEventHandler(FNiagaraEventHandlerAddAction EventScriptPropertiesBP) {}
	public void SetRendererBinding(UObject InRendererProperties,string BindingName,string VariableToBindName,ENiagaraRendererSourceDataMode SourceDataMode) {}
	public void RemoveModuleScriptsForAssets(TArray<FAssetData> ScriptsToRemove) {}
	public void SetPastedFunctionCallNode(UObject InFunctionCallNode) {}
}
