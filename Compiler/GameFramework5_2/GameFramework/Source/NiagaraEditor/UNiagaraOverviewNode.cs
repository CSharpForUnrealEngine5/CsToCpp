namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraOverviewNode.h")]
public partial class UNiagaraOverviewNode : UEdGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>OwningSystem</summary>
	public UNiagaraSystem OwningSystem;
	///<summary>EmitterHandleGuid</summary>
	public FGuid EmitterHandleGuid;
}
