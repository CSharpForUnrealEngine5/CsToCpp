#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Constraint.h")]
///<summary>A filter for a whole transform</summary>
public partial struct FTransformFilter {
// TransformFilter
	public FFilterOptionPerAxis TranslationFilter;
	public FFilterOptionPerAxis RotationFilter;
	public FFilterOptionPerAxis ScaleFilter;
}
