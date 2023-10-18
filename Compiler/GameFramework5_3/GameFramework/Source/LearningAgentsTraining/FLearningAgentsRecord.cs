namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single recording of a series of observations and actions.</summary>
[CppInclude("LearningAgentsRecording.h")]
public partial struct FLearningAgentsRecord {
	public int SampleNum;
	public int ObservationDimNum;
	public int ActionDimNum;
}
