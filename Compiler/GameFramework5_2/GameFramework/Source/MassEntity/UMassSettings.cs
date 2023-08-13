namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassSettings.h")]
public partial class UMassSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>ModuleSettings</summary>
	public TMap<string,UMassModuleSettings> ModuleSettings;
}
