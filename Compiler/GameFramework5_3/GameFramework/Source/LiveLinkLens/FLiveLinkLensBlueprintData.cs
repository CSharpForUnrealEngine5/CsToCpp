namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Facility structure to handle lens data in blueprint</summary>
[CppInclude("LiveLinkLensTypes.h")]
public partial struct FLiveLinkLensBlueprintData {
	public FLiveLinkLensStaticData StaticData;
	public FLiveLinkLensFrameData FrameData;
}
