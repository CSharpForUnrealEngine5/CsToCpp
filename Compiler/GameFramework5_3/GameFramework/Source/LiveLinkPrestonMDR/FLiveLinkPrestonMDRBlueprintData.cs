namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Facility structure to handle Preston MDR data in blueprint</summary>
[CppInclude("LiveLinkPrestonMDRTypes.h")]
public partial struct FLiveLinkPrestonMDRBlueprintData {
	public FLiveLinkPrestonMDRStaticData StaticData;
	public FLiveLinkPrestonMDRFrameData FrameData;
}
