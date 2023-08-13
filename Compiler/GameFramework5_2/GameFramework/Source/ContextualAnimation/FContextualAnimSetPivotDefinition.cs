namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Rules used to compute the pivot for a AnimSet</summary>
[CppInclude("ContextualAnimTypes.h")]
public partial struct FContextualAnimSetPivotDefinition {
	public string Name;
	public string Origin;
	public bool bAlongClosestDistance;
	public string OtherRole;
	public float Weight;
}
