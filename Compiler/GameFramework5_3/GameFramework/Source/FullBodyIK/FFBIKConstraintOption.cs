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
