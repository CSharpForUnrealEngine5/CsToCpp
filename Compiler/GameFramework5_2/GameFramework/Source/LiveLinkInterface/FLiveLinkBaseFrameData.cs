#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base data structure for each frame coming in for a subject</summary>
[CppInclude("LiveLinkTypes.h")]
public partial struct FLiveLinkBaseFrameData {
	public FLiveLinkWorldTime WorldTime;
	public FLiveLinkMetaData MetaData;
	public TArray<float> PropertyValues;
}
