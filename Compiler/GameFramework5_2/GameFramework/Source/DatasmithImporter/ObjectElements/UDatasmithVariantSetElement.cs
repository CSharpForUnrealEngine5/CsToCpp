#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* UDatasmithVariantSetElement</summary>
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
public partial class UDatasmithVariantSetElement : UDatasmithObjectElement {
	public static UClass StaticClass() {return default;}
	///<summary>Create a new variant and add it to the parent variant set</summary>
	public  UDatasmithVariantElement CreateVariant(string InElementName) { return default; }
	///<summary>Adds an existing variant to this variant set</summary>
	public  void AddVariant(UDatasmithVariantElement Variant) {}
	///<summary>Gets how many variants are in this variant set</summary>
	public  int GetVariantsCount() { return default; }
	///<summary>Gets a variant from this variant set</summary>
	public  UDatasmithVariantElement GetVariant(int Index) { return default; }
	///<summary>Removes a variant from this variant set</summary>
	public  void RemoveVariant(UDatasmithVariantElement Variant) {}
}
