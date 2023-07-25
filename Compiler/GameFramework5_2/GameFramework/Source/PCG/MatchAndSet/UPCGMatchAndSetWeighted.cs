#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MatchAndSet/PCGMatchAndSetWeighted.h")]
///<summary>This Match & Set object assigns randomly a value based on weighted ratios,</summary>
public partial class UPCGMatchAndSetWeighted : UPCGMatchAndSetBase {
// PCGMatchAndSetWeighted
	public TArray<FPCGMatchAndSetWeightedEntry> Entries;
	public bool bShouldMutateSeed;
}
