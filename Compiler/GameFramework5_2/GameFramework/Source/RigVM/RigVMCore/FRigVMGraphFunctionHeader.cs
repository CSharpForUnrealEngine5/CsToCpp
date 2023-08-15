namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMGraphFunctionDefinition.h")]
public partial struct FRigVMGraphFunctionHeader {
	public FRigVMGraphFunctionIdentifier LibraryPointer;
	public FName Name;
	public string NodeTitle;
	public FLinearColor NodeColor;
	public FText Tooltip;
	public string Category;
	public string Keywords;
	public TArray<FRigVMGraphFunctionArgument> Arguments;
	public TMap<FRigVMGraphFunctionIdentifier,uint> Dependencies;
	public TArray<FRigVMExternalVariable> ExternalVariables;
}
