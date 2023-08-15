namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Get the parameter value with supplied subject frame</summary>
[CppInclude("LiveLinkRigUnits.h")]
public partial struct FRigUnit_LiveLinkGetParameterValueByName {
	public FSubjectFrameHandle SubjectFrame;
	public FName ParameterName;
	public float Value;
}
