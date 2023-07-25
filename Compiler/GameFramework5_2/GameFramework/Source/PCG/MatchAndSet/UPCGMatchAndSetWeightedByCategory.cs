#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MatchAndSet/PCGMatchAndSetWeightedByCategory.h")]
public partial class UPCGMatchAndSetWeightedByCategory : UPCGMatchAndSetBase {
// PCGMatchAndSetWeightedByCategory
	public string CategoryAttribute;
	public EPCGMetadataTypes CategoryType;
	public EPCGMetadataTypesConstantStructStringMode CategoryStringMode;
	public TArray<FPCGMatchAndSetWeightedByCategoryEntryList> Categories;
	public bool bShouldMutateSeed;
}
