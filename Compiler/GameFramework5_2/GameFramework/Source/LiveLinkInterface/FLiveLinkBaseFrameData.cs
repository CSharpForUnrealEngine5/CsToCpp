#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkTypes.h")]
///<summary>Base data structure for each frame coming in for a subject</summary>
public partial struct FLiveLinkBaseFrameData {
// LiveLinkBaseFrameData
	public FLiveLinkWorldTime WorldTime;
	public FLiveLinkMetaData MetaData;
	public TArray<float> PropertyValues;
}
