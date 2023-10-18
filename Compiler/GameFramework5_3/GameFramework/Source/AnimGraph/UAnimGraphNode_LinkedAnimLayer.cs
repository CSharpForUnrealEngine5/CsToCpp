namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_LinkedAnimLayer.h")]
public partial class UAnimGraphNode_LinkedAnimLayer : UAnimGraphNode_LinkedAnimGraphBase {
	public static UClass StaticClass() {return default;}
	///<summary>Node</summary>
	public FAnimNode_LinkedAnimLayer Node;
	///<summary>Guid of the named layer graph we refer to</summary>
	public FGuid InterfaceGuid;
}
