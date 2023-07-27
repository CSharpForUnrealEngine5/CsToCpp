#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
///<summary>Wrapper for modifying a UNiagaraEmitter by adding Scripts and Renderers through UNiagaraScriptConversionContexts and</summary>
public partial class UNiagaraEmitterConversionContext : UObject {
// NiagaraEmitterConversionContext
	public  void FOnPasteScript(int ScriptIdx) {}
	public  void Cleanup() {}
	public  UNiagaraScriptConversionContext FindOrAddModuleScript(string ScriptNameString,FCreateScriptContextArgs CreateScriptContextArgs,EScriptExecutionCategory ModuleScriptExecutionCategory) { return default; }
	public  UNiagaraScriptConversionContext FindOrAddModuleEventScript(string ScriptNameString,FCreateScriptContextArgs CreateScriptContextArgs,FNiagaraEventHandlerAddAction EventScriptProps) { return default; }
	public  UNiagaraScriptConversionContext FindModuleScript(string ScriptNameString) { return default; }
	public  void AddModuleScript(string ScriptNameString,UNiagaraScriptConversionContext ScriptConversionContext,EScriptExecutionCategory ModuleScriptExecutionCategory) {}
	public  void AddModuleEventScript(string ScriptNameString,UNiagaraScriptConversionContext ScriptConversionContext,FNiagaraEventHandlerAddAction EventScriptProps) {}
	public  void SetParameterDirectly(string ParameterNameString,UNiagaraScriptConversionContextInput ParameterInput,EScriptExecutionCategory SetParameterExecutionCategory) {}
	public  void AddRenderer(string RendererNameString,UNiagaraRendererProperties NewRendererProperties) {}
	public  UNiagaraRendererProperties FindRenderer(string RendererNameString) { return default; }
	public  TArray<UNiagaraRendererProperties> GetAllRenderers() { return default; }
	public  void Log(string Message,ENiagaraMessageSeverity Severity,bool bIsVerbose/*=false*/) {}
	public  void Finalize() {}
	public  UNiagaraEmitter GetEmitter() { return default; }
	public  void SetSimTarget(ENiagaraSimTarget InTarget) {}
	public  void SetLocalSpace(bool bLocalSpace) {}
	public  void SetEnabled(bool bInEnabled) {}
	public  bool GetEnabled() { return default; }
	public  void AddEventHandler(FNiagaraEventHandlerAddAction EventScriptPropertiesBP) {}
	public  void SetRendererBinding(UNiagaraRendererProperties InRendererProperties,string BindingName,string VariableToBindName,ENiagaraRendererSourceDataMode SourceDataMode) {}
	public  void RemoveModuleScriptsForAssets(TArray<FAssetData> ScriptsToRemove) {}
	public  void SetPastedFunctionCallNode(UNiagaraNodeFunctionCall InFunctionCallNode) {}
}
