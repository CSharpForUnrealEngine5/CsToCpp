#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>MVR General Scene Description Object</summary>
[CppInclude("MVR/DMXMVRGeneralSceneDescription.h")]
public partial class UDMXMVRGeneralSceneDescription : UObject {
	///<summary>The Root Node of the General Scene Description</summary>
	public UDMXMVRRootNode RootNode;
	///<summary>Import Data for this asset</summary>
	public UDMXMVRAssetImportData MVRAssetImportData;
}
