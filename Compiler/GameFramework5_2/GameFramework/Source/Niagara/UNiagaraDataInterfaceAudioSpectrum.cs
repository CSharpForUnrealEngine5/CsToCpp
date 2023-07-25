#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceAudioSpectrum.h")]
///<summary>Data Interface allowing sampling of recent audio spectrum.</summary>
public partial class UNiagaraDataInterfaceAudioSpectrum : UNiagaraDataInterfaceAudioSubmix {
// NiagaraDataInterfaceAudioSpectrum
	public int Resolution;
	public float MinimumFrequency;
	public float MaximumFrequency;
	public float NoiseFloorDb;
}
