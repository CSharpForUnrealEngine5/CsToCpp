#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action setting a node's keywords in the graph.</summary>
public partial struct FRigVMSetNodeKeywordsAction {
// RigVMSetNodeKeywordsAction
	public string NodePath;
	public string OldKeywords;
	public string NewKeywords;
}
