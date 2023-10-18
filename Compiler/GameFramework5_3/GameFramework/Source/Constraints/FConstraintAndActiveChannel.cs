namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>#if WITH_EDITOR</summary>
[CppInclude("ConstraintChannel.h")]
public partial struct FConstraintAndActiveChannel {
	public TSoftObjectPtr<UTickableConstraint> Constraint;
	public FMovieSceneConstraintChannel ActiveChannel;
	public UTickableConstraint ConstraintCopyToSpawn;
}
