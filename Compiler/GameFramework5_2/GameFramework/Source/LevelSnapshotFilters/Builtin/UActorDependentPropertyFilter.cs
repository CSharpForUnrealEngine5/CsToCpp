#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builtin/ActorDependentPropertyFilter.h")]
///<summary>Implements IsActorValid and IsPropertyValid as follows:</summary>
public partial class UActorDependentPropertyFilter : ULevelSnapshotFilter {
// ActorDependentPropertyFilter
	public ULevelSnapshotFilter ActorFilter;
	public ULevelSnapshotFilter IncludePropertyFilter;
	public ULevelSnapshotFilter ExcludePropertyFilter;
	public EDoNotCareHandling DoNotCareHandling;
	public ULevelSnapshotFilter DoNotCarePropertyFilter;
}
