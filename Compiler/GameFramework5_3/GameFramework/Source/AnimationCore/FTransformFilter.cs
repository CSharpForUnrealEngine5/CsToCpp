namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A filter for a whole transform</summary>
[CppInclude("Constraint.h")]
public partial struct FTransformFilter {
	public FFilterOptionPerAxis TranslationFilter;
	public FFilterOptionPerAxis RotationFilter;
	public FFilterOptionPerAxis ScaleFilter;
}
