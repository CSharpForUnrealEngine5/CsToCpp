#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCompiler/RigVMCompiler.h")]
public partial class URigVMCompiler : UObject {
// RigVMCompiler
	public FRigVMCompileSettings Settings;
	public  bool Compile(TArray<URigVMGraph> InGraphs,URigVMController InController,URigVM OutVM) { return default; }
}
