#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCompiler/RigVMAST.h")]
///<summary>* The settings to apply during the parse of the abstract syntax tree.</summary>
public partial struct FRigVMParserASTSettings {
// RigVMParserASTSettings
	public bool bFoldAssignments;
	public bool bFoldLiterals;
	public TArray<URigVMLink> LinksToSkip;
	public UScriptStruct ExecuteContextStruct;
}
