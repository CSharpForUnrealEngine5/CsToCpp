namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties of the Transfer operation</summary>
[CppInclude("ConvertMeshesTool.h")]
public partial class UConvertMeshesToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>bTransferMaterials</summary>
	public bool bTransferMaterials;
	///<summary>control whether the transfer materials option is displayed</summary>
	public bool bShowTransferMaterials;
}
