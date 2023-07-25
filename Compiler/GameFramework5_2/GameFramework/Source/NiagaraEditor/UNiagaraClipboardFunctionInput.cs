#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraClipboard.h")]
public partial class UNiagaraClipboardFunctionInput : UObject {
// NiagaraClipboardFunctionInput
	public string InputName;
	public FNiagaraTypeDefinition InputType;
	public bool bHasEditCondition;
	public bool bEditConditionValue;
	public ENiagaraClipboardFunctionInputValueMode ValueMode;
	public TArray<byte> Local;
	public string Linked;
	public UNiagaraDataInterface Data;
	public string Expression;
	public UNiagaraClipboardFunction Dynamic;
}
