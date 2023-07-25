#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InteractiveToolManager.h")]
///<summary>UInteractiveToolManager can emit change events for the active tool in various ways.</summary>
public enum EToolChangeTrackingMode {
	NoChangeTracking=1,
	UndoToExit=2,
	FullUndoRedo=3,
}
