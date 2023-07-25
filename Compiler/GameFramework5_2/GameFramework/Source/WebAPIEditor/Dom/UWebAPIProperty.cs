#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPIModel.h")]
///<summary>Describes a single property within a model.</summary>
public partial class UWebAPIProperty : UWebAPIModelBase {
// WebAPIProperty
	public FWebAPINameVariant Name;
	public FWebAPITypeNameVariant Type;
	public bool bIsArray;
	public bool bIsMixin;
	public string DefaultValue;
	public TArray<string> DefaultValues;
}
