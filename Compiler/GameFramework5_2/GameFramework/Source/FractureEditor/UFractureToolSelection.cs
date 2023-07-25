#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolSelection.h")]
///<summary>Note this tool doesn't actually fracture, but it does remake pieces of geometry and shares a lot of machinery with the fracture tools</summary>
public partial class UFractureToolSelection : UFractureToolCutterBase {
// FractureToolSelection
	public UInputBehaviorSet SelectionBehaviorSet;
	public ULocalInputBehaviorSource SelectionBehaviorSource;
	public URectangleMarqueeManager RectangleMarqueeManager;
	public UInteractiveToolsContext UsedToolsContext;
	public UFractureSelectionSettings SelectionSettings;
}
