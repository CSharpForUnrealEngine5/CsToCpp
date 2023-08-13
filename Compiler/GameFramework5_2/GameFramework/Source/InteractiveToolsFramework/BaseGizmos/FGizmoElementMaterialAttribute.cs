namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material state attribute struct</summary>
[CppInclude("BaseGizmos/GizmoElementRenderState.h")]
public partial struct FGizmoElementMaterialAttribute {
	public TWeakObjectPtr<UMaterialInterface> Value;
	public bool bOverridesChildState;
}
