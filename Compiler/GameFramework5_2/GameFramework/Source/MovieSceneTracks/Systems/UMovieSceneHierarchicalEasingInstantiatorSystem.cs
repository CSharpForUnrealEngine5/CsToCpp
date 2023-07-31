#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>System that creates hierarchical easing channels for any newly introduced HierarchicalEasingProvider components</summary>
[CppInclude("Systems/WeightAndEasingEvaluatorSystem.h")]
public partial class UMovieSceneHierarchicalEasingInstantiatorSystem : UMovieSceneEntityInstantiatorSystem {
	///<summary>EvaluatorSystem</summary>
	public UWeightAndEasingEvaluatorSystem EvaluatorSystem;
}
