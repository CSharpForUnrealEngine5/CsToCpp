namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Platform agnostic live link retarget asset</summary>
[CppInclude("ARLiveLinkRetargetAsset.h")]
public partial class UARLiveLinkRetargetAsset : ULiveLinkRetargetAsset {
	public static UClass StaticClass() {return default;}
	///<summary>SourceType</summary>
	public EARLiveLinkSourceType SourceType;
	///<summary>Mapping from AR platform bone name to UE4 skeleton bone name</summary>
	public TMap<FName,FName> BoneMap;
	///<summary>Configuration when using ARKit pose tracking</summary>
	public FARKitPoseTrackingConfig ARKitPoseTrackingConfig;
}
