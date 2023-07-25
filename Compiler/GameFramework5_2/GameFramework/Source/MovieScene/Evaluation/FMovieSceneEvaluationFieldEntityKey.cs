#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneEvaluationField.h")]
///<summary>A key that uniquely identifies an entity by its owner and ID</summary>
public partial struct FMovieSceneEvaluationFieldEntityKey {
// MovieSceneEvaluationFieldEntityKey
	public TWeakObjectPtr<UObject> EntityOwner;
	public uint EntityID;
}
