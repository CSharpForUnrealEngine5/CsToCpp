namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDatasmithKeyValueProperty</summary>
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
public partial class UDatasmithKeyValueProperty : UDatasmithObjectElement {
	public static UClass StaticClass() {return default;}
	///<summary>Get the type of this property</summary>
	public EDatasmithKeyValuePropertyType GetPropertyType() { return default; }
	///<summary>Set the type of this property</summary>
	public void SetPropertyType(EDatasmithKeyValuePropertyType InType) {}
	///<summary>Get the value of this property</summary>
	public string GetValue() { return default; }
	///<summary>Sets the value of this property</summary>
	public void SetValue(string Value) {}
}
