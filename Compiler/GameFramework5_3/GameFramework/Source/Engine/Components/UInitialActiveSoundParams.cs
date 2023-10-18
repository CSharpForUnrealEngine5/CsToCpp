namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Convenience class to get audio parameters set on an active sound&#39;s playback</summary>
[CppInclude("Components/AudioComponent.h")]
public partial class UInitialActiveSoundParams : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Collection of parameters to be sent to the active sound</summary>
	public TArray<FAudioParameter> AudioParams;
}
