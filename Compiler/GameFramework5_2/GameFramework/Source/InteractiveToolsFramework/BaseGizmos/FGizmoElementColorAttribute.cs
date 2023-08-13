namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Color state attribute struct</summary>
[CppInclude("BaseGizmos/GizmoElementRenderState.h")]
public partial struct FGizmoElementColorAttribute {
	public FLinearColor Value;
	public bool bHasValue;
	public bool bOverridesChildState;
}
