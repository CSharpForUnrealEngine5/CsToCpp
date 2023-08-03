#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An object representing an augmented image currently in the scene.</summary>
[CppInclude("GoogleARCoreAugmentedImage.h")]
public partial class UGoogleARCoreAugmentedImage : UARTrackedImage {
	public static UClass StaticClass() {return default;}
	///<summary>GetCenter</summary>
	public  FVector GetCenter() { return default; }
	///<summary>GetExtent</summary>
	public  FVector GetExtent() { return default; }
	///<summary>GetImageIndex</summary>
	public  int GetImageIndex() { return default; }
	///<summary>GetImageName</summary>
	public  string GetImageName() { return default; }
	///<summary>ImageIndex</summary>
	public int ImageIndex;
	///<summary>ImageName</summary>
	public string ImageName;
}
