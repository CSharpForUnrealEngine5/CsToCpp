namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNode.h")]
public partial class UNiagaraNode : UEdGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>The current change identifier for this node. Used to sync status with UNiagaraScripts.</summary>
	public FGuid ChangeId;
}
