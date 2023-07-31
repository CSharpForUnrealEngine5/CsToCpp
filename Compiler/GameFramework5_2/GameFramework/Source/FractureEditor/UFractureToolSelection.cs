#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Note this tool doesn&#39;t actually fracture, but it does remake pieces of geometry and shares a lot of machinery with the fracture tools</summary>
[CppInclude("FractureToolSelection.h")]
public partial class UFractureToolSelection : UFractureToolCutterBase {
	///<summary>SelectionBehaviorSet</summary>
	public UInputBehaviorSet SelectionBehaviorSet;
	///<summary>SelectionBehaviorSource</summary>
	public ULocalInputBehaviorSource SelectionBehaviorSource;
	///<summary>RectangleMarqueeManager</summary>
	public URectangleMarqueeManager RectangleMarqueeManager;
	///<summary>the tools context responsible for the selection input router</summary>
	public UInteractiveToolsContext UsedToolsContext;
	///<summary>SelectionSettings</summary>
	public UFractureSelectionSettings SelectionSettings;
}
