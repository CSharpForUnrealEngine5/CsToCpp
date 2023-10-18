namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CinePrestreamingData.h")]
public partial class UCinePrestreamingData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Times</summary>
	public TArray<FFrameNumber> Times;
	///<summary>VirtualTextureDatas</summary>
	public TArray<FCinePrestreamingVTData> VirtualTextureDatas;
	///<summary>NaniteDatas</summary>
	public TArray<FCinePrestreamingNaniteData> NaniteDatas;
	///<summary>Time that this asset was generated (in UTC). Used to give better context about how up to date an asset is as they are hard to preview.</summary>
	public FDateTime RecordedTime;
	///<summary>What resolution was this asset generated at? Recordings are resolution dependent as different mips will be chosen for different resolutions.</summary>
	public FIntPoint RecordedResolution;
}
