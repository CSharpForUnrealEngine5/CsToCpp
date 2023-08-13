namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/OptimusNode_ResourceAccessorBase.h")]
public partial class UOptimusNode_ResourceAccessorBase : UOptimusNode {
	public static UClass StaticClass() {return default;}
	///<summary>ResourceDesc</summary>
	public TWeakObjectPtr<UOptimusResourceDescription> ResourceDesc;
	///<summary>Logical operation when writing to the resource.</summary>
	public EOptimusBufferWriteType WriteType;
	///<summary>DuplicationInfo</summary>
	public FOptimusNode_ResourceAccessorBase_DuplicationInfo DuplicationInfo;
}
