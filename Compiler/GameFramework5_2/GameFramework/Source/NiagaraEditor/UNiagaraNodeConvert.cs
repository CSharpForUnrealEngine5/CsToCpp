#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeConvert.h")]
///<summary>A node which allows the user to build a set of arbitrary output types from an arbitrary set of input types by connecting their inner components.</summary>
public partial class UNiagaraNodeConvert : UNiagaraNodeWithDynamicPins {
// NiagaraNodeConvert
	public string AutowireSwizzle;
	public FNiagaraTypeDefinition AutowireMakeType;
	public FNiagaraTypeDefinition AutowireBreakType;
	public TArray<FNiagaraConvertConnection> Connections;
	public bool bIsWiringShown;
	public TArray<FNiagaraConvertPinRecord> ExpandedItems;
}
