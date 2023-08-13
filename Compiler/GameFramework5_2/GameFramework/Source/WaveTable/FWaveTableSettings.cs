namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveTableSettings.h")]
public partial struct FWaveTableSettings {
	public FFilePath FilePath;
	public int ChannelIndex;
	public float Phase;
	public float Top;
	public float Tail;
	public float FadeIn;
	public float FadeOut;
	public bool bNormalize;
	public bool bRemoveOffset;
	public TArray<float> SourcePCMData;
}
