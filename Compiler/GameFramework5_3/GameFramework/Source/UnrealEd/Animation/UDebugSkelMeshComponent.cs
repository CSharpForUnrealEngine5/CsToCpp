namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/DebugSkelMeshComponent.h")]
public partial class UDebugSkelMeshComponent : USkeletalMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Global drawing mode for this skeleton. Depends on context of specific editor using the component.</summary>
	public ESkeletonDrawMode SkeletonDrawMode;
	///<summary>If true then the skeletal mesh associated with the component is drawn.</summary>
	public bool bDrawMesh;
	///<summary>If true then the bone names associated with the skeletal mesh are displayed</summary>
	public bool bShowBoneNames;
	///<summary>Bone influences viewing</summary>
	public bool bDrawBoneInfluences;
	///<summary>Morphtarget viewing</summary>
	public bool bDrawMorphTargetVerts;
	///<summary>Vertex normal viewing</summary>
	public bool bDrawNormals;
	///<summary>Vertex tangent viewing</summary>
	public bool bDrawTangents;
	///<summary>Vertex binormal viewing</summary>
	public bool bDrawBinormals;
	///<summary>Socket hit points viewing</summary>
	public bool bDrawSockets;
	///<summary>Attribute visualization</summary>
	public bool bDrawAttributes;
	///<summary>Skeleton sockets visible?</summary>
	public bool bSkeletonSocketsVisible;
	///<summary>Mesh sockets visible?</summary>
	public bool bMeshSocketsVisible;
	///<summary>Display raw animation bone transform</summary>
	public bool bDisplayRawAnimation;
	///<summary>Display non retargeted animation pose</summary>
	public bool bDisplayNonRetargetedPose;
	///<summary>Display additive base bone transform</summary>
	public bool bDisplayAdditiveBasePose;
	///<summary>Display baked animation pose</summary>
	public bool bDisplayBakedAnimation;
	///<summary>Display source animation pose</summary>
	public bool bDisplaySourceAnimation;
	///<summary>Display Bound *</summary>
	public bool bDisplayBound;
	///<summary>bDisplayVertexColors</summary>
	public bool bDisplayVertexColors;
	///<summary>WireframeMeshOverlayColor</summary>
	public FLinearColor WireframeMeshOverlayColor;
	///<summary>bPreviewRootMotion_DEPRECATED</summary>
	public bool bPreviewRootMotion_DEPRECATED;
	///<summary>Process root motion mode</summary>
	public EProcessRootMotionMode ProcessRootMotionMode;
	///<summary>Playback time last time ConsumeRootmotion was called</summary>
	public float ConsumeRootMotionPreviousPlaybackTime;
	///<summary>bShowClothData</summary>
	public bool bShowClothData;
	///<summary>MinClothPropertyView</summary>
	public float MinClothPropertyView;
	///<summary>MaxClothPropertyView</summary>
	public float MaxClothPropertyView;
	///<summary>ClothMeshOpacity</summary>
	public float ClothMeshOpacity;
	///<summary>bClothFlipNormal</summary>
	public bool bClothFlipNormal;
	///<summary>bClothCullBackface</summary>
	public bool bClothCullBackface;
	///<summary>bRequiredBonesUpToDateDuringTick</summary>
	public bool bRequiredBonesUpToDateDuringTick;
	///<summary>Multiplier for the bone radius rendering</summary>
	public float BoneRadiusMultiplier;
	///<summary>Array of bones to render bone weights for</summary>
	public TArray<int> BonesOfInterest;
	///<summary>Array of morphtargets to render verts for</summary>
	public TArray<UMorphTarget> MorphTargetOfInterests;
	///<summary>Array of materials to restore when not rendering blend weights</summary>
	public TArray<UMaterialInterface> SkelMaterials;
	///<summary>PreviewInstance</summary>
	public UAnimPreviewInstance PreviewInstance;
	///<summary>SavedAnimScriptInstance</summary>
	public UAnimInstance SavedAnimScriptInstance;
	///<summary>Does this component use in game bounds or does it use bounds calculated from bones</summary>
	public bool bIsUsingInGameBounds;
	///<summary>Does this component use pre-skinned bounds? This overrides other bounds settings</summary>
	public bool bIsUsingPreSkinnedBounds;
	///<summary>Base skel mesh has support for suspending clothing, but single ticks are more of a debug feature when stepping through an animation</summary>
	public bool bPerformSingleClothingTick;
	///<summary>bPauseClothingSimulationWithAnim</summary>
	public bool bPauseClothingSimulationWithAnim;
	///<summary>Should the LOD of the debug mesh component track the LOD of the instance being debugged</summary>
	public bool bTrackAttachedInstanceLOD;
}
