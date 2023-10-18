namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Animation node that allows animation ControlRig output to be used in an animation graph</summary>
[CppInclude("AnimNode_ControlRig_ExternalSource.h")]
public partial struct FAnimNode_ControlRig_ExternalSource {
	public TWeakObjectPtr<UControlRig> ControlRig;
}
