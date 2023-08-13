namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A node which allows the user to build a set of arbitrary output types from an arbitrary set of input types by connecting their inner components.</summary>
[CppInclude("NiagaraNodeConvert.h")]
public partial class UNiagaraNodeConvert : UNiagaraNodeWithDynamicPins {
	public static UClass StaticClass() {return default;}
	///<summary>A swizzle string set externally to instruct the autowiring code.</summary>
	public string AutowireSwizzle;
	///<summary>A type def used when auto wiring up the convert node.</summary>
	public FNiagaraTypeDefinition AutowireMakeType;
	///<summary>AutowireBreakType</summary>
	public FNiagaraTypeDefinition AutowireBreakType;
	///<summary>The internal connections for this node.</summary>
	public TArray<FNiagaraConvertConnection> Connections;
	///<summary>Is the switcboard UI shown?</summary>
	public bool bIsWiringShown;
	///<summary>Store of all sockets that are expanded.</summary>
	public TArray<FNiagaraConvertPinRecord> ExpandedItems;
}
