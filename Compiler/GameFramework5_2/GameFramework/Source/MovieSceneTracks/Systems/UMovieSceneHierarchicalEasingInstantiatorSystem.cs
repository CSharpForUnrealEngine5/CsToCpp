#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Systems/WeightAndEasingEvaluatorSystem.h")]
///<summary>System that creates hierarchical easing channels for any newly introduced HierarchicalEasingProvider components</summary>
public partial class UMovieSceneHierarchicalEasingInstantiatorSystem : UMovieSceneEntityInstantiatorSystem {
// MovieSceneHierarchicalEasingInstantiatorSystem
	public UWeightAndEasingEvaluatorSystem EvaluatorSystem;
}
