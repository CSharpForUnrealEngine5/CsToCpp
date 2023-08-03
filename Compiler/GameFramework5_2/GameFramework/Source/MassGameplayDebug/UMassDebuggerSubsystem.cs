#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassDebuggerSubsystem.h")]
public partial class UMassDebuggerSubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>VisualizationComponent</summary>
	public UMassDebugVisualizationComponent VisualizationComponent;
	///<summary>DebugVisualizer</summary>
	public AMassDebugVisualizer DebugVisualizer;
}
