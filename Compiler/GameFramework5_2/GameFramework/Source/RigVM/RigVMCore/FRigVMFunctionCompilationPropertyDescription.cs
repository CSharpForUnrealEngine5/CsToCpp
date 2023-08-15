namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMGraphFunctionDefinition.h")]
public partial struct FRigVMFunctionCompilationPropertyDescription {
	public FName Name;
	public string CPPType;
	public TSoftObjectPtr<UObject> CPPTypeObject;
	public string DefaultValue;
}
