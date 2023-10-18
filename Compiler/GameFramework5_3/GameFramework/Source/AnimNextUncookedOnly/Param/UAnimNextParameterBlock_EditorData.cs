namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Param/AnimNextParameterBlock_EditorData.h")]
public partial class UAnimNextParameterBlock_EditorData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Graphs</summary>
	public TArray<UAnimNextParameterBlock_EdGraph> Graphs;
	///<summary>RigVMClient</summary>
	public FRigVMClient RigVMClient;
	///<summary>GraphFunctionStore</summary>
	public FRigVMGraphFunctionStore GraphFunctionStore;
	///<summary>RigGraphDisplaySettings</summary>
	public FRigVMEdGraphDisplaySettings RigGraphDisplaySettings;
	///<summary>VMRuntimeSettings</summary>
	public FRigVMRuntimeSettings VMRuntimeSettings;
	///<summary>VMCompileSettings</summary>
	public FRigVMCompileSettings VMCompileSettings;
	///<summary>PinToOperandMap</summary>
	public TMap<string,FRigVMOperand> PinToOperandMap;
	///<summary>All entries in this parameter block - not saved, either serialized or discovered at load time</summary>
	public TArray<UAnimNextParameterBlockEntry> Entries;
	///<summary>LastEditedDocuments</summary>
	public TArray<FEditedDocumentInfo> LastEditedDocuments;
	///<summary>VMRecompilationBracket</summary>
	public int VMRecompilationBracket;
	///<summary>bVMRecompilationRequired</summary>
	public bool bVMRecompilationRequired;
	///<summary>bStructRecompilationRequired</summary>
	public bool bStructRecompilationRequired;
	///<summary>bIsCompiling</summary>
	public bool bIsCompiling;
}
