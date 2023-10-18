namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An object representing an augmented image currently in the scene.</summary>
[CppInclude("GoogleARCoreAugmentedImage.h")]
public partial class UGoogleARCoreAugmentedImage : UARTrackedImage {
	public static UClass StaticClass() {return default;}
	///<summary>ImageIndex</summary>
	public int ImageIndex;
	///<summary>ImageName</summary>
	public string ImageName;
}
