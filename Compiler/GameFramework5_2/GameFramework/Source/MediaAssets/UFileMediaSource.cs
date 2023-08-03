#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FileMediaSource.h")]
public partial class UFileMediaSource : UBaseMediaSource {
	public static UClass StaticClass() {return default;}
	///<summary>The path to the media file to be played.</summary>
	public string FilePath;
	///<summary>Load entire media file into memory and play from there (if possible).</summary>
	public bool PrecacheFile;
	///<summary>Set the path to the media file that this source represents.</summary>
	public  void SetFilePath(string Path) {}
}
