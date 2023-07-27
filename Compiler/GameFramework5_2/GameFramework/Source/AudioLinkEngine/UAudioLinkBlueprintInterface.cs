#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IAudioLinkBlueprintInterface.h")]
public partial class UAudioLinkBlueprintInterface : UInterface {
// AudioLinkBlueprintInterface
	public  void SetLinkSound(USoundBase NewSound) {}
	public  void PlayLink(float StartTime/*=0.0f*/) {}
	public  void StopLink() {}
	public  bool IsLinkPlaying() { return default; }
}
