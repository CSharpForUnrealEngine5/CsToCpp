#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Constraint.h")]
///<summary>A description of how to apply a simple transform constraint</summary>
public partial struct FConstraintDescription {
// ConstraintDescription
	public bool bTranslation;
	public bool bRotation;
	public bool bScale;
	public bool bParent;
	public FFilterOptionPerAxis TranslationAxes;
	public FFilterOptionPerAxis RotationAxes;
	public FFilterOptionPerAxis ScaleAxes;
}
