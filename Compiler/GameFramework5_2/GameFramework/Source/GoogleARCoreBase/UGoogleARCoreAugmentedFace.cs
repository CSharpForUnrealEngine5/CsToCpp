#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An UObject representing a face detected by ARCore.</summary>
[CppInclude("GoogleARCoreAugmentedFace.h")]
public partial class UGoogleARCoreAugmentedFace : UARFaceGeometry {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the latest known local-to-world transform of the given face region.</summary>
	public  FTransform GetLocalToWorldTransformOfRegion(EGoogleARCoreAugmentedFaceRegion Region) { return default; }
	///<summary>Returns the latest known local-to-tracking transform of the given face region.</summary>
	public  FTransform GetLocalToTrackingTransformOfRegion(EGoogleARCoreAugmentedFaceRegion Region) { return default; }
}
