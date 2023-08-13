namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceAudioPlayer.h")]
public partial class UNiagaraDataInterfaceAudioPlayerSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>bOverrideConcurrency</summary>
	public bool bOverrideConcurrency;
	///<summary>Concurrency</summary>
	public USoundConcurrency Concurrency;
	///<summary>bOverrideAttenuationSettings</summary>
	public bool bOverrideAttenuationSettings;
	///<summary>AttenuationSettings</summary>
	public FSoundAttenuationSettings AttenuationSettings;
}
