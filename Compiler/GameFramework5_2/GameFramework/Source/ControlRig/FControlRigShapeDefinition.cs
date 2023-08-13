namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigGizmoLibrary.h")]
public partial struct FControlRigShapeDefinition {
	public string ShapeName;
	public TSoftObjectPtr<UStaticMesh> StaticMesh;
	public FTransform Transform;
}
