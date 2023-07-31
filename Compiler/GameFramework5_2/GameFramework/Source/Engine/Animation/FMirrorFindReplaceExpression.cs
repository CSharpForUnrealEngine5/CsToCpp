#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Find and Replace expressions used to generate mirror tables</summary>
[CppInclude("Animation/MirrorDataTable.h")]
public partial struct FMirrorFindReplaceExpression {
	public string FindExpression;
	public string ReplaceExpression;
	public EMirrorFindReplaceMethod FindReplaceMethod;
}
