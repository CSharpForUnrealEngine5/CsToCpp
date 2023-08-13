namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNextInterfaceGraph_EditorData.h")]
public partial class UAnimNextInterfaceGraph_EditorData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>RootGraph</summary>
	public UAnimNextInterfaceGraph_EdGraph RootGraph;
	///<summary>EntryPointGraph</summary>
	public UAnimNextInterfaceGraph_EdGraph EntryPointGraph;
	///<summary>FunctionLibraryEdGraph</summary>
	public UAnimNextInterfaceGraph_EdGraph FunctionLibraryEdGraph;
	///<summary>RigVMClient</summary>
	public FRigVMClient RigVMClient;
	///<summary>GraphFunctionStore</summary>
	public FRigVMGraphFunctionStore GraphFunctionStore;
	///<summary>RigVMGraph_DEPRECATED</summary>
	public URigVMGraph RigVMGraph_DEPRECATED;
	///<summary>RigVMFunctionLibrary_DEPRECATED</summary>
	public URigVMFunctionLibrary RigVMFunctionLibrary_DEPRECATED;
	///<summary>EntryPoint</summary>
	public URigVMLibraryNode EntryPoint;
	///<summary>Controllers</summary>
	public TMap<URigVMGraph,URigVMController> Controllers;
	///<summary>RigGraphDisplaySettings</summary>
	public FRigGraphDisplaySettings RigGraphDisplaySettings;
	///<summary>VMRuntimeSettings</summary>
	public FRigVMRuntimeSettings VMRuntimeSettings;
	///<summary>VMCompileSettings</summary>
	public FRigVMCompileSettings VMCompileSettings;
	///<summary>PythonLogSettings</summary>
	public FControlRigPythonSettings PythonLogSettings;
	///<summary>PinToOperandMap</summary>
	public TMap<string,FRigVMOperand> PinToOperandMap;
	///<summary>bVMRecompilationRequired</summary>
	public bool bVMRecompilationRequired;
	///<summary>bIsCompiling</summary>
	public bool bIsCompiling;
}
