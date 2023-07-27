#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
///<summary>* UDatasmithActorBindingElement</summary>
public partial class UDatasmithActorBindingElement : UDatasmithObjectElement {
// DatasmithActorBindingElement
	public  void SetActor(UDatasmithActorElement Actor) {}
	public  UDatasmithActorElement GetActor() { return default; }
	public  UDatasmithPropertyCaptureElement CreatePropertyCapture() { return default; }
	public  UDatasmithObjectPropertyCaptureElement CreateObjectPropertyCapture() { return default; }
	public  void AddPropertyCapture(UDatasmithBasePropertyCaptureElement Prop) {}
	public  int GetPropertyCapturesCount() { return default; }
	public  UDatasmithBasePropertyCaptureElement GetPropertyCapture(int Index) { return default; }
	public  void RemovePropertyCapture(UDatasmithBasePropertyCaptureElement Prop) {}
}
