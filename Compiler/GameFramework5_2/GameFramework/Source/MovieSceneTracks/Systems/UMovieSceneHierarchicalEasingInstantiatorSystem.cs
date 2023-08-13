namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>System that creates hierarchical easing channels for any newly introduced HierarchicalEasingProvider components</summary>
[CppInclude("Systems/WeightAndEasingEvaluatorSystem.h")]
public partial class UMovieSceneHierarchicalEasingInstantiatorSystem : UMovieSceneEntityInstantiatorSystem {
	public static UClass StaticClass() {return default;}
	///<summary>EvaluatorSystem</summary>
	public UWeightAndEasingEvaluatorSystem EvaluatorSystem;
}
