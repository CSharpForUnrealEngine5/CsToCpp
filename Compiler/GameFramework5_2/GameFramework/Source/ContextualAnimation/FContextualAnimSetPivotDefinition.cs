namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Rules used to compute the pivot for a AnimSet</summary>
[CppInclude("ContextualAnimTypes.h")]
public partial struct FContextualAnimSetPivotDefinition {
	public FName Name;
	public FName Origin;
	public bool bAlongClosestDistance;
	public FName OtherRole;
	public float Weight;
}
