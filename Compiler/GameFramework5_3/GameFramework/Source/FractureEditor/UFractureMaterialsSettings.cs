namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings related to setting materials on a Geometry Collection *</summary>
[CppInclude("FractureToolMaterials.h")]
public partial class UFractureMaterialsSettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Geometry Collection selected for editing</summary>
	public string EditingCollection;
	///<summary>Materials on the selected Geometry Collection&#39;s underlying asset (the Rest Collection).</summary>
	public TArray<UMaterialInterface> Materials;
	///<summary>Add a new material slot to the selected geometry collections</summary>
	public void AddMaterialSlot() {}
	///<summary>Remove the last material slot from the selected Geometry Collections. (Will not remove the final material.)</summary>
	public void RemoveMaterialSlot() {}
	///<summary>Clear material overrides on components using this asset, so the asset materials are used</summary>
	public void UseAssetMaterialsOnComponents() {}
	///<summary>Whether &#39;Use Asset Materials On Components&#39; should only update the selected components, or update all components using this asset</summary>
	public bool bOnlySelectedComponents;
	///<summary>Material to assign to selected faces</summary>
	public string AssignMaterial;
	///<summary>Which subset of faces to update materials assignments on, for the selected geometry</summary>
	public EMaterialAssignmentTargets ToFaces;
	///<summary>Whether to only assign materials for faces in the selected bones, or the whole geometry collection</summary>
	public bool bOnlySelectedBones;
	///<summary>GetMaterialNamesFunc</summary>
	public TArray<string> GetMaterialNamesFunc() { return default; }
	///<summary>bHaveTargetCollection</summary>
	public bool bHaveTargetCollection;
	///<summary>AssignMaterialNamesList</summary>
	public TArray<string> AssignMaterialNamesList;
}
