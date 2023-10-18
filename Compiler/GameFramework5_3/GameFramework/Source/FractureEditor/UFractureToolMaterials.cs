namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolMaterials.h")]
public partial class UFractureToolMaterials : UFractureModalTool {
	public static UClass StaticClass() {return default;}
	///<summary>MaterialsSettings</summary>
	public UFractureMaterialsSettings MaterialsSettings;
	///<summary>Track the geometry collection asset last used to populate the materials list, if any</summary>
	public TWeakObjectPtr<UGeometryCollectionComponent> ActiveSelectedComponent;
}
