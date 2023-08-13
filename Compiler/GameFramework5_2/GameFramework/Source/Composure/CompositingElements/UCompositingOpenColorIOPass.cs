namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UCompositingOpenColorIOPass</summary>
[CppInclude("CompositingElements/CompositingElementTransforms.h")]
public partial class UCompositingOpenColorIOPass : UCompositingElementTransform {
	public static UClass StaticClass() {return default;}
	///<summary>Color grading settings.</summary>
	public FOpenColorIOColorConversionSettings ColorConversionSettings;
}
