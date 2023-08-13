namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigGizmoLibrary.h")]
public partial class UControlRigShapeLibrary : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultShape</summary>
	public FControlRigShapeDefinition DefaultShape;
	///<summary>DefaultMaterial</summary>
	public TSoftObjectPtr<UMaterial> DefaultMaterial;
	///<summary>XRayMaterial</summary>
	public TSoftObjectPtr<UMaterial> XRayMaterial;
	///<summary>MaterialColorParameter</summary>
	public string MaterialColorParameter;
	///<summary>Shapes</summary>
	public TArray<FControlRigShapeDefinition> Shapes;
}
