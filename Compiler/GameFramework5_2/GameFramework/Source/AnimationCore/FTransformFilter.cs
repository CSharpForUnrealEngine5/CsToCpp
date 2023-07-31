#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A filter for a whole transform</summary>
[CppInclude("Constraint.h")]
public partial struct FTransformFilter {
	public FFilterOptionPerAxis TranslationFilter;
	public FFilterOptionPerAxis RotationFilter;
	public FFilterOptionPerAxis ScaleFilter;
}
