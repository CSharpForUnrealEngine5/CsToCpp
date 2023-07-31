#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action setting a node&#39;s keywords in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMSetNodeKeywordsAction {
	public string NodePath;
	public string OldKeywords;
	public string NewKeywords;
}
