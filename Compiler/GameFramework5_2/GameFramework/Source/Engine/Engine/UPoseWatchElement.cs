namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PoseWatch.h")]
public partial class UPoseWatchElement : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If true will draw the node to the view port.</summary>
	public bool bIsVisible;
	///<summary>bHasColor</summary>
	public bool bHasColor;
	///<summary>Color</summary>
	public FColor Color;
	///<summary>Label</summary>
	public FText Label;
	///<summary>IconName</summary>
	public string IconName;
	///<summary>Parent</summary>
	public TWeakObjectPtr<UPoseWatch> Parent;
}
