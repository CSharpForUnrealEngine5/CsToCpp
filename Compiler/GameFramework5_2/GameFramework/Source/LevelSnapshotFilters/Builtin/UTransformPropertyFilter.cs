#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows you to filter location, rotation, and scale properties on scene components.</summary>
[CppInclude("Builtin/PropertySelector/TransformPropertyFilter.h")]
public partial class UTransformPropertyFilter : UPropertySelectorFilter {
	///<summary>Should the location property be restored?</summary>
	public EFilterResult Location;
	///<summary>Should the rotation property be restored?</summary>
	public EFilterResult Rotation;
	///<summary>Should the scale property be restored?</summary>
	public EFilterResult Scale;
}
