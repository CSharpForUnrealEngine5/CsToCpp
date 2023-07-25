#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkTypes.h")]
///<summary>Store animation frame data</summary>
public partial struct FLiveLinkFrameData {
// LiveLinkFrameData
	public TArray<FTransform> Transforms;
	public TArray<FLiveLinkCurveElement> CurveElements;
	public FLiveLinkWorldTime WorldTime;
	public FLiveLinkMetaData MetaData;
}
