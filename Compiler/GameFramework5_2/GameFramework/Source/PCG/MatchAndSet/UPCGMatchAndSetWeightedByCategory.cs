namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MatchAndSet/PCGMatchAndSetWeightedByCategory.h")]
public partial class UPCGMatchAndSetWeightedByCategory : UPCGMatchAndSetBase {
	public static UClass StaticClass() {return default;}
	///<summary>Attribute to match against</summary>
	public string CategoryAttribute;
	///<summary>Type of the attribute to match against.</summary>
	public EPCGMetadataTypes CategoryType;
	///<summary>String subtype of the attribute to match against (if required).</summary>
	public EPCGMetadataTypesConstantStructStringMode CategoryStringMode;
	///<summary>Lookup entries (key -&gt; weighted list)</summary>
	public TArray<FPCGMatchAndSetWeightedByCategoryEntryList> Categories;
	///<summary>Controls whether the output data should mutate its seed - prevents issues when doing multiple random processes in a row</summary>
	public bool bShouldMutateSeed;
}
