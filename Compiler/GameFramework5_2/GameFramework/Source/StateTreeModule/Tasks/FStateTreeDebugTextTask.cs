#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/StateTreeDebugTextTask.h")]
///<summary>Draws debug text on the HUD associated to the player controller.</summary>
public partial struct FStateTreeDebugTextTask {
// StateTreeDebugTextTask
	public string Text;
	public FColor TextColor;
	public float FontScale;
	public FVector Offset;
	public bool bEnabled;
}
