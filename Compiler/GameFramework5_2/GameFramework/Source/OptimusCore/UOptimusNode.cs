namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusNode.h")]
public partial class UOptimusNode : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the node class category. This is used for categorizing the node for display.</summary>
	public virtual string GetNodeCategory() { return default; }
	///<summary>Returns the node class name. This name is immutable for the given node class.</summary>
	public string GetNodeName() { return default; }
	///<summary>Returns the display name to use on the graphical node in the graph editor.</summary>
	public virtual FText GetDisplayName() { return default; }
	///<summary>Sets the position in the graph UI that the node should be shown at.</summary>
	public bool SetGraphPosition(FVector2D InPosition) { return default; }
	///<summary>Returns the position in the graph UI where the node is shown.</summary>
	public FVector2D GetGraphPosition() { return default; }
	///<summary>The display name to show. This is non-transactional because it is controlled by our</summary>
	public FText DisplayName;
	///<summary>Node layout data</summary>
	public FVector2D GraphPosition;
	///<summary>The list of pins. Non-transactional for the same reason as above.</summary>
	public TArray<UOptimusNodePin> Pins;
	///<summary>The list of pins that should be shown as expanded in the graph view.</summary>
	public TSet<string> ExpandedPins;
	///<summary>DiagnosticLevel</summary>
	public EOptimusDiagnosticLevel DiagnosticLevel;
}
