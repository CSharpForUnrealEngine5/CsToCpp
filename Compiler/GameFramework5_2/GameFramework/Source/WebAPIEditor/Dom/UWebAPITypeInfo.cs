#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPIType.h")]
///<summary>Holds information for an existing or pending type.</summary>
public partial class UWebAPITypeInfo : UObject {
// WebAPITypeInfo
	public string Name;
	public string DisplayName;
	public EWebAPISchemaType SchemaType;
	public bool bIsNested;
	public FWebAPITypeNameVariant ContainingType;
	public string JsonName;
	public string JsonType;
	public string JsonPropertyToSerialize;
	public string PrintFormatSpecifier;
	public string PrintFormatExpression;
	public string Namespace;
	public string Prefix;
	public string Suffix;
	public string DeclarationType;
	public bool bIsBuiltinType;
	public string DefaultValue;
	public TSoftObjectPtr<UWebAPIModelBase> Model;
	public TSet<string> Modules;
	public TSet<string> IncludePaths;
	public FSlateColor PinColor;
	public string DebugString;
}
