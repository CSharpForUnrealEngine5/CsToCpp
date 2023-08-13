namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeFunctionCall.h")]
public partial class UNiagaraNodeFunctionCall : UNiagaraNodeWithDynamicPins {
	public static UClass StaticClass() {return default;}
	///<summary>FunctionScript</summary>
	public UNiagaraScript FunctionScript;
	///<summary>SelectedScriptVersion</summary>
	public FGuid SelectedScriptVersion;
	///<summary>A path to a script asset which can be used to assign the function script the first time that</summary>
	public string FunctionScriptAssetObjectPath;
	///<summary>Some functions can be provided a signature directly rather than a script.</summary>
	public FNiagaraFunctionSignature Signature;
	///<summary>FunctionSpecifiers</summary>
	public TMap<string,string> FunctionSpecifiers;
	///<summary>All the input values the function propagates to the next higher caller instead of forcing the user to set them directly.</summary>
	public TArray<FNiagaraPropagatedVariable> PropagatedStaticSwitchParameters;
	///<summary>Can be used by the ui after a version change to display change notes</summary>
	public FGuid PreviousScriptVersion;
	///<summary>Can be used by the ui after a version change to display change notes</summary>
	public string PythonUpgradeScriptWarnings;
	///<summary>DebugState</summary>
	public ENiagaraFunctionDebugState DebugState;
	///<summary>Controls whether the debug state of the current function gets propagated into this function call.</summary>
	public bool bInheritDebugStatus;
	///<summary>Adjusted every time that we compile this script. Lets us know that we might differ from any cached versions.</summary>
	public FGuid CachedChangeId;
	///<summary>If a script version we reference goes away we select a fallback version, but save the original version to generate warnings.</summary>
	public FGuid InvalidScriptVersionReference;
	///<summary>FunctionDisplayName</summary>
	public string FunctionDisplayName;
	///<summary>MessageKeyToMessageMap</summary>
	public TMap<FGuid,UNiagaraMessageData> MessageKeyToMessageMap;
	///<summary>StackMessages</summary>
	public TArray<FNiagaraStackMessage> StackMessages;
	///<summary>BoundPinNames</summary>
	public TMap<FGuid,string> BoundPinNames;
}
