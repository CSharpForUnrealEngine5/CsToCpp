namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to perform validation on a debugged Control Rig</summary>
[CppInclude("ControlRigValidationPass.h")]
public partial class UControlRigValidator : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Passes</summary>
	public TArray<UControlRigValidationPass> Passes;
}
