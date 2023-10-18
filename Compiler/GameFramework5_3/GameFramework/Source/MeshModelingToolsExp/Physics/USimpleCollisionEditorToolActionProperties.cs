namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/SimpleCollisionEditorTool.h")]
public partial class USimpleCollisionEditorToolActionProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Duplicate all selected simple collision shapes</summary>
	public void Duplicate() {}
	///<summary>Remove currently selected simple collision shapes from the mesh</summary>
	public void Delete() {}
	///<summary>Remove all current simple collision shapes from the mesh</summary>
	public void DeleteAll() {}
	///<summary>Add a new simple sphere collision shape</summary>
	public void AddSphere() {}
	///<summary>Add a new simple box collision shape</summary>
	public void AddBox() {}
	///<summary>Add a new simple capsule collision shape</summary>
	public void AddCapsule() {}
}
