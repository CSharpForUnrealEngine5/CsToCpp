#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceAudioOscilloscope.h")]
///<summary>Data Interface allowing sampling of recent audio data.</summary>
public partial class UNiagaraDataInterfaceAudioOscilloscope : UNiagaraDataInterface {
// NiagaraDataInterfaceAudioOscilloscope
	public USoundSubmix Submix;
	public int Resolution;
	public float ScopeInMilliseconds;
}
