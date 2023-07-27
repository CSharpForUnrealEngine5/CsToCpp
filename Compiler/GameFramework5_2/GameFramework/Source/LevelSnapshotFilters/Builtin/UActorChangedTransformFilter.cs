#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builtin/ActorChangedTransformFilter.h")]
///<summary>Allows an actor depending on whether the actors' transforms have changed.</summary>
public partial class UActorChangedTransformFilter : UActorSelectorFilter {
// ActorChangedTransformFilter
	public ETransformReturnType TransformCheckRule;
	public bool bIgnoreLocation;
	public bool bIgnoreRotation;
	public bool bIgnoreScale;
}
