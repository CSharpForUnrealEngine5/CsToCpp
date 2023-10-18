namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The vizualization settings specific to the UMLDeformerMorphModel class, or inherited classes.</summary>
[CppInclude("MLDeformerMorphModelVizSettings.h")]
public partial class UMLDeformerMorphModelVizSettings : UMLDeformerGeomCacheVizSettings {
	public static UClass StaticClass() {return default;}
	///<summary>The morph target delta threshold. This is a preview of what deltas would be included in the selected morph target</summary>
	public float MorphTargetDeltaThreshold_DEPRECATED;
	///<summary>The morph target to visualize. The first one always being the means, so not a sparse target.</summary>
	public int MorphTargetNumber;
	///<summary>Specify whether we want to debug draw the morph targets.</summary>
	public bool bDrawMorphTargets;
}
