#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorFilter/BaseActorFilter.h")]
public partial class UBaseActorFilter : UObject {
// BaseActorFilter
	public  TArray<AActor> Filter(TArray<AActor> Source) { return default; }
	public  bool FilterUnit(AActor Source) { return default; }
	public bool bShouldRunGlobalFilter;
	public bool bShouldRunUnitFilter;
}
