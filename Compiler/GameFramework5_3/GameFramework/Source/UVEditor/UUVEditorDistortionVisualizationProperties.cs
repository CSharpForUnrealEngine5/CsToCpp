namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Visualization settings for the UUVEditorDistortionVisualization</summary>
[CppInclude("UVEditorDistortionVisualization.h")]
public partial class UUVEditorDistortionVisualizationProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Should the visualization be shown.</summary>
	public bool bVisible;
	///<summary>The specific metric used to classify and visualize distortion.</summary>
	public EDistortionMetric Metric;
	///<summary>bCompareToAverageDensity</summary>
	public bool bCompareToAverageDensity;
	///<summary>When computing average texel density, take into account specific UDIM tile resolutions for a more accurate representation</summary>
	public bool bRespectUDIMTextureResolutions;
	///<summary>MapSize</summary>
	public int MapSize;
	///<summary>TargetTexelDensity</summary>
	public float TargetTexelDensity;
	///<summary>PerUDIMTextureResolution</summary>
	public TMap<int,int> PerUDIMTextureResolution;
}
