namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This Match &amp; Set object looks up an attribute on a given point,</summary>
[CppInclude("MatchAndSet/PCGMatchAndSetByAttribute.h")]
public partial class UPCGMatchAndSetByAttribute : UPCGMatchAndSetBase {
	public static UClass StaticClass() {return default;}
	///<summary>Attribute to match on the data</summary>
	public string MatchSourceAttribute;
	///<summary>Type of the attribute to match against.</summary>
	public EPCGMetadataTypes MatchSourceType;
	///<summary>String type of the attribute to match against (if required).</summary>
	public EPCGMetadataTypesConstantStructStringMode MatchSourceStringMode;
	///<summary>Lookup entries (key-value pairs)</summary>
	public TArray<FPCGMatchAndSetByAttributeEntry> Entries;
}
