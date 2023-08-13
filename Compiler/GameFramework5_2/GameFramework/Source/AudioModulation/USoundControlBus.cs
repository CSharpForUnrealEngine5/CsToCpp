namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundControlBus.h")]
public partial class USoundControlBus : USoundModulatorBase {
	public static UClass StaticClass() {return default;}
	///<summary>If true, bypasses control bus from being modulated by parameters, patches, or mixed (control bus remains active and computed).</summary>
	public bool bBypass;
	///<summary>If true, Address field is used in place of object name for address used when applying mix changes using filtering.</summary>
	public bool bOverrideAddress;
	///<summary>Address to use when applying mix changes.</summary>
	public string Address;
	///<summary>Generators</summary>
	public TArray<USoundModulationGenerator> Generators;
	///<summary>Parameter</summary>
	public USoundModulationParameter Parameter;
}
