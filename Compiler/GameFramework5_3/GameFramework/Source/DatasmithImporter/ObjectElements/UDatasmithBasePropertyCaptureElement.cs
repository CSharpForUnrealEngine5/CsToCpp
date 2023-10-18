namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* UDatasmithBasePropertyCaptureElement</summary>
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
public partial class UDatasmithBasePropertyCaptureElement : UDatasmithObjectElement {
	public static UClass StaticClass() {return default;}
	///<summary>Sets the path used when attempting to capture a generic property</summary>
	public void SetPropertyPath(string Path) {}
	///<summary>Gets the path used when attempting to capture a generic property</summary>
	public string GetPropertyPath() { return default; }
	///<summary>Sets the category of this property capture</summary>
	public void SetCategory(EDatasmithPropertyCategory Category) {}
	///<summary>Gets the category of this property capture</summary>
	public EDatasmithPropertyCategory GetCategory() { return default; }
}
