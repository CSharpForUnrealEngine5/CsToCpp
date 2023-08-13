namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraRibbonRendererProperties.h")]
public partial class UNiagaraRibbonRendererProperties : UNiagaraRendererProperties {
	public static UClass StaticClass() {return default;}
	///<summary>UNiagaraRendererProperties Interface END</summary>
	public UMaterialInterface Material;
	///<summary>MICMaterial</summary>
	public UMaterialInstanceConstant MICMaterial;
	///<summary>Use the UMaterialInterface bound to this user variable if it is set to a valid value. If this is bound to a valid value and Material is also set, UserParamBinding wins.</summary>
	public FNiagaraUserParameterBinding MaterialUserParamBinding;
	///<summary>FacingMode</summary>
	public ENiagaraRibbonFacingMode FacingMode;
	///<summary>UV0Settings</summary>
	public FNiagaraRibbonUVSettings UV0Settings;
	///<summary>UV1Settings</summary>
	public FNiagaraRibbonUVSettings UV1Settings;
	///<summary>Tiles UV0 based on the distance traversed by the ribbon. Disables offsetting UVs by age.</summary>
	public float UV0TilingDistance_DEPRECATED;
	///<summary>UV0Scale_DEPRECATED</summary>
	public FVector2D UV0Scale_DEPRECATED;
	///<summary>UV0Offset_DEPRECATED</summary>
	public FVector2D UV0Offset_DEPRECATED;
	///<summary>Defines the mode to use when offsetting UV channel 0 by age which enables smooth texture movement when particles are added and removed at the end of the ribbon.  Not used when the RibbonLinkOrder binding is in use or when tiling distance is in use.</summary>
	public ENiagaraRibbonAgeOffsetMode UV0AgeOffsetMode_DEPRECATED;
	///<summary>Tiles UV1 based on the distance traversed by the ribbon. Disables offsetting UVs by age.</summary>
	public float UV1TilingDistance_DEPRECATED;
	///<summary>UV1Scale_DEPRECATED</summary>
	public FVector2D UV1Scale_DEPRECATED;
	///<summary>UV1Offset_DEPRECATED</summary>
	public FVector2D UV1Offset_DEPRECATED;
	///<summary>Defines the mode to use when offsetting UV channel 1 by age which enables smooth texture movement when particles are added and removed at the end of the ribbon.  Not used when the RibbonLinkOrder binding is in use or when tiling distance is in use.</summary>
	public ENiagaraRibbonAgeOffsetMode UV1AgeOffsetMode_DEPRECATED;
	///<summary>MaxNumRibbons</summary>
	public int MaxNumRibbons;
	///<summary>Whether we use the CPU or GPU to generate ribbon geometry for CPU systems.</summary>
	public bool bUseGPUInit;
	///<summary>If true, the particles are only sorted when using a translucent material.</summary>
	public ENiagaraRibbonDrawDirection DrawDirection;
	///<summary>Shape of the ribbon, from flat plane, multiplane, 3d tube, and custom shapes.</summary>
	public ENiagaraRibbonShapeMode Shape;
	///<summary>Disables two-sided forced rendering (Will still respect material settings)</summary>
	public bool bEnableAccurateGeometry;
	///<summary>Tessellation factor to apply to the width of the ribbon.</summary>
	public int WidthSegmentationCount;
	///<summary>Number of planes in multiplane shape. Evenly distributed from 0-90 or 0-180 degrees off camera facing depending on setting</summary>
	public int MultiPlaneCount;
	///<summary>Number of vertices/faces in a tube.</summary>
	public int TubeSubdivisions;
	///<summary>Vertices for a cross section of the ribbon in custom shape mode.</summary>
	public TArray<FNiagaraRibbonShapeCustomVertex> CustomVertices;
	///<summary>Defines the tessellation mode allowing custom tessellation parameters or disabling tessellation entirely.</summary>
	public ENiagaraRibbonTessellationMode TessellationMode;
	///<summary>Defines the curve tension, or how long the curve&#39;s tangents are.</summary>
	public float CurveTension;
	///<summary>Custom tessellation factor.</summary>
	public int TessellationFactor;
	///<summary>If checked, use the above constant factor. Otherwise, adaptively select the tessellation factor based on the below parameters.</summary>
	public bool bUseConstantFactor;
	///<summary>Defines the angle in degrees at which tessellation occurs.</summary>
	public float TessellationAngle;
	///<summary>If checked, use the ribbon&#39;s screen space percentage to adaptively adjust the tessellation factor.</summary>
	public bool bScreenSpaceTessellation;
	///<summary>Which attribute should we use for position when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding PositionBinding;
	///<summary>Which attribute should we use for color when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding ColorBinding;
	///<summary>Which attribute should we use for velocity when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding VelocityBinding;
	///<summary>Which attribute should we use for normalized age when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding NormalizedAgeBinding;
	///<summary>Which attribute should we use for ribbon twist when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding RibbonTwistBinding;
	///<summary>Which attribute should we use for ribbon width when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding RibbonWidthBinding;
	///<summary>Which attribute should we use for ribbon facing when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding RibbonFacingBinding;
	///<summary>Which attribute should we use for ribbon id when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding RibbonIdBinding;
	///<summary>Which attribute should we use for RibbonLinkOrder when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding RibbonLinkOrderBinding;
	///<summary>Which attribute should we use for MaterialRandom when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding MaterialRandomBinding;
	///<summary>Which attribute should we use for dynamic material parameters when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding DynamicMaterialBinding;
	///<summary>Which attribute should we use for dynamic material parameters when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding DynamicMaterial1Binding;
	///<summary>Which attribute should we use for dynamic material parameters when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding DynamicMaterial2Binding;
	///<summary>Which attribute should we use for dynamic material parameters when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding DynamicMaterial3Binding;
	///<summary>Which attribute should we use for ribbon distance traveled for use in UV operations when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding RibbonUVDistance;
	///<summary>Which attribute should we use for UV0 U when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding U0OverrideBinding;
	///<summary>Which attribute should we use for UV0 V when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding V0RangeOverrideBinding;
	///<summary>Which attribute should we use for UV1 U when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding U1OverrideBinding;
	///<summary>Which attribute should we use for UV1 V when generating ribbons?</summary>
	public FNiagaraVariableAttributeBinding V1RangeOverrideBinding;
	///<summary>If this array has entries, we will create a MaterialInstanceDynamic per Emitter instance from Material and set the Material parameters using the Niagara simulation variables listed.</summary>
	public FNiagaraRendererMaterialParameters MaterialParameters;
	///<summary>MaterialParameterBindings_DEPRECATED</summary>
	public TArray<FNiagaraMaterialAttributeBinding> MaterialParameterBindings_DEPRECATED;
	///<summary>Implicit binding for previous position</summary>
	public FNiagaraVariableAttributeBinding PrevPositionBinding;
	///<summary>Implicit binding for previous ribbon width</summary>
	public FNiagaraVariableAttributeBinding PrevRibbonWidthBinding;
	///<summary>Implicit binding for previous ribbon facing</summary>
	public FNiagaraVariableAttributeBinding PrevRibbonFacingBinding;
	///<summary>Implicit binding for previous ribbon twist</summary>
	public FNiagaraVariableAttributeBinding PrevRibbonTwistBinding;
}
