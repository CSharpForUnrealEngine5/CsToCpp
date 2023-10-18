namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A UDataAsset that can be used to configure ARCore specific settings on top of</summary>
[CppInclude("GoogleARCoreSessionConfig.h")]
public partial class UGoogleARCoreSessionConfig : UARSessionConfig {
	public static UClass StaticClass() {return default;}
	///<summary>Get the augmented image database being used.</summary>
	public UGoogleARCoreAugmentedImageDatabase GetAugmentedImageDatabase() { return default; }
	///<summary>Set the augmented image database to use.</summary>
	public void SetAugmentedImageDatabase(UGoogleARCoreAugmentedImageDatabase NewImageDatabase) {}
	///<summary>A UGoogleARCoreAugmentedImageDatabase asset to use use for</summary>
	public UGoogleARCoreAugmentedImageDatabase AugmentedImageDatabase;
	///<summary>Configure which camera will be used to in the AR session.</summary>
	public EGoogleARCoreCameraFacing CameraFacing;
	///<summary>Configure which Augmented Face mode will be used in the AR session.</summary>
	public EGoogleARCoreAugmentedFaceMode AugmentedFaceMode;
}
