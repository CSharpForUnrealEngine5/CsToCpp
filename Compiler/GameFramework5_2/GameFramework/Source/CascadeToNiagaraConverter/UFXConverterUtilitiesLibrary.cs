#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
///<summary>A C++ and Blueprint accessible library for converting fx type assets (Cascade and Niagara)</summary>
public partial class UFXConverterUtilitiesLibrary : UBlueprintFunctionLibrary {
// FXConverterUtilitiesLibrary
	public static string GetLongPackagePath(string InLongPackageName) { return default; }
	public static TArray<UParticleEmitter> GetCascadeSystemEmitters(UParticleSystem System) { return default; }
	public static UParticleLODLevel GetCascadeEmitterLodLevel(UParticleEmitter Emitter,int Idx) { return default; }
	public static bool GetLodLevelIsEnabled(UParticleLODLevel LodLevel) { return default; }
	public static TArray<UParticleModule> GetLodLevelModules(UParticleLODLevel LodLevel) { return default; }
	public static UParticleModuleSpawn GetLodLevelSpawnModule(UParticleLODLevel LodLevel) { return default; }
	public static UParticleModuleRequired GetLodLevelRequiredModule(UParticleLODLevel LodLevel) { return default; }
	public static UParticleModuleTypeDataBase GetLodLevelTypeDataModule(UParticleLODLevel LodLevel) { return default; }
	public static string GetCascadeEmitterName(UParticleEmitter Emitter) { return default; }
	public static UNiagaraScriptConversionContext CreateScriptContext(FCreateScriptContextArgs Args) { return default; }
	public static FAssetData CreateAssetData(string InPath) { return default; }
	public static UNiagaraScriptConversionContextInput CreateScriptInputLinkedParameter(string ParameterNameString,ENiagaraScriptInputType InputType) { return default; }
	public static UNiagaraScriptConversionContextInput CreateScriptInputFloat(float Value) { return default; }
	public static UNiagaraScriptConversionContextInput CreateScriptInputVec2(FVector2D Value) { return default; }
	public static UNiagaraScriptConversionContextInput CreateScriptInputVector(FVector Value) { return default; }
	public static UNiagaraScriptConversionContextInput CreateScriptInputStruct(UUserDefinedStruct Value) { return default; }
	public static UNiagaraScriptConversionContextInput CreateScriptInputEnum(string UserDefinedEnumAssetPath,string UserDefinedEnumValueNameString) { return default; }
	public static UNiagaraScriptConversionContextInput CreateScriptInputInt(int Value) { return default; }
	public static UNiagaraScriptConversionContextInput CreateScriptInputDynamic(UNiagaraScriptConversionContext Value,ENiagaraScriptInputType InputType) { return default; }
	public static UNiagaraScriptConversionContextInput CreateScriptInputDI(UNiagaraDataInterface Value) { return default; }
	public static UNiagaraScriptConversionContextInput CreateScriptInputBool(bool Value) { return default; }
	public static UNiagaraRibbonRendererProperties CreateRibbonRendererProperties() { return default; }
	public static UNiagaraMeshRendererProperties CreateMeshRendererProperties() { return default; }
	public static UNiagaraLightRendererProperties CreateLightRendererProperties() { return default; }
	public static UNiagaraComponentRendererProperties CreateComponentRendererProperties() { return default; }
	public static UNiagaraDataInterfaceSkeletalMesh CreateSkeletalMeshDataInterface() { return default; }
	public static UNiagaraDataInterfaceCurve CreateFloatCurveDI(TArray<FRichCurveKeyBP> Keys) { return default; }
	public static UNiagaraDataInterfaceVector2DCurve CreateVec2CurveDI(TArray<FRichCurveKeyBP> X_Keys,TArray<FRichCurveKeyBP> Y_Keys) { return default; }
	public static UNiagaraDataInterfaceVectorCurve CreateVec3CurveDI(TArray<FRichCurveKeyBP> X_Keys,TArray<FRichCurveKeyBP> Y_Keys,TArray<FRichCurveKeyBP> Z_Keys) { return default; }
	public static UNiagaraDataInterfaceVector4Curve CreateVec4CurveDI(TArray<FRichCurveKeyBP> X_Keys,TArray<FRichCurveKeyBP> Y_Keys,TArray<FRichCurveKeyBP> Z_Keys,TArray<FRichCurveKeyBP> W_Keys) { return default; }
	public static UNiagaraSystemConversionContext CreateSystemConversionContext(UNiagaraSystem InSystem) { return default; }
	public static void GetParticleModuleTypeDataGpuProps(UParticleModuleTypeDataGpu ParticleModule) {}
	public static void GetParticleModuleTypeDataMeshProps(UParticleModuleTypeDataMesh ParticleModule,UStaticMesh OutMesh,float OutLODSizeScale,bool bOutUseStaticMeshLODs,bool bOutCastShadows,bool bOutDoCollisions,byte OutMeshAlignment,bool bOutOverrideMaterial,bool bOutOverrideDefaultMotionBlurSettings,bool bOutEnableMotionBlur,UDistribution OutRollPitchYawRange,byte OutAxisLockOption,bool bOutCameraFacing,byte OutCameraFacingUpAxisOption_DEPRECATED,byte OutCameraFacingOption,bool bOutApplyParticleRotationAsSpin,bool bOutFacingCameraDirectionRatherThanPosition,bool bOutCollisionsConsiderParticleSize) {}
	public static UClass GetParticleModuleTypeDataRibbonClass() { return default; }
	public static void GetParticleModuleTypeDataRibbonProps(UParticleModuleTypeDataRibbon ParticleModule,int OutMaxTessellationBetweenParticles,int OutSheetsPerTrail,int OutMaxTrailCount,int OutMaxParticleInTrailCount,bool bOutDeadTrailsOnDeactivate,bool bOutClipSourceSegment,bool bOutEnablePreviousTangentRecalculation,bool bOutTangentRecalculationEveryFrame,bool bOutSpawnInitialParticle,byte OutRenderAxis,float OutTangentSpawningScalar,bool bOutRenderGeometry,bool bOutRenderSpawnPoints,bool bOutRenderTangents,bool bOutRenderTessellation,float OutTilingDistance,float OutDistanceTessellationStepSize,bool bOutEnableTangentDiffInterpScale,float OutTangentTessellationScalar) {}
	public static void GetParticleModuleSpawnProps(UParticleModuleSpawn ParticleModuleSpawn,UDistribution OutRate,UDistribution OutRateScale,byte OutBurstMethod,TArray<FParticleBurstBlueprint> OutBurstList,UDistribution OutBurstScale,bool bOutApplyGlobalSpawnRateScale,bool bOutProcessSpawnRate,bool bOutProcessSpawnBurst) {}
	public static void GetParticleModuleSpawnPerUnitProps(UParticleModuleSpawnPerUnit ParticleModule,float OutUnitScalar,float OutMovementTolerance,UDistribution OutSpawnPerUnit,float OutMaxFrameDistance,bool bOutIgnoreSpawnRateWhenMoving,bool bOutIgnoreMovementAlongX,bool bOutIgnoreMovementAlongY,bool bOutIgnoreMovementAlongZ,bool bOutProcessSpawnRate,bool bOutProcessBurstList) {}
	public static void GetParticleModuleRequiredPerRendererProps(UParticleModuleRequired ParticleModuleRequired,UMaterialInterface OutMaterialInterface,byte OutScreenAlignment,int OutSubImages_Horizontal,int OutSubImages_Vertical,byte OutSortMode,byte OutInterpolationMethod,byte bOutRemoveHMDRoll,float OutMinFacingCameraBlendDistance,float OutMaxFacingCameraBlendDistance,UTexture2D OutCutoutTexture,byte OutBoundingMode,byte OutOpacitySourceMode,byte OutEmitterNormalsMode,float OutAlphaThreshold) {}
	public static void GetParticleModuleRequiredPerModuleProps(UParticleModuleRequired ParticleModuleRequired,bool bOutOrbitModuleAffectsVelocityAlignment,float OutRandomImageTime,int OutRandomImageChanges,bool bOutOverrideSystemMacroUV,FVector OutMacroUVPosition,float OutMacroUVRadius) {}
	public static void GetParticleModuleRequiredPerEmitterProps(UParticleModuleRequired ParticleModuleRequired,FVector OutEmitterOrigin,FRotator OutEmitterRotation,bool bOutUseLocalSpace,bool bOutKillOnDeactivate,bool bOutKillOnCompleted,bool bOutUseLegacyEmitterTime,bool bOutEmitterDurationUseRange,float OutEmitterDuration,float OutEmitterDurationLow,bool bOUtEmitterDelayUseRange,bool bOutDelayFirstLoopOnly,float OutEmitterDelay,float OutEmitterDelayLow,bool bOutDurationRecalcEachLoop,int OutEmitterLoops) {}
	public static void GetParticleModuleColorProps(UParticleModuleColor ParticleModule,UDistribution OutStartColor,UDistribution OutStartAlpha,bool bOutClampAlpha) {}
	public static void GetParticleModuleColorOverLifeProps(UParticleModuleColorOverLife ParticleModule,UDistribution OutColorOverLife,UDistribution OutAlphaOverLife,bool bOutClampAlpha) {}
	public static void GetParticleModuleLifetimeProps(UParticleModuleLifetime ParticleModule,UDistribution OutLifetime) {}
	public static void GetParticleModuleSizeProps(UParticleModuleSize ParticleModule,UDistribution OutStartSize) {}
	public static void GetParticleModuleVelocityProps(UParticleModuleVelocity ParticleModule,UDistribution OutStartVelocity,UDistribution OutStartVelocityRadial,bool bOutInWorldSpace,bool bOutApplyOwnerScale) {}
	public static void GetParticleModuleVelocityOverLifetimeProps(UParticleModuleVelocityOverLifetime ParticleModule,UDistribution OutVelOverLife,bool bOutAbsolute,bool bOutInWorldSpace,bool bOutApplyOwnerScale) {}
	public static void GetParticleModuleConstantAccelerationProps(UParticleModuleAccelerationConstant ParticleModule,FVector OutConstAcceleration) {}
	public static void GetParticleModuleLocationPrimitiveSphereProps(UParticleModuleLocationPrimitiveSphere ParticleModule,UDistribution OutStartRadius,bool bOutPositiveX,bool bOutPositiveY,bool bOutPositiveZ,bool bOutNegativeX,bool bOutNegativeY,bool bOutNegativeZ,bool bOutSurfaceOnly,bool bOutVelocity,UDistribution OutVelocityScale,UDistribution OutStartLocation) {}
	public static void GetParticleModuleLocationPrimitiveCylinderProps(UParticleModuleLocationPrimitiveCylinder ParticleModule,bool bOutRadialVelocity,UDistribution OutStartRadius,UDistribution OutStartHeight,byte OutHeightAxis,bool bOutPositiveX,bool bOutPositiveY,bool bOutPositiveZ,bool bOutNegativeX,bool bOutNegativeY,bool bOutNegativeZ,bool bOutSurfaceOnly,bool bOutVelocity,UDistribution OutVelocityScale,UDistribution OutStartLocation) {}
	public static void GetParticleModuleOrientationAxisLockProps(UParticleModuleOrientationAxisLock ParticleModule,byte OutLockAxisFlags) {}
	public static void GetParticleModuleVelocityInheritParentProps(UParticleModuleVelocityInheritParent ParticleModule,UDistribution OutScale,bool bOutInWorldSpace,bool bOutApplyOwnerScale) {}
	public static void GetParticleModuleMeshRotationProps(UParticleModuleMeshRotation ParticleModule,UDistribution OutStartRotation,bool bOutInheritParentRotation) {}
	public static void GetParticleModuleCollisionProps(UParticleModuleCollision ParticleModule,UDistribution OutDampingFactor,UDistribution OutDampingFactorRotation,UDistribution OutMaxCollisions,byte OutCollisionCompleteOption,TArray<byte> OutCollisionTypes,bool bOutApplyPhysics,bool bOutIgnoreTriggerVolumes,UDistribution OutParticleMass,float OutDirScalar,bool bOutPawnsDoNotDecrementCount,bool bOutOnlyVerticalNormalsDecrementCount,float OutVerticalFudgeFactor,UDistribution OutDelayAmount,bool bOutDropDetail,bool bOutCollideOnlyIfVisible,bool bOutIgnoreSourceActor,float OutMaxCollisionDistance) {}
	public static void GetParticleModuleSizeScaleProps(UParticleModuleSizeScale ParticleModule,UDistribution OutSizeScale) {}
	public static void GetParticleModuleSizeScaleBySpeedProps(UParticleModuleSizeScaleBySpeed ParticleModule,FVector2D OutSpeedScale,FVector2D OutMaxScale) {}
	public static void GetParticleModuleVectorFieldLocalProps(UParticleModuleVectorFieldLocal ParticleModule,UVectorField OutVectorField,FVector OutRelativeTranslation,FRotator OutRelativeRotation,FVector OutRelativeScale3D,float OutIntensity,float OutTightness,bool bOutIgnoreComponentTransform,bool bOutTileX,bool bOutTileY,bool bOutTileZ,bool bOutUseFixDT) {}
	public static void GetParticleModuleVectorFieldRotationRateProps(UParticleModuleVectorFieldRotationRate ParticleModule,FVector OutRotationRate) {}
	public static void GetParticleModuleOrbitProps(UParticleModuleOrbit ParticleModule,byte OutChainMode,UDistribution OutOffsetAmount,FOrbitOptionsBP OutOffsetOptions,UDistribution OutRotationAmount,FOrbitOptionsBP OutRotationOptions,UDistribution OutRotationRateAmount,FOrbitOptionsBP OutRotationRateOptions) {}
	public static void GetParticleModuleSizeMultiplyLifeProps(UParticleModuleSizeMultiplyLife ParticleModule,UDistribution OutLifeMultiplier,bool OutMultiplyX,bool OutMultiplyY,bool OutMultiplyZ) {}
	public static void GetParticleModuleColorScaleOverLifeProps(UParticleModuleColorScaleOverLife ParticleModule,UDistribution OutColorScaleOverLife,UDistribution OutAlphaScaleOverLife,bool bOutEmitterTime) {}
	public static void GetParticleModuleRotationProps(UParticleModuleRotation ParticleModule,UDistribution OutStartRotation) {}
	public static void GetParticleModuleRotationRateProps(UParticleModuleRotationRate ParticleModule,UDistribution OutStartRotationRate) {}
	public static void GetParticleModuleMeshRotationRateProps(UParticleModuleMeshRotationRate ParticleModule,UDistribution OutStartRotationRate) {}
	public static void GetParticleModuleRotationOverLifetimeProps(UParticleModuleRotationOverLifetime ParticleModule,UDistribution OutRotationOverLife,bool bOutScale) {}
	public static void GetParticleModuleMeshRotationRateMultiplyLifeProps(UParticleModuleMeshRotationRateMultiplyLife ParticleModule,UDistribution OutLifeMultiplier) {}
	public static void GetParticleModulePivotOffsetProps(UParticleModulePivotOffset ParticleModule,FVector2D OutPivotOffset) {}
	public static void GetParticleModuleSubUVProps(UParticleModuleSubUV ParticleModule,USubUVAnimation OutAnimation,UDistribution OutSubImageIndex,bool bOutUseRealTime) {}
	public static void GetParticleModuleCameraOffsetProps(UParticleModuleCameraOffset ParticleModule,UDistribution OutCameraOffset,bool bOutSpawnTimeOnly,byte OutUpdateMethod) {}
	public static void GetParticleModuleSubUVMovieProps(UParticleModuleSubUVMovie ParticleModule,bool bOutUseEmitterTime,UDistribution OutFrameRate,int OutStartingFrame) {}
	public static void GetParticleModuleParameterDynamicProps(UParticleModuleParameterDynamic ParticleModule,TArray<FEmitterDynamicParameterBP> OutDynamicParams,bool bOutUsesVelocity) {}
	public static void GetParticleModuleAccelerationDragProps(UParticleModuleAccelerationDrag ParticleModule,UDistribution OutDragCoefficientRaw) {}
	public static void GetParticleModuleAccelerationDragScaleOverLifeProps(UParticleModuleAccelerationDragScaleOverLife ParticleModule,UDistribution OutDragScaleRaw) {}
	public static void GetParticleModuleAccelerationProps(UParticleModuleAcceleration ParticleModule,UDistribution OutAcceleration,bool bOutApplyOwnerScale) {}
	public static void GetParticleModuleAccelerationOverLifetimeProps(UParticleModuleAccelerationOverLifetime ParticleModule,UDistribution OutAccelOverLife) {}
	public static void GetParticleModuleTrailSourceProps(UParticleModuleTrailSource ParticleModule,byte OutSourceMethod,string OutSourceName,UDistribution OutSourceStrength,bool bOutLockSourceStrength,int OutSourceOffsetCount,TArray<FVector> OutSourceOffsetDefaults,byte OutSelectionMethod,bool bOutInheritRotation) {}
	public static void GetParticleModuleAttractorParticleProps(UParticleModuleAttractorParticle ParticleModule,string OutEmitterName,UDistribution OutRange,bool bOutStrengthByDistance,UDistribution OutStrength,bool bOutAffectBaseVelocity,byte OutSelectionMethod,bool bOutRenewSource,bool bOutInheritSourceVelocity) {}
	public static void GetParticleModuleAttractorPointProps(UParticleModuleAttractorPoint ParticleModule,UDistribution OutPosition,UDistribution OutRange,UDistribution OutStrength,bool boutStrengthByDistance,bool bOutAffectsBaseVelocity,bool bOutOverrideVelocity,bool bOutUseWorldSpacePosition,bool bOutPositiveX,bool bOutPositiveY,bool bOutPositiveZ,bool bOutNegativeX,bool bOutNegativeY,bool bOutNegativeZ) {}
	public static void GetParticleModuleAttractorLineProps(UParticleModuleAttractorLine ParticleModule,FVector OutStartPoint,FVector OutEndPoint,UDistribution OutRange,UDistribution OutStrength) {}
	public static void GetParticleModuleLocationDirectProps(UParticleModuleLocationDirect ParticleModule,UDistribution OutLocation,UDistribution OutLocationOffset,UDistribution OutScaleFactor) {}
	public static void GetParticleModuleLocationProps(UParticleModuleLocation ParticleModule,UDistribution OutStartLocation,float OutDistributeOverNPoints,float OutDistributeThreshold) {}
	public static void GetParticleModuleLocationBoneSocketProps(UParticleModuleLocationBoneSocket ParticleModule,byte OutSourceType,FVector OutUniversalOffset,TArray<FLocationBoneSocketInfoBP> OutSourceLocations,byte OutSelectionMethod,bool bOutUpdatePositionEachFrame,bool bOutOrientMeshEmitters,bool bOutInheritBoneVelocity,float OutInheritVelocityScale,string OutSkelMeshActorParamName,int OutNumPreSelectedIndices,USkeletalMesh OutEditorSkelMesh) {}
	public static void GetParticleModuleKillBoxProps(UParticleModuleKillBox ParticleModule,UDistribution OutLowerLeftCorner,UDistribution OutUpperRightCorner,bool bOutWorldSpaceCoords,bool bOutKillInside,bool bOutAxisAlignedAndFixedSize) {}
	public static void GetParticleModuleLightProps(UParticleModuleLight ParticleModule,bool bOutUseInverseSquaredFalloff,bool bOutAffectsTranslucency,bool bOutPreviewLightRadius,float OutSpawnFraction,UDistribution OutColorScaleOverLife,UDistribution OutBrightnessOverLife,UDistribution OutRadiusScale,UDistribution OutLightExponent,FLightingChannels OutLightingChannels,float OutVolumetricScatteringIntensity,bool bOutHighQualityLights,bool bOutShadowCastingLights) {}
	public static void GetParticleModuleMeshMaterialProps(UParticleModuleMeshMaterial ParticleModule,TArray<UMaterialInterface> OutMeshMaterials) {}
	public static void SetMeshRendererMaterialOverridesFromCascade(UNiagaraMeshRendererProperties MeshRendererProps,TArray<UMaterialInterface> MeshMaterials) {}
	public static void GetDistributionMinMaxValues(UDistribution Distribution,bool bOutSuccess,FVector OutMinValue,FVector OutMaxValue) {}
	public static TArray<byte> GetDistributionLockedAxes(UDistribution Distribution) { return default; }
	public static void GetDistributionType(UDistribution Distribution,EDistributionType OutDistributionType,EDistributionValueType OutCascadeDistributionValueType) {}
	public static void GetFloatDistributionConstValues(UDistributionFloatConstant Distribution,float OutConstFloat) {}
	public static void GetVectorDistributionConstValues(UDistributionVectorConstant Distribution,FVector OutConstVector) {}
	public static void GetFloatDistributionUniformValues(UDistributionFloatUniform Distribution,float OutMin,float OutMax) {}
	public static void GetVectorDistributionUniformValues(UDistributionVectorUniform Distribution,FVector OutMin,FVector OutMax) {}
	public static void GetFloatDistributionConstCurveValues(UDistributionFloatConstantCurve Distribution,FInterpCurveFloat OutInterpCurveFloat) {}
	public static void GetVectorDistributionConstCurveValues(UDistributionVectorConstantCurve Distribution,FInterpCurveVector OutInterpCurveVector) {}
	public static void GetFloatDistributionUniformCurveValues(UDistributionFloatUniformCurve Distribution,FInterpCurveVector2D OutInterpCurveVector2D) {}
	public static void GetVectorDistributionUniformCurveValues(UDistributionVectorUniformCurve Distribution,FInterpCurveTwoVectors OutInterpCurveTwoVectors) {}
	public static void GetFloatDistributionParameterValues(UDistributionFloatParameterBase Distribution,string OutParameterName,float OutMinInput,float OutMaxInput,float OutMinOutput,float OutMaxOutput) {}
	public static void GetVectorDistributionParameterValues(UDistributionVectorParameterBase Distribution,string OutParameterName,FVector OutMinInput,FVector OutMaxInput,FVector OutMinOutput,FVector OutMaxOutput) {}
	public static TArray<FRichCurveKeyBP> KeysFromInterpCurveFloat(FInterpCurveFloat Curve) { return default; }
	public static TArray<FRichCurveKeyBP> KeysFromInterpCurveVector(FInterpCurveVector Curve,int ComponentIdx) { return default; }
	public static TArray<FRichCurveKeyBP> KeysFromInterpCurveVector2D(FInterpCurveVector2D Curve,int ComponentIdx) { return default; }
	public static TArray<FRichCurveKeyBP> KeysFromInterpCurveTwoVectors(FInterpCurveTwoVectors Curve,int ComponentIdx) { return default; }
}
