#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkRigUnits.h")]
///<summary>Get the parameter value with supplied subject frame</summary>
public partial struct FRigUnit_LiveLinkGetParameterValueByName {
// RigUnit_LiveLinkGetParameterValueByName
	public FSubjectFrameHandle SubjectFrame;
	public string ParameterName;
	public float Value;
}
