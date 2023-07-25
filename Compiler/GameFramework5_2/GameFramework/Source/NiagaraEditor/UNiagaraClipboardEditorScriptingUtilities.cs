#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraClipboard.h")]
public partial class UNiagaraClipboardEditorScriptingUtilities : UObject {
// NiagaraClipboardEditorScriptingUtilities
	public void TryGetInputByName(TArray<UObject> InInputs,string InInputName,bool bOutSucceeded,UObject OutInput) {}
	public void TryGetLocalValueAsFloat(UObject InInput,bool bOutSucceeded,float OutValue) {}
	public void TryGetLocalValueAsInt(UObject InInput,bool bOutSucceeded,int OutValue) {}
	public void TrySetLocalValueAsInt(UObject InInput,bool bOutSucceeded,int InValue,bool bLooseTyping/*=true*/) {}
	public string GetTypeName(UObject InInput) { return default; }
	public UObject CreateFloatLocalValueInput(UObject InOuter,string InInputName,bool bInHasEditCondition,bool bInEditConditionValue,float InLocalValue) { return default; }
	public UObject CreateVec2LocalValueInput(UObject InOuter,string InInputName,bool bInHasEditCondition,bool bInEditConditionValue,FVector2D InVec2Value) { return default; }
	public UObject CreateVec3LocalValueInput(UObject InOuter,string InInputName,bool bInHasEditCondition,bool bInEditConditionValue,FVector InVec3Value) { return default; }
	public UObject CreateIntLocalValueInput(UObject InOuter,string InInputName,bool bInHasEditCondition,bool bInEditConditionValue,int InLocalValue) { return default; }
	public UObject CreateBoolLocalValueInput(UObject InOuter,string InInputName,bool bInHasEditCondition,bool bInEditConditionValue,bool InBoolValue) { return default; }
	public UObject CreateStructLocalValueInput(UObject InOuter,string InInputName,bool bInHasEditCondition,bool bInEditConditionValue,UObject InStructValue) { return default; }
	public UObject CreateEnumLocalValueInput(UObject InOuter,string InInputName,bool bInHasEditCondition,bool bInEditCoditionValue,UObject InEnumType,int InEnumValue) { return default; }
	public UObject CreateLinkedValueInput(UObject InOuter,string InInputName,string InInputTypeName,bool bInHasEditCondition,bool bInEditConditionValue,string InLinkedValue) { return default; }
	public UObject CreateDataValueInput(UObject InOuter,string InInputName,bool bInHasEditCondition,bool bInEditConditionValue,UObject InDataValue) { return default; }
	public UObject CreateExpressionValueInput(UObject InOuter,string InInputName,string InInputTypeName,bool bInHasEditCondition,bool bInEditConditionValue,string InExpressionValue) { return default; }
	public UObject CreateDynamicValueInput(UObject InOuter,string InInputName,string InInputTypeName,bool bInHasEditCondition,bool bInEditConditionValue,string InDynamicValueName,UObject InDynamicValue) { return default; }
}
