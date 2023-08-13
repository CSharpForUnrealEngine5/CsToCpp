namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Haptics/HapticFeedbackEffect_Buffer.h")]
public partial class UHapticFeedbackEffect_Buffer : UHapticFeedbackEffect_Base {
	public static UClass StaticClass() {return default;}
	///<summary>Amplitudes</summary>
	public TArray<byte> Amplitudes;
	///<summary>SampleRate</summary>
	public int SampleRate;
}
