namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A description of how to apply aim constraint</summary>
[CppInclude("Constraint.h")]
public partial struct FAimConstraintDescription {
	public FAxis LookAt_Axis;
	public FAxis LookUp_Axis;
	public bool bUseLookUp;
	public FVector LookUpTarget;
}
