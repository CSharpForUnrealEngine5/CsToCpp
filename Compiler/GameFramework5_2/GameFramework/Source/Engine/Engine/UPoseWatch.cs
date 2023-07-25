#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PoseWatch.h")]
public partial class UPoseWatch : UObject {
// PoseWatch
	public TWeakObjectPtr<UEdGraphNode> Node;
	public UBlendProfile ViewportMask_DEPRECATED;
	public bool bInvertViewportMask_DEPRECATED;
	public float BlendScaleThreshold_DEPRECATED;
	public FVector3d ViewportOffset_DEPRECATED;
	public TArray<UPoseWatchElement> Elements;
	public bool bDeleteOnDeselection;
	public bool bIsVisible;
	public bool bIsNodeEnabled;
	public bool bIsExpanded;
	public FColor Color_DEPRECATED;
	public string Label;
	public string IconName_DEPRECATED;
	public TWeakObjectPtr<UPoseWatchFolder> Parent;
}
