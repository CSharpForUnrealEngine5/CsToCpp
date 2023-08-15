namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A user-created graph of logic used to supply data</summary>
[CppInclude("AnimNextInterfaceGraph.h")]
public partial class UAnimNextInterfaceGraph : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>RigVM</summary>
	public URigVM RigVM;
	///<summary>VMRuntimeSettings</summary>
	public FRigVMRuntimeSettings VMRuntimeSettings;
	///<summary>ReturnTypeName</summary>
	public FName ReturnTypeName;
	///<summary>ReturnTypeStruct</summary>
	public UScriptStruct ReturnTypeStruct;
	///<summary>EditorData</summary>
	public UObject EditorData;
}
