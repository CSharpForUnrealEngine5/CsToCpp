#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FBIKConstraintOption.h")]
public partial struct FFBIKConstraintOption {
	public FRigElementKey Item;
	public bool bEnabled;
	public bool bUseStiffness;
	public FVector LinearStiffness;
	public FVector AngularStiffness;
	public bool bUseAngularLimit;
	public FFBIKBoneLimit AngularLimit;
	public bool bUsePoleVector;
	public EPoleVectorOption PoleVectorOption;
	public FVector PoleVector;
	public FRotator OffsetRotation;
}
