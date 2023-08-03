#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* UDatasmithVariantElement</summary>
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
public partial class UDatasmithVariantElement : UDatasmithObjectElement {
	public static UClass StaticClass() {return default;}
	///<summary>Create a new actor binding and add it to this variant</summary>
	public  UDatasmithActorBindingElement CreateActorBinding() { return default; }
	///<summary>Adds an existing actor binding to this variant</summary>
	public  void AddActorBinding(UDatasmithActorBindingElement Binding) {}
	///<summary>Gets how many actor bindings are in this variant</summary>
	public  int GetActorBindingsCount() { return default; }
	///<summary>Gets an actor binding from this variant</summary>
	public  UDatasmithActorBindingElement GetActorBinding(int Index) { return default; }
	///<summary>Removes an actor binding from this variant</summary>
	public  void RemoveActorBinding(UDatasmithActorBindingElement Binding) {}
}
