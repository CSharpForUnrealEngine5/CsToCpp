#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOP/CustomizableObjectPopulationClass.h")]
public partial class UCustomizableObjectPopulationClass : UObject {
// CustomizableObjectPopulationClass
	public string Name;
	public UCustomizableObject CustomizableObject;
	public TArray<string> Allowlist;
	public TArray<string> Blocklist;
	public TArray<FCustomizableObjectPopulationCharacteristic> Characteristics;
	public TArray<string> Tags;
}
