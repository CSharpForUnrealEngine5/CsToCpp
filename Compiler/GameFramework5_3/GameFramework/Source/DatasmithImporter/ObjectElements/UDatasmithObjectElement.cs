namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* UDatasmithObjectElement</summary>
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
public partial class UDatasmithObjectElement : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Gets the element name</summary>
	public string GetElementName() { return default; }
	///<summary>Gets the element label used in the UI</summary>
	public string GetLabel() { return default; }
	///<summary>Sets the element label used in the UI</summary>
	public void SetLabel(string InLabel) {}
	///<summary>Is the Element still valid for the Datasmith Scene</summary>
	public virtual bool IsElementValid() { return default; }
}
