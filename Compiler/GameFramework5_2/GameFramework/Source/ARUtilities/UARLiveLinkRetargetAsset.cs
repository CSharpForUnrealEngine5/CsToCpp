#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARLiveLinkRetargetAsset.h")]
///<summary>Platform agnostic live link retarget asset</summary>
public partial class UARLiveLinkRetargetAsset : ULiveLinkRetargetAsset {
// ARLiveLinkRetargetAsset
	public EARLiveLinkSourceType SourceType;
	public TMap<string,string> BoneMap;
	public FARKitPoseTrackingConfig ARKitPoseTrackingConfig;
}
