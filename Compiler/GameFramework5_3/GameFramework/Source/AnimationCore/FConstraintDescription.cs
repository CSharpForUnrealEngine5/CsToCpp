namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A description of how to apply a simple transform constraint</summary>
[CppInclude("Constraint.h")]
public partial struct FConstraintDescription {
	public bool bTranslation;
	public bool bRotation;
	public bool bScale;
	public bool bParent;
	public FFilterOptionPerAxis TranslationAxes;
	public FFilterOptionPerAxis RotationAxes;
	public FFilterOptionPerAxis ScaleAxes;
}
