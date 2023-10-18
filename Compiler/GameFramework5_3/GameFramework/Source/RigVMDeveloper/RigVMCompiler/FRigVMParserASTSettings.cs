namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* The settings to apply during the parse of the abstract syntax tree.</summary>
[CppInclude("RigVMCompiler/RigVMAST.h")]
public partial struct FRigVMParserASTSettings {
	public bool bFoldAssignments;
	public bool bFoldLiterals;
	public TArray<URigVMLink> LinksToSkip;
	public UScriptStruct ExecuteContextStruct;
}
