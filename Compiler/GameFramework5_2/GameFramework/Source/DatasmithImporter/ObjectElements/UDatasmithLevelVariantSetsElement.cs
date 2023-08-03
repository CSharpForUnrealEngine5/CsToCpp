#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* UDatasmithLevelVariantSetsElement</summary>
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
public partial class UDatasmithLevelVariantSetsElement : UDatasmithObjectElement {
	public static UClass StaticClass() {return default;}
	///<summary>Create a new variant set and add it to the parent level variant sets</summary>
	public  UDatasmithVariantSetElement CreateVariantSet(string InElementName) { return default; }
	///<summary>Adds an existing variant set to this level variant sets</summary>
	public  void AddVariantSet(UDatasmithVariantSetElement VariantSet) {}
	///<summary>Gets how many variant sets are in this level variant sets</summary>
	public  int GetVariantSetsCount() { return default; }
	///<summary>Gets a variant set from this level variant sets</summary>
	public  UDatasmithVariantSetElement GetVariantSet(int Index) { return default; }
	///<summary>Removes a variant set from this level variant sets</summary>
	public  void RemoveVariantSet(UDatasmithVariantSetElement VariantSet) {}
}
