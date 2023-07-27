#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTypes.h")]
///<summary>An asset that points to an image to be detected in a scene and provides the size of the object in real life</summary>
public partial class UARCandidateImage : UDataAsset {
// ARCandidateImage
	public  UTexture2D GetCandidateTexture() { return default; }
	public  string GetFriendlyName() { return default; }
	public  float GetPhysicalWidth() { return default; }
	public  float GetPhysicalHeight() { return default; }
	public  EARCandidateImageOrientation GetOrientation() { return default; }
	public UTexture2D CandidateTexture;
	public string FriendlyName;
	public float Width;
	public float Height;
	public EARCandidateImageOrientation Orientation;
}
