#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkTimecodeProvider.h")]
///<summary>Fetch the latest frames from the LiveLink subject and create a Timecode from it.</summary>
public partial class ULiveLinkTimecodeProvider : UTimecodeProvider {
// LiveLinkTimecodeProvider
	public FLiveLinkSubjectKey SubjectKey;
	public ELiveLinkTimecodeProviderEvaluationType Evaluation;
	public bool bOverrideFrameRate;
	public FFrameRate OverrideFrameRate;
	public int BufferSize;
}
