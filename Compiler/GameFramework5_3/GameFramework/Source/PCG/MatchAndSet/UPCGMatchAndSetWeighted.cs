namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This Match &amp; Set object assigns randomly a value based on weighted ratios,</summary>
[CppInclude("MatchAndSet/PCGMatchAndSetWeighted.h")]
public partial class UPCGMatchAndSetWeighted : UPCGMatchAndSetBase {
	public static UClass StaticClass() {return default;}
	///<summary>Values and their respective weights</summary>
	public TArray<FPCGMatchAndSetWeightedEntry> Entries;
	///<summary>Controls whether the output data should mutate its seed - prevents issues when doing multiple random processes in a row</summary>
	public bool bShouldMutateSeed;
}
