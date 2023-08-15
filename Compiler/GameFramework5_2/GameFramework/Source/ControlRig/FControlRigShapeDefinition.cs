namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigGizmoLibrary.h")]
public partial struct FControlRigShapeDefinition {
	public FName ShapeName;
	public TSoftObjectPtr<UStaticMesh> StaticMesh;
	public FTransform Transform;
}
