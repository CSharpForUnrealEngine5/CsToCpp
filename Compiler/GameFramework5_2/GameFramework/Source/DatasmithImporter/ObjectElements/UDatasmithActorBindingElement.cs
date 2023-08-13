namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* UDatasmithActorBindingElement</summary>
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
public partial class UDatasmithActorBindingElement : UDatasmithObjectElement {
	public static UClass StaticClass() {return default;}
	///<summary>Sets the actor that this binding will try capturing</summary>
	public void SetActor(UDatasmithActorElement Actor) {}
	///<summary>Gets the actor that this binding will try capturing</summary>
	public UDatasmithActorElement GetActor() { return default; }
	///<summary>Create a new property capture and add it to this binding</summary>
	public UDatasmithPropertyCaptureElement CreatePropertyCapture() { return default; }
	///<summary>Create a new object property capture and add it to this binding</summary>
	public UDatasmithObjectPropertyCaptureElement CreateObjectPropertyCapture() { return default; }
	///<summary>Adds an existing property capture to this binding</summary>
	public void AddPropertyCapture(UDatasmithBasePropertyCaptureElement Prop) {}
	///<summary>Gets how many properties will be captured from the bound actor</summary>
	public int GetPropertyCapturesCount() { return default; }
	///<summary>Gets property that will be captured from the bound actor</summary>
	public UDatasmithBasePropertyCaptureElement GetPropertyCapture(int Index) { return default; }
	///<summary>Removes one of the properties that will be captured from the bound actor</summary>
	public void RemovePropertyCapture(UDatasmithBasePropertyCaptureElement Prop) {}
}
