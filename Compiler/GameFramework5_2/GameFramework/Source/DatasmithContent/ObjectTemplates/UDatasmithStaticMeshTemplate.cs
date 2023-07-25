#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectTemplates/DatasmithStaticMeshTemplate.h")]
public partial class UDatasmithStaticMeshTemplate : UDatasmithObjectTemplate {
// DatasmithStaticMeshTemplate
	public FDatasmithMeshSectionInfoMapTemplate SectionInfoMap;
	public int LightMapCoordinateIndex;
	public int LightMapResolution;
	public TArray<FDatasmithMeshBuildSettingsTemplate> BuildSettings;
	public TArray<FDatasmithStaticMaterialTemplate> StaticMaterials;
}
