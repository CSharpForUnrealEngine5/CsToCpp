#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNextInterfaceGraph_EditorData.h")]
public partial class UAnimNextInterfaceGraph_EditorData : UObject {
// AnimNextInterfaceGraph_EditorData
	public UAnimNextInterfaceGraph_EdGraph RootGraph;
	public UAnimNextInterfaceGraph_EdGraph EntryPointGraph;
	public UAnimNextInterfaceGraph_EdGraph FunctionLibraryEdGraph;
	public FRigVMClient RigVMClient;
	public FRigVMGraphFunctionStore GraphFunctionStore;
	public URigVMGraph RigVMGraph_DEPRECATED;
	public URigVMFunctionLibrary RigVMFunctionLibrary_DEPRECATED;
	public URigVMLibraryNode EntryPoint;
	public TMap<URigVMGraph,URigVMController> Controllers;
	public FRigGraphDisplaySettings RigGraphDisplaySettings;
	public FRigVMRuntimeSettings VMRuntimeSettings;
	public FRigVMCompileSettings VMCompileSettings;
	public FControlRigPythonSettings PythonLogSettings;
	public TMap<string,FRigVMOperand> PinToOperandMap;
	public bool bVMRecompilationRequired;
	public bool bIsCompiling;
}
