#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An asset that points to an image to be detected in a scene and provides the size of the object in real life</summary>
[CppInclude("ARTypes.h")]
public partial class UARCandidateImage : UDataAsset {
	///<summary>See: CandidateTexture</summary>
	public  UTexture2D GetCandidateTexture() { return default; }
	///<summary>See: FriendlyName</summary>
	public  string GetFriendlyName() { return default; }
	///<summary>See: Width</summary>
	public  float GetPhysicalWidth() { return default; }
	///<summary>See: Height</summary>
	public  float GetPhysicalHeight() { return default; }
	///<summary>See: Orientation</summary>
	public  EARCandidateImageOrientation GetOrientation() { return default; }
	///<summary>The image to detect in scenes</summary>
	public UTexture2D CandidateTexture;
	///<summary>The friendly name to report back when the image is detected in scenes</summary>
	public string FriendlyName;
	///<summary>The physical width in centimeters of the object that this candidate image represents</summary>
	public float Width;
	///<summary>The physical height in centimeters of the object that this candidate image represents. Ignored in ARCore</summary>
	public float Height;
	///<summary>The orientation to treat the candidate image as. Ignored in ARCore</summary>
	public EARCandidateImageOrientation Orientation;
}
