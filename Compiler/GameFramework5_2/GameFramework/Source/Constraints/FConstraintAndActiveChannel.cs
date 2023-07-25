#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConstraintChannel.h")]
///<summary>#if WITH_EDITOR</summary>
public partial struct FConstraintAndActiveChannel {
// ConstraintAndActiveChannel
	public TSoftObjectPtr<UTickableConstraint> Constraint;
	public FMovieSceneConstraintChannel ActiveChannel;
	public UTickableConstraint ConstraintCopyToSpawn;
}
