#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_CurveSource.h")]
///<summary>Supply curves from some external source (e.g. audio)</summary>
public partial struct FAnimNode_CurveSource {
// AnimNode_CurveSource
	public FPoseLink SourcePose;
	public string SourceBinding;
	public float Alpha;
	public object /*CurveSource*/ CurveSource;
}
