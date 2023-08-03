#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImagePlateFileSequence.h")]
public partial class UImagePlateFileSequence : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Path to the directory in which the image sequence resides</summary>
	public FDirectoryPath SequencePath;
	///<summary>Wildcard used to find images within the directory (ie *.exr)</summary>
	public string FileWildcard;
	///<summary>Framerate at which to display the images</summary>
	public float Framerate;
}
