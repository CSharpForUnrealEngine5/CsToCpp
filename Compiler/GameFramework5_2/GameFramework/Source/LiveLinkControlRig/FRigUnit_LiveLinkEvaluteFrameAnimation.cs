#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Evaluate current Live Link Animation associated with supplied subject</summary>
[CppInclude("LiveLinkRigUnits.h")]
public partial struct FRigUnit_LiveLinkEvaluteFrameAnimation {
	public string SubjectName;
	public bool bDrawDebug;
	public FLinearColor DebugColor;
	public FTransform DebugDrawOffset;
	public FSubjectFrameHandle SubjectFrame;
}
