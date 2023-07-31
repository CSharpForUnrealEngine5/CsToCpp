#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UTransformableControlHandle</summary>
[CppInclude("Constraints/ControlRigTransformableHandle.h")]
public partial class UTransformableControlHandle : UTransformableHandle {
	///<summary>The ControlRig that this handle is pointing at.</summary>
	public TSoftObjectPtr<UControlRig> ControlRig;
	///<summary>The ControlName of the control that this handle is pointing at.</summary>
	public string ControlName;
}
