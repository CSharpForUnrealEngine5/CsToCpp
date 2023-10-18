namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Evaluate current Live Link Transform associated with supplied subject</summary>
[CppInclude("LiveLinkRigUnits.h")]
public partial struct FRigUnit_LiveLinkEvaluteFrameTransform {
	public FName SubjectName;
	public bool bDrawDebug;
	public FLinearColor DebugColor;
	public FTransform DebugDrawOffset;
	public FTransform Transform;
}
