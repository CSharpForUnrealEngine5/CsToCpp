namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMGraphFunctionDefinition.h")]
public partial struct FRigVMGraphFunctionArgument {
	public string Name;
	public string DisplayName;
	public string CPPType;
	public TSoftObjectPtr<UObject> CPPTypeObject;
	public bool bIsArray;
	public ERigVMPinDirection Direction;
	public string DefaultValue;
	public bool bIsConst;
	public TMap<string,FText> PathToTooltip;
}
