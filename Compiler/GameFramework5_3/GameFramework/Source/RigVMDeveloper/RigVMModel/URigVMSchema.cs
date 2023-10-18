namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Schema is used to determine which actions are allowed</summary>
[CppInclude("RigVMModel/RigVMSchema.h")]
public partial class URigVMSchema : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ExecuteContextStruct</summary>
	public UScriptStruct ExecuteContextStruct;
}
