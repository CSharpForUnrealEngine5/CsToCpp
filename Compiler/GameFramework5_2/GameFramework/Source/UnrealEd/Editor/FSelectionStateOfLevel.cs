#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/EditorEngine.h")]
///<summary>Represents the current selection state of a level (its selected actors and components) from a given point in a time, in a way that can be safely restored later even if the level is reloaded</summary>
public partial struct FSelectionStateOfLevel {
// SelectionStateOfLevel
	public TArray<string> SelectedActors;
	public TArray<string> SelectedComponents;
}
