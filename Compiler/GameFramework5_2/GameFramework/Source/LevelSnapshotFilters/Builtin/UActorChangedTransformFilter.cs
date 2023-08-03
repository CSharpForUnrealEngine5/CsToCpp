#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows an actor depending on whether the actors&#39; transforms have changed.</summary>
[CppInclude("Builtin/ActorChangedTransformFilter.h")]
public partial class UActorChangedTransformFilter : UActorSelectorFilter {
	public static UClass StaticClass() {return default;}
	///<summary>Whether we allow actors that changed transform or that stayed at the same place.</summary>
	public ETransformReturnType TransformCheckRule;
	///<summary>If true, we do not compare the actors&#39; locations.</summary>
	public bool bIgnoreLocation;
	///<summary>If true, we do not compare the actors&#39; rotations.</summary>
	public bool bIgnoreRotation;
	///<summary>If true, we do not compare the actors&#39; scales.</summary>
	public bool bIgnoreScale;
}
