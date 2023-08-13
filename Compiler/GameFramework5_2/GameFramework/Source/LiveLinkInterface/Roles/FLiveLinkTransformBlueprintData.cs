namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Facility structure to handle transform data in blueprint</summary>
[CppInclude("Roles/LiveLinkTransformTypes.h")]
public partial struct FLiveLinkTransformBlueprintData {
	public FLiveLinkTransformStaticData StaticData;
	public FLiveLinkTransformFrameData FrameData;
}
