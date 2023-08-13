namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the current selection state of a level (its selected actors and components) from a given point in a time, in a way that can be safely restored later even if the level is reloaded</summary>
[CppInclude("Editor/EditorEngine.h")]
public partial struct FSelectionStateOfLevel {
	public TArray<string> SelectedActors;
	public TArray<string> SelectedComponents;
}
