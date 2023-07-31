#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to perform validation on a debugged Control Rig</summary>
[CppInclude("ControlRigValidationPass.h")]
public partial class UControlRigValidator : UObject {
	///<summary>Passes</summary>
	public TArray<UControlRigValidationPass> Passes;
}
