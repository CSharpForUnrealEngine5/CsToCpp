#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Framework/Commands/UICommandInfo.h")]
///<summary>Types of user interfaces that can be associated with a user interface action</summary>
public enum EUserInterfaceActionType {
	None=0,
	Button=1,
	ToggleButton=2,
	RadioButton=3,
	Check=4,
	CollapsedButton=5,
}
