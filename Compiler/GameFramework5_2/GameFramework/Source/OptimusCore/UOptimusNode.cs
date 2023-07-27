#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusNode.h")]
public partial class UOptimusNode : UObject {
// OptimusNode
	public  string GetNodeCategory() { return default; }
	public  string GetNodeName() { return default; }
	public  string GetDisplayName() { return default; }
	public  bool SetGraphPosition(FVector2D InPosition) { return default; }
	public  FVector2D GetGraphPosition() { return default; }
	public string DisplayName;
	public FVector2D GraphPosition;
	public TArray<UOptimusNodePin> Pins;
	public TSet<string> ExpandedPins;
	public EOptimusDiagnosticLevel DiagnosticLevel;
}
