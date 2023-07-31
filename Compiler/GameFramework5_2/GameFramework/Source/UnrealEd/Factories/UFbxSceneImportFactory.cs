#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxSceneImportFactory.h")]
public partial class UFbxSceneImportFactory : USceneImportFactory {
	///<summary>Import options UI detail when importing fbx scene</summary>
	public UFbxSceneImportOptions SceneImportOptions;
	///<summary>Import options UI detail when importing fbx scene static mesh</summary>
	public UFbxSceneImportOptionsStaticMesh SceneImportOptionsStaticMesh;
	///<summary>Import options UI detail when importing fbx scene skeletal mesh</summary>
	public UFbxSceneImportOptionsSkeletalMesh SceneImportOptionsSkeletalMesh;
	///<summary>Import data used when importing static meshes</summary>
	public UFbxStaticMeshImportData StaticMeshImportData;
	///<summary>Import data used when importing skeletal meshes</summary>
	public UFbxSkeletalMeshImportData SkeletalMeshImportData;
	///<summary>Import data used when importing animations</summary>
	public UFbxAnimSequenceImportData AnimSequenceImportData;
	///<summary>Import data used when importing textures</summary>
	public UFbxTextureImportData TextureImportData;
	///<summary>Pointer on the fbx scene import data, we fill this object to be able to do re import of the scene</summary>
	public UFbxSceneImportData ReimportData;
}
