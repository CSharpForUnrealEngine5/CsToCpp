#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxSceneImportFactory.h")]
public partial class UFbxSceneImportFactory : USceneImportFactory {
// FbxSceneImportFactory
	public UFbxSceneImportOptions SceneImportOptions;
	public UFbxSceneImportOptionsStaticMesh SceneImportOptionsStaticMesh;
	public UFbxSceneImportOptionsSkeletalMesh SceneImportOptionsSkeletalMesh;
	public UFbxStaticMeshImportData StaticMeshImportData;
	public UFbxSkeletalMeshImportData SkeletalMeshImportData;
	public UFbxAnimSequenceImportData AnimSequenceImportData;
	public UFbxTextureImportData TextureImportData;
	public UFbxSceneImportData ReimportData;
}
