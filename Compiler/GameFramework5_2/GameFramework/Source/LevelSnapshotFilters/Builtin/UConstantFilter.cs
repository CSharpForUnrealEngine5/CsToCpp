#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builtin/ConstantFilter.h")]
///<summary>Filter which treats all actors the same.</summary>
public partial class UConstantFilter : ULevelSnapshotFilter {
// ConstantFilter
	public EFilterResult IsActorValidResult;
	public EFilterResult IsPropertyValidResult;
	public EFilterResult IsDeletedActorValidResult;
	public EFilterResult IsAddedActorValidResult;
}
