#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes a single property within a model.</summary>
[CppInclude("Dom/WebAPIModel.h")]
public partial class UWebAPIProperty : UWebAPIModelBase {
	///<summary>Name of the Property.</summary>
	public FWebAPINameVariant Name;
	///<summary>Type of the Property.</summary>
	public FWebAPITypeNameVariant Type;
	///<summary>If the property is an array of Type.</summary>
	public bool bIsArray;
	///<summary>When the properties inside of this should be treated as though they&#39;re directly in the parent.</summary>
	public bool bIsMixin;
	///<summary>Default value (optional) as a string.</summary>
	public string DefaultValue;
	///<summary>Array of values if needed, ie. enum</summary>
	public TArray<string> DefaultValues;
}
