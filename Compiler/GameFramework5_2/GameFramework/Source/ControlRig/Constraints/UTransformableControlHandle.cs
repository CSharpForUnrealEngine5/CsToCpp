namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UTransformableControlHandle</summary>
[CppInclude("Constraints/ControlRigTransformableHandle.h")]
public partial class UTransformableControlHandle : UTransformableHandle {
	public static UClass StaticClass() {return default;}
	///<summary>The ControlRig that this handle is pointing at.</summary>
	public TSoftObjectPtr<UControlRig> ControlRig;
	///<summary>The ControlName of the control that this handle is pointing at.</summary>
	public FName ControlName;
}
