namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract base class for media sources.</summary>
[CppInclude("MediaSource.h")]
public partial class UMediaSource : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Get the media source&#39;s URL string (must be implemented in child classes).</summary>
	public virtual string GetUrl() { return default; }
	///<summary>Validate the media source settings (must be implemented in child classes).</summary>
	public virtual bool Validate() { return default; }
	///<summary>Set a boolean parameter to pass to the player.</summary>
	public void SetMediaOptionBool(string Key,bool Value) {}
	///<summary>Set a float parameter to pass to the player.</summary>
	public void SetMediaOptionFloat(string Key,float Value) {}
	///<summary>Set an integer64 parameter to pass to the player.</summary>
	public void SetMediaOptionInt64(string Key,long Value) {}
	///<summary>Set a string parameter to pass to the player.</summary>
	public void SetMediaOptionString(string Key,string Value) {}
	///<summary>The thumbnail image.</summary>
	public UTexture ThumbnailImage;
	///<summary>Renders thumnbnails for us.</summary>
	public UObject MediaSourceRenderer;
}
