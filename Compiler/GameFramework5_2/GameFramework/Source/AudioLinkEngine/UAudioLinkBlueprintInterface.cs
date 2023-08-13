namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IAudioLinkBlueprintInterface.h")]
public partial class UAudioLinkBlueprintInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>SetLinkSound</summary>
	public virtual void SetLinkSound(USoundBase NewSound) {}
	///<summary>PlayLink</summary>
	public virtual void PlayLink(float StartTime/*=0.0f*/) {}
	///<summary>Stop an audio component&#39;s sound, issue any delegates if needed</summary>
	public virtual void StopLink() {}
	///<summary>IsLinkPlaying</summary>
	public virtual bool IsLinkPlaying() { return default; }
}
