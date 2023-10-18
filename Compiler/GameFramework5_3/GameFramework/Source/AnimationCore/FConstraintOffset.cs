namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the offset for constraint</summary>
[CppInclude("Constraint.h")]
public partial struct FConstraintOffset {
	public FVector Translation;
	public FQuat Rotation;
	public FVector Scale;
	public FTransform Parent;
}
