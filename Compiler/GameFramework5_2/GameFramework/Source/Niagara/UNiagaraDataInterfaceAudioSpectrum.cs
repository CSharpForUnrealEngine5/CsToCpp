#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of recent audio spectrum.</summary>
[CppInclude("NiagaraDataInterfaceAudioSpectrum.h")]
public partial class UNiagaraDataInterfaceAudioSpectrum : UNiagaraDataInterfaceAudioSubmix {
	public static UClass StaticClass() {return default;}
	///<summary>The number of spectrum samples to pass to the GPU</summary>
	public int Resolution;
	///<summary>The minimum frequency represented in the spectrum.</summary>
	public float MinimumFrequency;
	///<summary>The maximum frequency represented in the spectrum.</summary>
	public float MaximumFrequency;
	///<summary>The decibel level considered as silence. This is used to scale the output of the spectrum.</summary>
	public float NoiseFloorDb;
}
