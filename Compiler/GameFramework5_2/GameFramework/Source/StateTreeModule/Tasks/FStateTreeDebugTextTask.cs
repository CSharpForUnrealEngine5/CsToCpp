#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Draws debug text on the HUD associated to the player controller.</summary>
[CppInclude("Tasks/StateTreeDebugTextTask.h")]
public partial struct FStateTreeDebugTextTask {
	public string Text;
	public FColor TextColor;
	public float FontScale;
	public FVector Offset;
	public bool bEnabled;
}
