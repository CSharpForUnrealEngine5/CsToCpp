#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPIModel.h")]
///<summary>Describes a (usually) API-specific struct or class representing a model.</summary>
public partial class UWebAPIModel : UWebAPIModelBase {
// WebAPIModel
	public FWebAPITypeNameVariant Name;
	public bool bGenerate;
	public FWebAPITypeNameVariant Type;
	public string DefaultValue;
	public TArray<UWebAPIProperty> Properties;
	public string GeneratedCodeText;
}
