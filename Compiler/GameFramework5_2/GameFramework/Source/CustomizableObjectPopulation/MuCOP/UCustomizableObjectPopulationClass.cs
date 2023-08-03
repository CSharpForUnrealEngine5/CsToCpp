#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOP/CustomizableObjectPopulationClass.h")]
public partial class UCustomizableObjectPopulationClass : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the Customizable Object Population Class</summary>
	public string Name;
	///<summary>Customizable Object that defines this class</summary>
	public UCustomizableObject CustomizableObject;
	///<summary>List of parameter tags available for this class</summary>
	public TArray<string> Allowlist;
	///<summary>List of parameter tags forbidden for this class</summary>
	public TArray<string> Blocklist;
	///<summary>Additional options to take into account for some parameters</summary>
	public TArray<FCustomizableObjectPopulationCharacteristic> Characteristics;
	///<summary>Array with all the tags deffined for this population class</summary>
	public TArray<string> Tags;
}
