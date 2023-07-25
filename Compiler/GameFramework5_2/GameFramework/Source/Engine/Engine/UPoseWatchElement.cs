#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PoseWatch.h")]
public partial class UPoseWatchElement : UObject {
// PoseWatchElement
	public bool bIsVisible;
	public bool bHasColor;
	public FColor Color;
	public string Label;
	public string IconName;
	public TWeakObjectPtr<UPoseWatch> Parent;
}
