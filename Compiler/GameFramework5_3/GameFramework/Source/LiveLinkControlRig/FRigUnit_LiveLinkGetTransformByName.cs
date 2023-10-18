namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Get the transform value with supplied subject frame</summary>
[CppInclude("LiveLinkRigUnits.h")]
public partial struct FRigUnit_LiveLinkGetTransformByName {
	public FSubjectFrameHandle SubjectFrame;
	public FName TransformName;
	public ERigVMTransformSpace Space;
	public FTransform Transform;
}
