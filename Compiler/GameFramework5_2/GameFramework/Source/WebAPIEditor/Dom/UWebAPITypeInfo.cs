namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds information for an existing or pending type.</summary>
[CppInclude("Dom/WebAPIType.h")]
public partial class UWebAPITypeInfo : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Type Name without prefix or namespace, ie. &quot;Vector&quot;, not &quot;FVector&quot;.</summary>
	public string Name;
	///<summary>Optional display name, different to the actual name, ie. &quot;JsonObject&quot; vs. &quot;JsonObjectWrapper&quot;.</summary>
	public string DisplayName;
	///<summary>SchemaType to discern between ie. a Service and a Model with the same name.</summary>
	public EWebAPISchemaType SchemaType;
	///<summary>Flag specifying whether this type is used exclusively by a parent type (isn&#39;t shared).</summary>
	public bool bIsNested;
	///<summary>When the type is nested, this specifies who &quot;owns&quot; it.</summary>
	public FWebAPITypeNameVariant ContainingType;
	///<summary>Field name as sent to and received from the external API.</summary>
	public string JsonName;
	///<summary>Json type. Should correspond with values in EJson.</summary>
	public string JsonType;
	///<summary>Optional sub-property to serialize, instead of the object itself.</summary>
	public string JsonPropertyToSerialize;
	///<summary>Optional specifier for printf, ie. &quot;s&quot;, &quot;d&quot;.</summary>
	public string PrintFormatSpecifier;
	///<summary>Optional tokenized string expression to get the value for printf, ie. ToString({Property})</summary>
	public string PrintFormatExpression;
	///<summary>Type Namespace, can be empty for built-in types.</summary>
	public string Namespace;
	///<summary>Type Prefix, usually &quot;F&quot;, &quot;U&quot;, &quot;A&quot;, or &quot;E&quot;.</summary>
	public string Prefix;
	///<summary>Optional suffix, ie. &quot;Parameter&quot;, &quot;Item&quot;, etc.</summary>
	public string Suffix;
	///<summary>Declaration type, ie. struct, enum.</summary>
	public string DeclarationType;
	///<summary>If this is false, the type is to be generated and should have a namespace.</summary>
	public bool bIsBuiltinType;
	///<summary>Default value as a string, if applicable.</summary>
	public string DefaultValue;
	///<summary>Associated model, if any.</summary>
	public TSoftObjectPtr<UWebAPIModelBase> Model;
	///<summary>Module dependencies for this type.</summary>
	public TSet<string> Modules;
	///<summary>Relative include paths required when referencing this type.</summary>
	public TSet<string> IncludePaths;
	///<summary>Color for UI.</summary>
	public FSlateColor PinColor;
	///<summary>Misc info for debug.</summary>
	public string DebugString;
}
