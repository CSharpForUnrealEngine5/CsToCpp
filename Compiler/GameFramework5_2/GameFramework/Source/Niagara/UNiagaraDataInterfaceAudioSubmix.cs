#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of recent audio data.</summary>
[CppInclude("NiagaraDataInterfaceAudio.h")]
public partial class UNiagaraDataInterfaceAudioSubmix : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>The audio submix where analyzed.</summary>
	public USoundSubmix Submix;
}
