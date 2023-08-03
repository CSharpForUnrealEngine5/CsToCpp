#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomCardsEditorTool.h")]
public partial class USelectGroomCardsToolActions : UEditGroomCardsToolActionPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Clear the current selection</summary>
	public  void Clear() {}
	///<summary>Select unselected points along curve between selected points</summary>
	public  void Fill() {}
	///<summary>Add the next vertex along the card curve to the selection</summary>
	public  void AddNext() {}
	///<summary>Add the previous vertex along the card curve to the selection</summary>
	public  void AddPrevious() {}
	///<summary>Select all vertices to the end of the card</summary>
	public  void ToEnd() {}
	///<summary>Select all vertices to the start of the card</summary>
	public  void ToStart() {}
}
