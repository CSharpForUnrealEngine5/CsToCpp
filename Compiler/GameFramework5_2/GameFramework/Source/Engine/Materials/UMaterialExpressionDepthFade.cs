#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionDepthFade.h")]
public partial class UMaterialExpressionDepthFade : UMaterialExpression {
	///<summary>Defaults to &#39;OpacityDefault&#39; if not specified</summary>
	public FExpressionInput InOpacity;
	///<summary>Defaults to &#39;FadeDistanceDefault&#39; if not specified</summary>
	public FExpressionInput FadeDistance;
	///<summary>Opacity which will be scaled by the result of the fade.  This is used when InOpacity is unconnected.</summary>
	public float OpacityDefault;
	///<summary>World space distance over which the fade should take place.  This is used when FadeDistance is unconnected.</summary>
	public float FadeDistanceDefault;
}
