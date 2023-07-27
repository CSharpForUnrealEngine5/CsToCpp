#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaSource.h")]
///<summary>Abstract base class for media sources.</summary>
public partial class UMediaSource : UObject {
// MediaSource
	public  string GetUrl() { return default; }
	public  bool Validate() { return default; }
	public  void SetMediaOptionBool(string Key,bool Value) {}
	public  void SetMediaOptionFloat(string Key,float Value) {}
	public  void SetMediaOptionInt64(string Key,long Value) {}
	public  void SetMediaOptionString(string Key,string Value) {}
	public UTexture ThumbnailImage;
	public UObject MediaSourceRenderer;
}
