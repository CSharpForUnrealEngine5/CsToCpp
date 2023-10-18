namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorFilter/BaseActorFilter.h")]
public partial class UBaseActorFilter : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Filter</summary>
	public TArray<AActor> Filter(TArray<AActor> Source) { return default; }
	///<summary>FilterUnit</summary>
	public bool FilterUnit(AActor Source) { return default; }
	///<summary>bShouldRunGlobalFilter</summary>
	public bool bShouldRunGlobalFilter;
	///<summary>bShouldRunUnitFilter</summary>
	public bool bShouldRunUnitFilter;
}
