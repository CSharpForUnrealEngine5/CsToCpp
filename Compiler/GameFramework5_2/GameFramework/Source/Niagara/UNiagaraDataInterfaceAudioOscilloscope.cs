namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of recent audio data.</summary>
[CppInclude("NiagaraDataInterfaceAudioOscilloscope.h")]
public partial class UNiagaraDataInterfaceAudioOscilloscope : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Submix</summary>
	public USoundSubmix Submix;
	///<summary>The number of samples of audio to pass to the GPU. Audio will be resampled to fit this resolution.</summary>
	public int Resolution;
	///<summary>The number of milliseconds of audio to show.</summary>
	public float ScopeInMilliseconds;
}
