namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PoseWatch.h")]
public partial class UPoseWatchFolder : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Label</summary>
	public FText Label;
	///<summary>Parent</summary>
	public TWeakObjectPtr<UPoseWatchFolder> Parent;
	///<summary>bIsVisible</summary>
	public bool bIsVisible;
	///<summary>bIsExpanded</summary>
	public bool bIsExpanded;
}
