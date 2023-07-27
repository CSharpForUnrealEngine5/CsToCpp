#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraClipboard.h")]
public partial class UNiagaraClipboardEditorScriptingUtilities : UObject {
// NiagaraClipboardEditorScriptingUtilities
	public static void TryGetInputByName(TArray<UNiagaraClipboardFunctionInput> InInputs,string InInputName,bool bOutSucceeded,UNiagaraClipboardFunctionInput OutInput) {}
	public static void TryGetLocalValueAsFloat(UNiagaraClipboardFunctionInput InInput,bool bOutSucceeded,float OutValue) {}
	public static void TryGetLocalValueAsInt(UNiagaraClipboardFunctionInput InInput,bool bOutSucceeded,int OutValue) {}
	public static void TrySetLocalValueAsInt(UNiagaraClipboardFunctionInput InInput,bool bOutSucceeded,int InValue,bool bLooseTyping/*=true*/) {}
	public static string GetTypeName(UNiagaraClipboardFunctionInput InInput) { return default; }
	public static UNiagaraClipboardFunctionInput CreateFloatLocalValueInput(UObject InOuter,string InInputName,bool bInHasEditCondition,bool bInEditConditionValue,float InLocalValue) { return default; }
	public static UNiagaraClipboardFunctionInput CreateVec2LocalValueInput(UObject InOuter,string InInputName,bool bInHasEditCondition,bool bInEditConditionValue,FVector2D InVec2Value) { return default; }
	public static UNiagaraClipboardFunctionInput CreateVec3LocalValueInput(UObject InOuter,string InInputName,bool bInHasEditCondition,bool bInEditConditionValue,FVector InVec3Value) { return default; }
	public static UNiagaraClipboardFunctionInput CreateIntLocalValueInput(UObject InOuter,string InInputName,bool bInHasEditCondition,bool bInEditConditionValue,int InLocalValue) { return default; }
	public static UNiagaraClipboardFunctionInput CreateBoolLocalValueInput(UObject InOuter,string InInputName,bool bInHasEditCondition,bool bInEditConditionValue,bool InBoolValue) { return default; }
	public static UNiagaraClipboardFunctionInput CreateStructLocalValueInput(UObject InOuter,string InInputName,bool bInHasEditCondition,bool bInEditConditionValue,UUserDefinedStruct InStructValue) { return default; }
	public static UNiagaraClipboardFunctionInput CreateEnumLocalValueInput(UObject InOuter,string InInputName,bool bInHasEditCondition,bool bInEditCoditionValue,UUserDefinedEnum InEnumType,int InEnumValue) { return default; }
	public static UNiagaraClipboardFunctionInput CreateLinkedValueInput(UObject InOuter,string InInputName,string InInputTypeName,bool bInHasEditCondition,bool bInEditConditionValue,string InLinkedValue) { return default; }
	public static UNiagaraClipboardFunctionInput CreateDataValueInput(UObject InOuter,string InInputName,bool bInHasEditCondition,bool bInEditConditionValue,UNiagaraDataInterface InDataValue) { return default; }
	public static UNiagaraClipboardFunctionInput CreateExpressionValueInput(UObject InOuter,string InInputName,string InInputTypeName,bool bInHasEditCondition,bool bInEditConditionValue,string InExpressionValue) { return default; }
	public static UNiagaraClipboardFunctionInput CreateDynamicValueInput(UObject InOuter,string InInputName,string InInputTypeName,bool bInHasEditCondition,bool bInEditConditionValue,string InDynamicValueName,UNiagaraScript InDynamicValue) { return default; }
}
