#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AIntervalGizmoActor is an Actor type intended to be used with UIntervalGizmo,</summary>
[CppInclude("BaseGizmos/IntervalGizmo.h")]
public partial class AIntervalGizmoActor : AGizmoActor {
	public static UClass StaticClass() {return default;}
	///<summary>UpIntervalComponent</summary>
	public UGizmoLineHandleComponent UpIntervalComponent;
	///<summary>DownIntervalComponent</summary>
	public UGizmoLineHandleComponent DownIntervalComponent;
	///<summary>ForwardIntervalComponent</summary>
	public UGizmoLineHandleComponent ForwardIntervalComponent;
}
