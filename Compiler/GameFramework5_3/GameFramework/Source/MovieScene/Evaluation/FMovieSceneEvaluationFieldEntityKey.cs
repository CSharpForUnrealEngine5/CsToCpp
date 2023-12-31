namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A key that uniquely identifies an entity by its owner and ID</summary>
[CppInclude("Evaluation/MovieSceneEvaluationField.h")]
public partial struct FMovieSceneEvaluationFieldEntityKey {
	public TWeakObjectPtr<UObject> EntityOwner;
	public uint EntityID;
}
