#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCompiler/RigVMCompiler.h")]
public partial class URigVMCompiler : UObject {
	///<summary>Settings</summary>
	public FRigVMCompileSettings Settings;
	///<summary>Compile</summary>
	public  bool Compile(TArray<URigVMGraph> InGraphs,URigVMController InController,URigVM OutVM) { return default; }
}
