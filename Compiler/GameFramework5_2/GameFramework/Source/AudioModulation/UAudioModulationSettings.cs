namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioModulationSettings.h")]
public partial class UAudioModulationSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Array of Modulation Parameters that are loaded on plugin startup</summary>
	public TArray<FSoftObjectPath> Parameters;
}
