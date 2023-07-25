#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewportInteractionTypes.h")]
///<summary>Methods of dragging objects around in VR</summary>
public enum EViewportInteractionDraggingMode {
	Nothing=0,
	TransformablesWithGizmo=1,
	TransformablesAtLaserImpact=2,
	AssistingDrag=3,
	TransformablesFreely=4,
	World=5,
	Interactable=6,
	Material=7,
}
