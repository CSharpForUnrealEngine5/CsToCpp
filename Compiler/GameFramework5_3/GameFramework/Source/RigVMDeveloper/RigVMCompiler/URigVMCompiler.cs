namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCompiler/RigVMCompiler.h")]
public partial class URigVMCompiler : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public FRigVMCompileSettings Settings;
	///<summary>Compile</summary>
	public bool Compile(TArray<URigVMGraph> InGraphs,URigVMController InController,URigVM OutVM) { return default; }
	///<summary>CompileVM</summary>
	public bool CompileVM(TArray<URigVMGraph> InGraphs,URigVMController InController,URigVM OutVM,FRigVMExtendedExecuteContext Context) { return default; }
}
