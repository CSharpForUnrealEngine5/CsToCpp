namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The RigVMParameter define an input or output of the RigVM.</summary>
[CppInclude("RigVMCore/RigVM.h")]
public partial struct FRigVMParameter {
	public ERigVMParameterType Type;
	public string Name;
	public int RegisterIndex;
	public string CPPType;
	public UScriptStruct ScriptStruct;
	public string ScriptStructPath;
}
