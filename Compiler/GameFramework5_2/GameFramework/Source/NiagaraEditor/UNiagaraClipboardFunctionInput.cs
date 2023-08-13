namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraClipboard.h")]
public partial class UNiagaraClipboardFunctionInput : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>InputName</summary>
	public string InputName;
	///<summary>InputType</summary>
	public FNiagaraTypeDefinition InputType;
	///<summary>bHasEditCondition</summary>
	public bool bHasEditCondition;
	///<summary>bEditConditionValue</summary>
	public bool bEditConditionValue;
	///<summary>ValueMode</summary>
	public ENiagaraClipboardFunctionInputValueMode ValueMode;
	///<summary>Local</summary>
	public TArray<byte> Local;
	///<summary>Linked</summary>
	public string Linked;
	///<summary>Data</summary>
	public UNiagaraDataInterface Data;
	///<summary>Expression</summary>
	public string Expression;
	///<summary>Dynamic</summary>
	public UNiagaraClipboardFunction Dynamic;
}
