namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component used to copy the bounds of another Actor.</summary>
[CppInclude("Components/BoundsCopyComponent.h")]
public partial class UBoundsCopyComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Actor to copy the bounds from to set up the transform.</summary>
	public TSoftObjectPtr<AActor> BoundsSourceActor;
	///<summary>If true, the source actor&#39;s bounds will include its colliding components bounds.</summary>
	public bool bUseCollidingComponentsForSourceBounds;
	///<summary>If true, the actor&#39;s scale will be changed so that after adjustment, its own bounds match the source bounds.</summary>
	public bool bKeepOwnBoundsScale;
	///<summary>If true, the actor&#39;s own bounds will include its colliding components bounds.</summary>
	public bool bUseCollidingComponentsForOwnBounds;
	///<summary>Transform to apply to final result.</summary>
	public FTransform PostTransform;
	///<summary>bCopyXBounds</summary>
	public bool bCopyXBounds;
	///<summary>bCopyYBounds</summary>
	public bool bCopyYBounds;
	///<summary>bCopyZBounds</summary>
	public bool bCopyZBounds;
	///<summary>Copy the rotation from BoundsSourceActor to this component</summary>
	public void SetRotation() {}
	///<summary>Set this component transform to include the BoundsSourceActor bounds</summary>
	public void SetTransformToBounds() {}
}
