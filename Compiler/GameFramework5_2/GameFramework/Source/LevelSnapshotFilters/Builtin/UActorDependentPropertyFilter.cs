#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements IsActorValid and IsPropertyValid as follows:</summary>
[CppInclude("Builtin/ActorDependentPropertyFilter.h")]
public partial class UActorDependentPropertyFilter : ULevelSnapshotFilter {
	public static UClass StaticClass() {return default;}
	///<summary>We run IsActorValid on this filter. IsPropertyValid uses one of the below filters depending on this filter.</summary>
	public ULevelSnapshotFilter ActorFilter;
	///<summary>Used by IsPropertyValid when ActorFilter-&gt;IsActorValid returns Include</summary>
	public ULevelSnapshotFilter IncludePropertyFilter;
	///<summary>Used by IsPropertyValid when ActorFilter-&gt;IsActorValid returns Exclude</summary>
	public ULevelSnapshotFilter ExcludePropertyFilter;
	///<summary>Determines what filter IsPropertyValid is supposed to use when IsActorValid returns DoNotCare.</summary>
	public EDoNotCareHandling DoNotCareHandling;
	///<summary>Used by IsPropertyValid when ActorFilter-&gt;IsActorValid returns DoNotCare and DoNotCareHandling == UseDoNotCareFilter.</summary>
	public ULevelSnapshotFilter DoNotCarePropertyFilter;
}
