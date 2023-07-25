#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkRigUnits.h")]
///<summary>Get the transform value with supplied subject frame</summary>
public partial struct FRigUnit_LiveLinkGetTransformByName {
// RigUnit_LiveLinkGetTransformByName
	public FSubjectFrameHandle SubjectFrame;
	public string TransformName;
	public ERigVMTransformSpace Space;
	public FTransform Transform;
}
