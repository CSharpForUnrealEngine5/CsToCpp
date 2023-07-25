#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FBIKConstraintOption.h")]
public partial struct FFBIKConstraintOption {
// FBIKConstraintOption
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
