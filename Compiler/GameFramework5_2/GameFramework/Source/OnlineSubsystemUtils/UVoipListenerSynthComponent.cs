namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VoipListenerSynthComponent.h")]
public partial class UVoipListenerSynthComponent : USynthComponent {
	public static UClass StaticClass() {return default;}
	///<summary>* Thread safe way to get whether this synth component still has buffered packets of audio to play back.</summary>
	public bool IsIdling() { return default; }
}
