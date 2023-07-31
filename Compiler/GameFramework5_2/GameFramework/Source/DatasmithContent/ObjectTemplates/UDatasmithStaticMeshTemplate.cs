#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectTemplates/DatasmithStaticMeshTemplate.h")]
public partial class UDatasmithStaticMeshTemplate : UDatasmithObjectTemplate {
	///<summary>SectionInfoMap</summary>
	public FDatasmithMeshSectionInfoMapTemplate SectionInfoMap;
	///<summary>LightMapCoordinateIndex</summary>
	public int LightMapCoordinateIndex;
	///<summary>LightMapResolution</summary>
	public int LightMapResolution;
	///<summary>BuildSettings</summary>
	public TArray<FDatasmithMeshBuildSettingsTemplate> BuildSettings;
	///<summary>StaticMaterials</summary>
	public TArray<FDatasmithStaticMaterialTemplate> StaticMaterials;
}
