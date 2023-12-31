namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PoseWatch.h")]
public partial class UPoseWatch : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Node</summary>
	public TWeakObjectPtr<UEdGraphNode> Node;
	///<summary>ViewportMask_DEPRECATED</summary>
	public UBlendProfile ViewportMask_DEPRECATED;
	///<summary>bInvertViewportMask_DEPRECATED</summary>
	public bool bInvertViewportMask_DEPRECATED;
	///<summary>BlendScaleThreshold_DEPRECATED</summary>
	public float BlendScaleThreshold_DEPRECATED;
	///<summary>ViewportOffset_DEPRECATED</summary>
	public FVector3d ViewportOffset_DEPRECATED;
	///<summary>Elements</summary>
	public TArray<UPoseWatchElement> Elements;
	///<summary>bDeleteOnDeselection</summary>
	public bool bDeleteOnDeselection;
	///<summary>If true will draw the pose to the viewport</summary>
	public bool bIsVisible;
	///<summary>If true, the node is able to be drawn to the view port.</summary>
	public bool bIsNodeEnabled;
	///<summary>bIsExpanded</summary>
	public bool bIsExpanded;
	///<summary>Color_DEPRECATED</summary>
	public FColor Color_DEPRECATED;
	///<summary>Label</summary>
	public FText Label;
	///<summary>IconName_DEPRECATED</summary>
	public FName IconName_DEPRECATED;
	///<summary>Parent</summary>
	public TWeakObjectPtr<UPoseWatchFolder> Parent;
}
