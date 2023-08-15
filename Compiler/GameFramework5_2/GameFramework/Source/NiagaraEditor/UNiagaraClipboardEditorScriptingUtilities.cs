namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraClipboard.h")]
public partial class UNiagaraClipboardEditorScriptingUtilities : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>TryGetInputByName</summary>
	public static void TryGetInputByName(TArray<UNiagaraClipboardFunctionInput> InInputs,FName InInputName,bool bOutSucceeded,UNiagaraClipboardFunctionInput OutInput) {}
	///<summary>TryGetLocalValueAsFloat</summary>
	public static void TryGetLocalValueAsFloat(UNiagaraClipboardFunctionInput InInput,bool bOutSucceeded,float OutValue) {}
	///<summary>TryGetLocalValueAsInt</summary>
	public static void TryGetLocalValueAsInt(UNiagaraClipboardFunctionInput InInput,bool bOutSucceeded,int OutValue) {}
	///<summary>TrySetLocalValueAsInt</summary>
	public static void TrySetLocalValueAsInt(UNiagaraClipboardFunctionInput InInput,bool bOutSucceeded,int InValue,bool bLooseTyping/*=true*/) {}
	///<summary>GetTypeName</summary>
	public static FName GetTypeName(UNiagaraClipboardFunctionInput InInput) { return default; }
	///<summary>CreateFloatLocalValueInput</summary>
	public static UNiagaraClipboardFunctionInput CreateFloatLocalValueInput(UObject InOuter,FName InInputName,bool bInHasEditCondition,bool bInEditConditionValue,float InLocalValue) { return default; }
	///<summary>CreateVec2LocalValueInput</summary>
	public static UNiagaraClipboardFunctionInput CreateVec2LocalValueInput(UObject InOuter,FName InInputName,bool bInHasEditCondition,bool bInEditConditionValue,FVector2D InVec2Value) { return default; }
	///<summary>CreateVec3LocalValueInput</summary>
	public static UNiagaraClipboardFunctionInput CreateVec3LocalValueInput(UObject InOuter,FName InInputName,bool bInHasEditCondition,bool bInEditConditionValue,FVector InVec3Value) { return default; }
	///<summary>CreateIntLocalValueInput</summary>
	public static UNiagaraClipboardFunctionInput CreateIntLocalValueInput(UObject InOuter,FName InInputName,bool bInHasEditCondition,bool bInEditConditionValue,int InLocalValue) { return default; }
	///<summary>CreateBoolLocalValueInput</summary>
	public static UNiagaraClipboardFunctionInput CreateBoolLocalValueInput(UObject InOuter,FName InInputName,bool bInHasEditCondition,bool bInEditConditionValue,bool InBoolValue) { return default; }
	///<summary>CreateStructLocalValueInput</summary>
	public static UNiagaraClipboardFunctionInput CreateStructLocalValueInput(UObject InOuter,FName InInputName,bool bInHasEditCondition,bool bInEditConditionValue,UUserDefinedStruct InStructValue) { return default; }
	///<summary>CreateEnumLocalValueInput</summary>
	public static UNiagaraClipboardFunctionInput CreateEnumLocalValueInput(UObject InOuter,FName InInputName,bool bInHasEditCondition,bool bInEditCoditionValue,UUserDefinedEnum InEnumType,int InEnumValue) { return default; }
	///<summary>CreateLinkedValueInput</summary>
	public static UNiagaraClipboardFunctionInput CreateLinkedValueInput(UObject InOuter,FName InInputName,FName InInputTypeName,bool bInHasEditCondition,bool bInEditConditionValue,FName InLinkedValue) { return default; }
	///<summary>CreateDataValueInput</summary>
	public static UNiagaraClipboardFunctionInput CreateDataValueInput(UObject InOuter,FName InInputName,bool bInHasEditCondition,bool bInEditConditionValue,UNiagaraDataInterface InDataValue) { return default; }
	///<summary>CreateExpressionValueInput</summary>
	public static UNiagaraClipboardFunctionInput CreateExpressionValueInput(UObject InOuter,FName InInputName,FName InInputTypeName,bool bInHasEditCondition,bool bInEditConditionValue,string InExpressionValue) { return default; }
	///<summary>CreateDynamicValueInput</summary>
	public static UNiagaraClipboardFunctionInput CreateDynamicValueInput(UObject InOuter,FName InInputName,FName InInputTypeName,bool bInHasEditCondition,bool bInEditConditionValue,string InDynamicValueName,UNiagaraScript InDynamicValue) { return default; }
}
