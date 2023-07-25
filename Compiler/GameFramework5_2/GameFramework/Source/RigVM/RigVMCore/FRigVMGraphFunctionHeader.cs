#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMGraphFunctionDefinition.h")]
public partial struct FRigVMGraphFunctionHeader {
// RigVMGraphFunctionHeader
	public FRigVMGraphFunctionIdentifier LibraryPointer;
	public string Name;
	public string NodeTitle;
	public FLinearColor NodeColor;
	public string Tooltip;
	public string Category;
	public string Keywords;
	public TArray<FRigVMGraphFunctionArgument> Arguments;
	public TMap<FRigVMGraphFunctionIdentifier,uint> Dependencies;
	public TArray<FRigVMExternalVariable> ExternalVariables;
}
