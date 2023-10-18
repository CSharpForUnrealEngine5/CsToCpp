namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Constraint data container. It contains union of Constraints and node will contain array of these.</summary>
[CppInclude("Constraint.h")]
public partial struct FConstraintDescriptor {
	public EConstraintType Type;
}
