namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action setting a node&#39;s keywords in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMSetNodeKeywordsAction {
	public string NodePath;
	public string OldKeywords;
	public string NewKeywords;
}
