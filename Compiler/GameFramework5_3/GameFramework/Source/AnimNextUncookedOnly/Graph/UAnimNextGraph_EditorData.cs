namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/AnimNextGraph_EditorData.h")]
public partial class UAnimNextGraph_EditorData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>RootGraph</summary>
	public UAnimNextGraph_EdGraph RootGraph;
	///<summary>EntryPointGraph</summary>
	public UAnimNextGraph_EdGraph EntryPointGraph;
	///<summary>FunctionLibraryEdGraph</summary>
	public UAnimNextGraph_EdGraph FunctionLibraryEdGraph;
	///<summary>RigVMClient</summary>
	public FRigVMClient RigVMClient;
	///<summary>GraphFunctionStore</summary>
	public FRigVMGraphFunctionStore GraphFunctionStore;
	///<summary>EntryPoint</summary>
	public URigVMLibraryNode EntryPoint;
	///<summary>Controllers</summary>
	public TMap<URigVMGraph,URigVMController> Controllers;
	///<summary>RigGraphDisplaySettings</summary>
	public FRigVMEdGraphDisplaySettings RigGraphDisplaySettings;
	///<summary>VMRuntimeSettings</summary>
	public FRigVMRuntimeSettings VMRuntimeSettings;
	///<summary>VMCompileSettings</summary>
	public FRigVMCompileSettings VMCompileSettings;
	///<summary>PinToOperandMap</summary>
	public TMap<string,FRigVMOperand> PinToOperandMap;
	///<summary>bVMRecompilationRequired</summary>
	public bool bVMRecompilationRequired;
	///<summary>bIsCompiling</summary>
	public bool bIsCompiling;
}
