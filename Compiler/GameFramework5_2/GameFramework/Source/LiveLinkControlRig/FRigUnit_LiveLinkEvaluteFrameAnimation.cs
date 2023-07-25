#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkRigUnits.h")]
///<summary>Evaluate current Live Link Animation associated with supplied subject</summary>
public partial struct FRigUnit_LiveLinkEvaluteFrameAnimation {
// RigUnit_LiveLinkEvaluteFrameAnimation
	public string SubjectName;
	public bool bDrawDebug;
	public FLinearColor DebugColor;
	public FTransform DebugDrawOffset;
	public FSubjectFrameHandle SubjectFrame;
}
