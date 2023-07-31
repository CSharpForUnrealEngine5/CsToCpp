#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Store animation frame data</summary>
[CppInclude("LiveLinkTypes.h")]
public partial struct FLiveLinkFrameData {
	public TArray<FTransform> Transforms;
	public TArray<FLiveLinkCurveElement> CurveElements;
	public FLiveLinkWorldTime WorldTime;
	public FLiveLinkMetaData MetaData;
}
