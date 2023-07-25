#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CinePrestreamingData.h")]
public partial class UCinePrestreamingData : UObject {
// CinePrestreamingData
	public TArray<FFrameNumber> Times;
	public TArray<FCinePrestreamingVTData> VirtualTextureDatas;
	public TArray<FCinePrestreamingNaniteData> NaniteDatas;
	public FDateTime RecordedTime;
	public FIntPoint RecordedResolution;
}
