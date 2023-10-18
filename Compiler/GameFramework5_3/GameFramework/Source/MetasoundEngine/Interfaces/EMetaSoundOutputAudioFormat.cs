namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Interfaces/MetasoundOutputFormatInterfaces.h")]
///<summary>Declares supported MetaSound output audio formats</summary>
public enum EMetaSoundOutputAudioFormat {
	Mono=0,
	Stereo=1,
	Quad=2,
	FiveDotOne=3,
	SevenDotOne=4,
	COUNT=5,
}
