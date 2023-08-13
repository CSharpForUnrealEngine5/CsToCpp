namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* UDatasmithMetaDataElement</summary>
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
public partial class UDatasmithMetaDataElement : UDatasmithObjectElement {
	public static UClass StaticClass() {return default;}
	///<summary>GetPropertiesCount</summary>
	public int GetPropertiesCount() { return default; }
	///<summary>Get the property i-th of this meta data</summary>
	public UDatasmithKeyValueProperty GetProperty(int i) { return default; }
	///<summary>Get a property by its name if it exists</summary>
	public UDatasmithKeyValueProperty GetPropertyByName(string InName) { return default; }
	///<summary>Get the element that is associated with this meta data</summary>
	public UDatasmithObjectElement GetAssociatedElement() { return default; }
	///<summary>Get this metadata element properties as a map of keys and values</summary>
	public void GetProperties(TArray<string> OutKeys,TArray<string> OutValues) {}
}
