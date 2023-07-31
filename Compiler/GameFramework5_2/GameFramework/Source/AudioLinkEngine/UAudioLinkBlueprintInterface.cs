#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IAudioLinkBlueprintInterface.h")]
public partial class UAudioLinkBlueprintInterface : UInterface {
	///<summary>SetLinkSound</summary>
	public  void SetLinkSound(USoundBase NewSound) {}
	///<summary>PlayLink</summary>
	public  void PlayLink(float StartTime/*=0.0f*/) {}
	///<summary>Stop an audio component&#39;s sound, issue any delegates if needed</summary>
	public  void StopLink() {}
	///<summary>IsLinkPlaying</summary>
	public  bool IsLinkPlaying() { return default; }
}
