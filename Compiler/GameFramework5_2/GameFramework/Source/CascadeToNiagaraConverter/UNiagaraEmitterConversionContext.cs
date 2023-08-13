namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper for modifying a UNiagaraEmitter by adding Scripts and Renderers through UNiagaraScriptConversionContexts and</summary>
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
public partial class UNiagaraEmitterConversionContext : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>FOnPasteScript</summary>
	public void FOnPasteScript(int ScriptIdx) {}
	///<summary>Cleanup</summary>
	public void Cleanup() {}
	///<summary>Find or add a script conversion context to this emitter conversion context. If a script conversion context</summary>
	public UNiagaraScriptConversionContext FindOrAddModuleScript(string ScriptNameString,FCreateScriptContextArgs CreateScriptContextArgs,EScriptExecutionCategory ModuleScriptExecutionCategory) { return default; }
	///<summary>Find a module script conversion context or add a module script conversion context  to this emitter conversion context for an event category. If a script conversion context</summary>
	public UNiagaraScriptConversionContext FindOrAddModuleEventScript(string ScriptNameString,FCreateScriptContextArgs CreateScriptContextArgs,FNiagaraEventHandlerAddAction EventScriptProps) { return default; }
	///<summary>FindModuleScript</summary>
	public UNiagaraScriptConversionContext FindModuleScript(string ScriptNameString) { return default; }
	///<summary>AddModuleScript</summary>
	public void AddModuleScript(string ScriptNameString,UNiagaraScriptConversionContext ScriptConversionContext,EScriptExecutionCategory ModuleScriptExecutionCategory) {}
	///<summary>AddModuleEventScript</summary>
	public void AddModuleEventScript(string ScriptNameString,UNiagaraScriptConversionContext ScriptConversionContext,FNiagaraEventHandlerAddAction EventScriptProps) {}
	///<summary>Add a set parameter module to the emitter handled by this emitter conversion context.</summary>
	public void SetParameterDirectly(string ParameterNameString,UNiagaraScriptConversionContextInput ParameterInput,EScriptExecutionCategory SetParameterExecutionCategory) {}
	///<summary>Add a renderer to this emitter conversion context through renderer properties.</summary>
	public void AddRenderer(string RendererNameString,UNiagaraRendererProperties NewRendererProperties) {}
	///<summary>Find an added renderer properties by name string.</summary>
	public UNiagaraRendererProperties FindRenderer(string RendererNameString) { return default; }
	///<summary>GetAllRenderers</summary>
	public TArray<UNiagaraRendererProperties> GetAllRenderers() { return default; }
	///<summary>Log a message to the niagara message log for the emitter.</summary>
	public void Log(string Message,ENiagaraMessageSeverity Severity,bool bIsVerbose/*=false*/) {}
	///<summary>Apply all pending UNiagaraScriptConversionContexts and UNiagaraRendererProperties to this</summary>
	public void Finalize() {}
	///<summary>GetEmitter</summary>
	public UNiagaraEmitter GetEmitter() { return default; }
	///<summary>SetSimTarget</summary>
	public void SetSimTarget(ENiagaraSimTarget InTarget) {}
	///<summary>SetLocalSpace</summary>
	public void SetLocalSpace(bool bLocalSpace) {}
	///<summary>SetEnabled</summary>
	public void SetEnabled(bool bInEnabled) {}
	///<summary>GetEnabled</summary>
	public bool GetEnabled() { return default; }
	///<summary>AddEventHandler</summary>
	public void AddEventHandler(FNiagaraEventHandlerAddAction EventScriptPropertiesBP) {}
	///<summary>SetRendererBinding</summary>
	public void SetRendererBinding(UNiagaraRendererProperties InRendererProperties,string BindingName,string VariableToBindName,ENiagaraRendererSourceDataMode SourceDataMode) {}
	///<summary>RemoveModuleScriptsForAssets</summary>
	public void RemoveModuleScriptsForAssets(TArray<FAssetData> ScriptsToRemove) {}
	///<summary>SetPastedFunctionCallNode</summary>
	public void SetPastedFunctionCallNode(UNiagaraNodeFunctionCall InFunctionCallNode) {}
}
