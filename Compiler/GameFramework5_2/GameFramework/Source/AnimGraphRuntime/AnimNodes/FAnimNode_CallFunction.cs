#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_CallFunction.h")]
///<summary>Calls specified user-defined events/functions during anim graph execution</summary>
public partial struct FAnimNode_CallFunction {
// AnimNode_CallFunction
	public FPoseLink Source;
	public FAnimNodeFunctionRef Function;
	public EAnimFunctionCallSite CallSite;
}
