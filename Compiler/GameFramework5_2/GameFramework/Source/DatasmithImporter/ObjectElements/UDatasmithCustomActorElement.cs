#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDatasmithCustomActorElement</summary>
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
public partial class UDatasmithCustomActorElement : UDatasmithActorElement {
	public static UClass StaticClass() {return default;}
	///<summary>The blueprint to instantiate.</summary>
	public  string GetClassOrPathName() { return default; }
	///<summary>SetClassOrPathName</summary>
	public  void SetClassOrPathName(string InPathName) {}
	///<summary>Get the total amount of properties in this blueprint actor</summary>
	public  int GetPropertiesCount() { return default; }
	///<summary>Get the property i-th of this blueprint actor</summary>
	public  UDatasmithKeyValueProperty GetProperty(int i) { return default; }
	///<summary>Get a property by its name if it exists</summary>
	public  UDatasmithKeyValueProperty GetPropertyByName(string InName) { return default; }
	///<summary>Add a property to this blueprint actor</summary>
	public  void AddProperty(UDatasmithKeyValueProperty Property) {}
	///<summary>Removes a property from this blueprint actor, doesn&#39;t preserve ordering</summary>
	public  void RemoveProperty(UDatasmithKeyValueProperty Property) {}
}
