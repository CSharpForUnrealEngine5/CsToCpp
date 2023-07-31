#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Get the parameter value with supplied subject frame</summary>
[CppInclude("LiveLinkRigUnits.h")]
public partial struct FRigUnit_LiveLinkGetParameterValueByName {
	public FSubjectFrameHandle SubjectFrame;
	public string ParameterName;
	public float Value;
}
