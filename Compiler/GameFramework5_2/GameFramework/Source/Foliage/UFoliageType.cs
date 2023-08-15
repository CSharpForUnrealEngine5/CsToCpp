namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FoliageType.h")]
public partial class UFoliageType : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>A GUID that is updated every time the foliage type is modified,</summary>
	public FGuid UpdateGuid;
	///<summary>Foliage instances will be placed at this density, specified in instances per 1000x1000 unit area</summary>
	public float Density;
	///<summary>The factor by which to adjust the density of instances. Values &gt;1 will increase density while values &lt;1 will decrease it.</summary>
	public float DensityAdjustmentFactor;
	///<summary>The minimum distance between foliage instances</summary>
	public float Radius;
	///<summary>Option to override radius used to detect collision with other instances when painting in single instance mode</summary>
	public bool bSingleInstanceModeOverrideRadius;
	///<summary>The radius used in single instance mode to detect collision with other instances</summary>
	public float SingleInstanceModeRadius;
	///<summary>Specifies foliage instance scaling behavior when painting.</summary>
	public EFoliageScaling Scaling;
	///<summary>Specifies the range of scale, from minimum to maximum, to apply to a foliage instance&#39;s X Scale property</summary>
	public FFloatInterval ScaleX;
	///<summary>Specifies the range of scale, from minimum to maximum, to apply to a foliage instance&#39;s Y Scale property</summary>
	public FFloatInterval ScaleY;
	///<summary>Specifies the range of scale, from minimum to maximum, to apply to a foliage instance&#39;s Z Scale property</summary>
	public FFloatInterval ScaleZ;
	///<summary>VertexColorMaskByChannel</summary>
	public FFoliageVertexColorChannelMask VertexColorMaskByChannel;
	///<summary>When painting on static meshes, foliage instance placement can be limited to areas where the static mesh has values in the selected vertex color channel(s).</summary>
	public FoliageVertexColorMask VertexColorMask_DEPRECATED;
	///<summary>Specifies the threshold value above which the static mesh vertex color value must be, in order for foliage instances to be placed in a specific area</summary>
	public float VertexColorMaskThreshold_DEPRECATED;
	///<summary>When unchecked, foliage instances will be placed only when the vertex color in the specified channel(s) is above the threshold amount.</summary>
	public bool VertexColorMaskInvert_DEPRECATED;
	///<summary>Specifies a range from minimum to maximum of the offset to apply to a foliage instance&#39;s Z location</summary>
	public FFloatInterval ZOffset;
	///<summary>Whether foliage instances should have their angle adjusted away from vertical to match the normal of the surface they&#39;re painted on</summary>
	public bool AlignToNormal;
	///<summary>Will average normal based on Foliage Type base radius (this as a cost as it will do extra line traces)</summary>
	public bool AverageNormal;
	///<summary>Whether to discard normals originating from other hit components or not when averaging normals</summary>
	public bool AverageNormalSingleComponent;
	///<summary>The maximum angle in degrees that foliage instances will be adjusted away from the vertical</summary>
	public float AlignMaxAngle;
	///<summary>If selected, foliage instances will have a random yaw rotation around their vertical axis applied</summary>
	public bool RandomYaw;
	///<summary>A random pitch adjustment can be applied to each instance, up to the specified angle in degrees, from the original vertical</summary>
	public float RandomPitchAngle;
	///<summary>Foliage instances will only be placed on surfaces sloping in the specified angle range from the horizontal</summary>
	public FFloatInterval GroundSlopeAngle;
	///<summary>The valid altitude range where foliage instances will be placed, specified using minimum and maximum world coordinate Z values</summary>
	public FFloatInterval Height;
	///<summary>If layer names are specified, painting on landscape will limit the foliage to areas of landscape with the specified layers painted</summary>
	public TArray<FName> LandscapeLayers;
	///<summary>Specifies the minimum value above which the landscape layer weight value must be, in order for foliage instances to be placed in a specific area</summary>
	public float MinimumLayerWeight;
	///<summary>If layer names are specified, painting on landscape will exclude the foliage to areas of landscape without the specified layers painted</summary>
	public TArray<FName> ExclusionLandscapeLayers;
	///<summary>Specifies the minimum value above which the landscape exclusion layer weight value must be, in order for foliage instances to be excluded in a specific area</summary>
	public float MinimumExclusionLayerWeight;
	///<summary>LandscapeLayer_DEPRECATED</summary>
	public FName LandscapeLayer_DEPRECATED;
	///<summary>If checked, an overlap test with existing world geometry is performed before each instance is placed</summary>
	public bool CollisionWithWorld;
	///<summary>The foliage instance&#39;s collision bounding box will be scaled by the specified amount before performing the overlap check</summary>
	public FVector CollisionScale;
	///<summary>Line trace count to use around hit location when averaging normal</summary>
	public int AverageNormalSampleCount;
	///<summary>MeshBounds</summary>
	public FBoxSphereBounds MeshBounds;
	///<summary>X, Y is origin position and Z is radius...</summary>
	public FVector LowBoundOriginRadius;
	///<summary>Mobility property to apply to foliage components</summary>
	public EComponentMobility Mobility;
	///<summary>The distance where instances will begin to fade out if using a PerInstanceFadeAmount material node. 0 disables.</summary>
	public FInt32Interval CullDistance;
	///<summary>Deprecated. Now use the Mobility setting to control static/dynamic lighting</summary>
	public bool bEnableStaticLighting_DEPRECATED;
	///<summary>Controls whether the foliage should cast a shadow or not.</summary>
	public bool CastShadow;
	///<summary>Controls whether the foliage should inject light into the Light Propagation Volume.  This flag is only used if CastShadow is true.</summary>
	public bool bAffectDynamicIndirectLighting;
	///<summary>Controls whether the primitive should affect dynamic distance field lighting methods.  This flag is only used if CastShadow is true.</summary>
	public bool bAffectDistanceFieldLighting;
	///<summary>Controls whether the foliage should cast shadows in the case of non precomputed shadowing.  This flag is only used if CastShadow is true.</summary>
	public bool bCastDynamicShadow;
	///<summary>Whether the foliage should cast a static shadow from shadow casting lights.  This flag is only used if CastShadow is true.</summary>
	public bool bCastStaticShadow;
	///<summary>Whether the object should cast contact shadows. This flag is only used if CastShadow is true.</summary>
	public bool bCastContactShadow;
	///<summary>Whether this foliage should cast dynamic shadows as if it were a two sided material.</summary>
	public bool bCastShadowAsTwoSided;
	///<summary>Whether the foliage receives decals.</summary>
	public bool bReceivesDecals;
	///<summary>Whether to override the lightmap resolution defined in the static mesh.</summary>
	public bool bOverrideLightMapRes;
	///<summary>Overrides the lightmap resolution defined in the static mesh</summary>
	public int OverriddenLightMapRes;
	///<summary>Controls the type of lightmap used for this component.</summary>
	public ELightmapType LightmapType;
	///<summary>If enabled, foliage will render a pre-pass which allows it to occlude other primitives, and also allows</summary>
	public bool bUseAsOccluder;
	///<summary>bVisibleInRayTracing</summary>
	public bool bVisibleInRayTracing;
	///<summary>bEvaluateWorldPositionOffset</summary>
	public bool bEvaluateWorldPositionOffset;
	///<summary>WorldPositionOffsetDisableDistance</summary>
	public int WorldPositionOffsetDisableDistance;
	///<summary>Custom collision for foliage</summary>
	public FBodyInstance BodyInstance;
	///<summary>Force navmesh</summary>
	public EHasCustomNavigableGeometry CustomNavigableGeometry;
	///<summary>Lighting channels that placed foliage will be assigned. Lights with matching channels will affect the foliage.</summary>
	public FLightingChannels LightingChannels;
	///<summary>If true, the foliage will be rendered in the CustomDepth pass (usually used for outlines)</summary>
	public bool bRenderCustomDepth;
	///<summary>Mask used for stencil buffer writes.</summary>
	public ERendererStencilMask CustomDepthStencilWriteMask;
	///<summary>Optionally write this 0-255 value to the stencil buffer in CustomDepth pass (Requires project setting or r.CustomDepth == 3)</summary>
	public int CustomDepthStencilValue;
	///<summary>Translucent objects with a lower sort priority draw behind objects with a higher priority.</summary>
	public int TranslucencySortPriority;
	///<summary>Bitflag to represent in which editor views this foliage mesh is hidden.</summary>
	public ulong HiddenEditorViews;
	///<summary>IsSelected</summary>
	public bool IsSelected;
	///<summary>The CollisionRadius determines when two instances overlap. When two instances overlap a winner will be picked based on rules and priority.</summary>
	public float CollisionRadius;
	///<summary>The ShadeRadius determines when two instances overlap. If an instance can grow in the shade this radius is ignored.</summary>
	public float ShadeRadius;
	///<summary>The number of times we age the species and spread its seeds.</summary>
	public int NumSteps;
	///<summary>Specifies the number of seeds to populate along 10 meters. The number is implicitly squared to cover a 10m x 10m area</summary>
	public float InitialSeedDensity;
	///<summary>The average distance between the spreading instance and its seeds. For example, a tree with an AverageSpreadDistance 10 will ensure the average distance between the tree and its seeds is 10cm</summary>
	public float AverageSpreadDistance;
	///<summary>Specifies how much seed distance varies from the average. For example, a tree with an AverageSpreadDistance 10 and a SpreadVariance 1 will produce seeds with an average distance of 10cm plus or minus 1cm</summary>
	public float SpreadVariance;
	///<summary>The number of seeds an instance will spread in a single step of the simulation.</summary>
	public int SeedsPerStep;
	///<summary>The seed that determines placement of initial seeds.</summary>
	public int DistributionSeed;
	///<summary>The seed that determines placement of initial seeds.</summary>
	public float MaxInitialSeedOffset;
	///<summary>If true, seeds of this type will ignore shade radius during overlap tests with other types.</summary>
	public bool bCanGrowInShade;
	///<summary>Whether new seeds are spawned exclusively in shade. Occurs in a second pass after all types that do not spawn in shade have been simulated.</summary>
	public bool bSpawnsInShade;
	///<summary>Allows a new seed to be older than 0 when created. New seeds will be randomly assigned an age in the range [0,MaxInitialAge]</summary>
	public float MaxInitialAge;
	///<summary>Specifies the oldest a seed can be. After reaching this age the instance will still spread seeds, but will not get any older</summary>
	public float MaxAge;
	///<summary>When two instances overlap we must determine which instance to remove.</summary>
	public float OverlapPriority;
	///<summary>The scale range of this type when being procedurally generated. Configured with the Scale Curve.</summary>
	public FFloatInterval ProceduralScale;
	///<summary>Instance scale factor as a function of normalized age (i.e. Current Age / Max Age).</summary>
	public FRuntimeFloatCurve ScaleCurve;
	///<summary>DensityFalloff</summary>
	public FFoliageDensityFalloff DensityFalloff;
	///<summary>ChangeCount</summary>
	public int ChangeCount;
	///<summary>If checked, the density of foliage instances already placed will be adjusted by the density adjustment factor.</summary>
	public bool ReapplyDensity;
	///<summary>If checked, foliage instances not meeting the new Radius constraint will be removed</summary>
	public bool ReapplyRadius;
	///<summary>If checked, foliage instances will have their normal alignment adjusted by the Reapply tool</summary>
	public bool ReapplyAlignToNormal;
	///<summary>If checked, foliage instances will have their yaw adjusted by the Reapply tool</summary>
	public bool ReapplyRandomYaw;
	///<summary>If checked, foliage instances will have their scale adjusted to fit the specified scaling behavior by the Reapply tool</summary>
	public bool ReapplyScaling;
	///<summary>If checked, foliage instances will have their X scale adjusted by the Reapply tool</summary>
	public bool ReapplyScaleX;
	///<summary>If checked, foliage instances will have their Y scale adjusted by the Reapply tool</summary>
	public bool ReapplyScaleY;
	///<summary>If checked, foliage instances will have their Z scale adjusted by the Reapply tool</summary>
	public bool ReapplyScaleZ;
	///<summary>If checked, foliage instances will have their pitch adjusted by the Reapply tool</summary>
	public bool ReapplyRandomPitchAngle;
	///<summary>If checked, foliage instances not meeting the ground slope condition will be removed by the Reapply too</summary>
	public bool ReapplyGroundSlope;
	///<summary>If checked, foliage instances not meeting the valid Z height condition will be removed by the Reapply tool</summary>
	public bool ReapplyHeight;
	///<summary>If checked, foliage instances painted on areas that do not have the appropriate landscape layer painted will be removed by the Reapply tool</summary>
	public bool ReapplyLandscapeLayers;
	///<summary>If checked, foliage instances will have their Z offset adjusted by the Reapply tool</summary>
	public bool ReapplyZOffset;
	///<summary>If checked, foliage instances will have an overlap test with the world reapplied, and overlapping instances will be removed by the Reapply tool</summary>
	public bool ReapplyCollisionWithWorld;
	///<summary>If checked, foliage instances no longer matching the vertex color constraint will be removed by the Reapply too</summary>
	public bool ReapplyVertexColorMask;
	///<summary>Whether this foliage type should be affected by the Engine Scalability system&#39;s Foliage scalability setting.</summary>
	public bool bEnableDensityScaling;
	///<summary>Whether this foliage type should be discarded when CVarFoliageDiscardDataOnLoad is enabled.</summary>
	public bool bEnableDiscardOnLoad;
	///<summary>* Whether this foliage type should be affected by the Engine&#39;s &quot;foliage.CullDistanceScale&quot; setting</summary>
	public bool bEnableCullDistanceScaling;
	///<summary>Array of runtime virtual textures into which we draw the instances.</summary>
	public TArray<URuntimeVirtualTexture> RuntimeVirtualTextures;
	///<summary>Number of lower mips in the runtime virtual texture to skip for rendering this primitive.</summary>
	public int VirtualTextureCullMips;
	///<summary>Controls if this component draws in the main pass as well as in the virtual texture.</summary>
	public ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType;
	///<summary>bIncludeInHLOD</summary>
	public bool bIncludeInHLOD;
	///<summary>Deprecated since FFoliageCustomVersion::FoliageTypeCustomization</summary>
	public float ScaleMinX_DEPRECATED;
	///<summary>ScaleMinY_DEPRECATED</summary>
	public float ScaleMinY_DEPRECATED;
	///<summary>ScaleMinZ_DEPRECATED</summary>
	public float ScaleMinZ_DEPRECATED;
	///<summary>ScaleMaxX_DEPRECATED</summary>
	public float ScaleMaxX_DEPRECATED;
	///<summary>ScaleMaxY_DEPRECATED</summary>
	public float ScaleMaxY_DEPRECATED;
	///<summary>ScaleMaxZ_DEPRECATED</summary>
	public float ScaleMaxZ_DEPRECATED;
	///<summary>HeightMin_DEPRECATED</summary>
	public float HeightMin_DEPRECATED;
	///<summary>HeightMax_DEPRECATED</summary>
	public float HeightMax_DEPRECATED;
	///<summary>ZOffsetMin_DEPRECATED</summary>
	public float ZOffsetMin_DEPRECATED;
	///<summary>ZOffsetMax_DEPRECATED</summary>
	public float ZOffsetMax_DEPRECATED;
	///<summary>StartCullDistance_DEPRECATED</summary>
	public int StartCullDistance_DEPRECATED;
	///<summary>EndCullDistance_DEPRECATED</summary>
	public int EndCullDistance_DEPRECATED;
	///<summary>UniformScale_DEPRECATED</summary>
	public bool UniformScale_DEPRECATED;
	///<summary>LockScaleX_DEPRECATED</summary>
	public bool LockScaleX_DEPRECATED;
	///<summary>LockScaleY_DEPRECATED</summary>
	public bool LockScaleY_DEPRECATED;
	///<summary>LockScaleZ_DEPRECATED</summary>
	public bool LockScaleZ_DEPRECATED;
	///<summary>GroundSlope_DEPRECATED</summary>
	public float GroundSlope_DEPRECATED;
	///<summary>MinGroundSlope_DEPRECATED</summary>
	public float MinGroundSlope_DEPRECATED;
	///<summary>MinScale_DEPRECATED</summary>
	public float MinScale_DEPRECATED;
	///<summary>MaxScale_DEPRECATED</summary>
	public float MaxScale_DEPRECATED;
}
