#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/BoundsCopyComponent.h")]
///<summary>Component used to copy the bounds of another Actor.</summary>
public partial class UBoundsCopyComponent : UActorComponent {
// BoundsCopyComponent
	public TSoftObjectPtr<AActor> BoundsSourceActor;
	public bool bUseCollidingComponentsForSourceBounds;
	public bool bKeepOwnBoundsScale;
	public bool bUseCollidingComponentsForOwnBounds;
	public FTransform PostTransform;
	public bool bCopyXBounds;
	public bool bCopyYBounds;
	public bool bCopyZBounds;
	public void SetRotation() {}
	public void SetTransformToBounds() {}
}
