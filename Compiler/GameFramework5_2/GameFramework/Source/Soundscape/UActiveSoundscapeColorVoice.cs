namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundscapeColor.h")]
public partial class UActiveSoundscapeColorVoice : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>AudioComponent</summary>
	public UAudioComponent AudioComponent;
	///<summary>TimerHandle</summary>
	public FTimerHandle TimerHandle;
	///<summary>bFree</summary>
	public bool bFree;
	///<summary>Limited duration timer</summary>
	public void StopLimitedDurationVoice(float FadeOutTime) {}
}
