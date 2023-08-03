#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes a (usually) API-specific struct or class representing a model.</summary>
[CppInclude("Dom/WebAPIModel.h")]
public partial class UWebAPIModel : UWebAPIModelBase {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the Model.</summary>
	public FWebAPITypeNameVariant Name;
	///<summary>Will be set based on dependent operations.</summary>
	public bool bGenerate;
	///<summary>The corresponding TypeInfo for this Model.</summary>
	public FWebAPITypeNameVariant Type;
	///<summary>Default value (optional) as a string.</summary>
	public string DefaultValue;
	///<summary>Array of properties contained in this model.</summary>
	public TArray<UWebAPIProperty> Properties;
	///<summary>The last generated code as text for debugging.</summary>
	public string GeneratedCodeText;
}
