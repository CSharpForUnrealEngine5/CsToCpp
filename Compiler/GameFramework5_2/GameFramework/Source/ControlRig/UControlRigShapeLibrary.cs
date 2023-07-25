#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigGizmoLibrary.h")]
public partial class UControlRigShapeLibrary : UObject {
// ControlRigShapeLibrary
	public FControlRigShapeDefinition DefaultShape;
	public TSoftObjectPtr<UMaterial> DefaultMaterial;
	public TSoftObjectPtr<UMaterial> XRayMaterial;
	public string MaterialColorParameter;
	public TArray<FControlRigShapeDefinition> Shapes;
}
