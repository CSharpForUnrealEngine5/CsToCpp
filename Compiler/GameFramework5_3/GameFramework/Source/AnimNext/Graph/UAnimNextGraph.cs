namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A user-created graph of logic used to supply data</summary>
[CppInclude("Graph/AnimNextGraph.h")]
public partial class UAnimNextGraph : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>RigVM</summary>
	public URigVM RigVM;
	///<summary>ExtendedExecuteContext</summary>
	public FRigVMExtendedExecuteContext ExtendedExecuteContext;
	///<summary>VMRuntimeSettings</summary>
	public FRigVMRuntimeSettings VMRuntimeSettings;
	///<summary>EditorData</summary>
	public UObject EditorData;
}
