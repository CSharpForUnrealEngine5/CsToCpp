namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes a (usually) API-specific class representing an enum.</summary>
[CppInclude("Dom/WebAPIEnum.h")]
public partial class UWebAPIEnum : UWebAPIModelBase {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the Enum.</summary>
	public FWebAPITypeNameVariant Name;
	///<summary>Will be set based on dependent operations.</summary>
	public bool bGenerate;
	///<summary>The enum base type, always uint8.</summary>
	public string Type;
	///<summary>Current or Default Value of the Enum.</summary>
	public string DefaultValue;
	///<summary>Values within the Enum.</summary>
	public TArray<UWebAPIEnumValue> Values;
	///<summary>The last generated code as text for debugging.</summary>
	public string GeneratedCodeText;
}
