namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CascadeConfiguration.h")]
public partial class UCascadeConfiguration : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>TypeData-to-base module mappings.</summary>
	public TArray<FModuleMenuMapper> ModuleMenu_TypeDataToBaseModuleRejections;
	///<summary>Module-to-TypeData mappings.</summary>
	public TArray<FModuleMenuMapper> ModuleMenu_TypeDataToSpecificModuleRejections;
	///<summary>Modules that Cascade should ignore in the menu system.</summary>
	public TArray<string> ModuleMenu_ModuleRejections;
}
