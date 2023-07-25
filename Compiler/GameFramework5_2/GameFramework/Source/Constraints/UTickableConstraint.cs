#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConstraintsManager.h")]
///<summary>UTickableConstraint</summary>
public partial class UTickableConstraint : UObject {
// TickableConstraint
	public FConstraintTickFunction ConstraintTick;
	public bool Active;
}
