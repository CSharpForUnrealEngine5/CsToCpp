namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/AudioComponent.h")]
///<summary>Type of fade to use when adjusting the audio component&#39;s volume.</summary>
public enum EAudioFaderCurve {
	Linear=0,
	Logarithmic=1,
	SCurve=2,
	Sin=3,
	Count=4,
}
