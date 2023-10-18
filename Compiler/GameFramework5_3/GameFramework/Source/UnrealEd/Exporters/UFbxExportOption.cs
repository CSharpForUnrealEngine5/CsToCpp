namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Exporters/FbxExportOption.h")]
public partial class UFbxExportOption : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>This will set the fbx sdk compatibility when exporting to fbx file. The default value is 2013</summary>
	public EFbxExportCompatibility FbxExportCompatibility;
	///<summary>If enabled, save as ascii instead of binary</summary>
	public bool bASCII;
	///<summary>If enabled, export with X axis as the front axis instead of default -Y</summary>
	public bool bForceFrontXAxis;
	///<summary>If enabled, export vertex color</summary>
	public bool VertexColor;
	///<summary>If enabled, export the level of detail</summary>
	public bool LevelOfDetail;
	///<summary>If enabled, export collision</summary>
	public bool Collision;
	///<summary>* If enabled, export the highest LOD source data instead of the render data.</summary>
	public bool bExportSourceMesh;
	///<summary>If enabled, export the morph targets</summary>
	public bool bExportMorphTargets;
	///<summary>If enable, the preview mesh link to the exported animations will be also exported.</summary>
	public bool bExportPreviewMesh;
	///<summary>If enable, Map skeletal actor motion to the root bone of the skeleton.</summary>
	public bool MapSkeletalMotionToRoot;
	///<summary>If enabled, export sequencer animation in its local time, relative to its sequence.</summary>
	public bool bExportLocalTime;
}
