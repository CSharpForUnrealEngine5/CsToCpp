namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Supply curves from some external source (e.g. audio)</summary>
[CppInclude("AnimNodes/AnimNode_CurveSource.h")]
public partial struct FAnimNode_CurveSource {
	public FPoseLink SourcePose;
	public FName SourceBinding;
	public float Alpha;
	public object /*CurveSource*/ CurveSource;
}
