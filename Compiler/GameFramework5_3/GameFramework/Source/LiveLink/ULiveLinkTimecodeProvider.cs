namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Fetch the latest frames from the LiveLink subject and create a Timecode from it.</summary>
[CppInclude("LiveLinkTimecodeProvider.h")]
public partial class ULiveLinkTimecodeProvider : UTimecodeProvider {
	public static UClass StaticClass() {return default;}
	///<summary>The specific subject that we listen to.</summary>
	public FLiveLinkSubjectKey SubjectKey;
	///<summary>How to evaluate the timecode.</summary>
	public ELiveLinkTimecodeProviderEvaluationType Evaluation;
	///<summary>bOverrideFrameRate</summary>
	public bool bOverrideFrameRate;
	///<summary>Override the frame rate at which this timecode provider will create its timecode value.</summary>
	public FFrameRate OverrideFrameRate;
	///<summary>The number of frame to keep in memory. The provider will not be synchronized until the buffer is full at least once.</summary>
	public int BufferSize;
}
