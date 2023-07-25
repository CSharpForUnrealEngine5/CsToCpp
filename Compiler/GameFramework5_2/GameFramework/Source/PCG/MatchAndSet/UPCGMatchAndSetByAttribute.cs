#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MatchAndSet/PCGMatchAndSetByAttribute.h")]
///<summary>This Match & Set object looks up an attribute on a given point,</summary>
public partial class UPCGMatchAndSetByAttribute : UPCGMatchAndSetBase {
// PCGMatchAndSetByAttribute
	public string MatchSourceAttribute;
	public EPCGMetadataTypes MatchSourceType;
	public EPCGMetadataTypesConstantStructStringMode MatchSourceStringMode;
	public TArray<FPCGMatchAndSetByAttributeEntry> Entries;
}
