#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPIEnum.h")]
///<summary>Describes a (usually) API-specific class representing an enum.</summary>
public partial class UWebAPIEnum : UWebAPIModelBase {
// WebAPIEnum
	public FWebAPITypeNameVariant Name;
	public bool bGenerate;
	public string Type;
	public string DefaultValue;
	public TArray<UWebAPIEnumValue> Values;
	public string GeneratedCodeText;
}
