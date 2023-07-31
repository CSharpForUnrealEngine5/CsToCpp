#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material state attribute struct</summary>
[CppInclude("BaseGizmos/GizmoElementRenderState.h")]
public partial struct FGizmoElementMaterialAttribute {
	public TWeakObjectPtr<UMaterialInterface> Value;
	public bool bOverridesChildState;
}
