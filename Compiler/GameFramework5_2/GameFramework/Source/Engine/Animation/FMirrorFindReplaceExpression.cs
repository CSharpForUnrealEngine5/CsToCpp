namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Find and Replace expressions used to generate mirror tables</summary>
[CppInclude("Animation/MirrorDataTable.h")]
public partial struct FMirrorFindReplaceExpression {
	public string FindExpression;
	public string ReplaceExpression;
	public EMirrorFindReplaceMethod FindReplaceMethod;
}
