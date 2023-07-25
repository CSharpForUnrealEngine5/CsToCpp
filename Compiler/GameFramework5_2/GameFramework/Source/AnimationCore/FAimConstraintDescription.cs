#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Constraint.h")]
///<summary>A description of how to apply aim constraint</summary>
public partial struct FAimConstraintDescription {
// AimConstraintDescription
	public FAxis LookAt_Axis;
	public FAxis LookUp_Axis;
	public bool bUseLookUp;
	public FVector LookUpTarget;
}
