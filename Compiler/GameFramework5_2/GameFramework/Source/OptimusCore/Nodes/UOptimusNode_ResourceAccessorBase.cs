#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/OptimusNode_ResourceAccessorBase.h")]
public partial class UOptimusNode_ResourceAccessorBase : UOptimusNode {
// OptimusNode_ResourceAccessorBase
	public TWeakObjectPtr<UOptimusResourceDescription> ResourceDesc;
	public EOptimusBufferWriteType WriteType;
	public FOptimusNode_ResourceAccessorBase_DuplicationInfo DuplicationInfo;
}
