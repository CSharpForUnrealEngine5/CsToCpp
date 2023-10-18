namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A C++ and Blueprint accessible library for converting fx type assets (Cascade and Niagara)</summary>
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
public partial class UFXConverterUtilitiesLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Generic Utilities</summary>
	public static string GetLongPackagePath(string InLongPackageName) { return default; }
	///<summary>Cascade Emitter and ParticleLodLevel Getters</summary>
	public static TArray<UParticleEmitter> GetCascadeSystemEmitters(UParticleSystem System) { return default; }
	///<summary>GetCascadeEmitterLodLevel</summary>
	public static UParticleLODLevel GetCascadeEmitterLodLevel(UParticleEmitter Emitter,int Idx) { return default; }
	///<summary>GetLodLevelIsEnabled</summary>
	public static bool GetLodLevelIsEnabled(UParticleLODLevel LodLevel) { return default; }
	///<summary>GetLodLevelModules</summary>
	public static TArray<UParticleModule> GetLodLevelModules(UParticleLODLevel LodLevel) { return default; }
	///<summary>GetLodLevelSpawnModule</summary>
	public static UParticleModuleSpawn GetLodLevelSpawnModule(UParticleLODLevel LodLevel) { return default; }
	///<summary>GetLodLevelRequiredModule</summary>
	public static UParticleModuleRequired GetLodLevelRequiredModule(UParticleLODLevel LodLevel) { return default; }
	///<summary>GetLodLevelTypeDataModule</summary>
	public static UParticleModuleTypeDataBase GetLodLevelTypeDataModule(UParticleLODLevel LodLevel) { return default; }
	///<summary>GetCascadeEmitterName</summary>
	public static FName GetCascadeEmitterName(UParticleEmitter Emitter) { return default; }
	///<summary>GetCascadeEmitterRenderMode</summary>
	public static int GetCascadeEmitterRenderMode(UParticleEmitter Emitter) { return default; }
	///<summary>Niagara Script and Script Input Helpers</summary>
	public static UNiagaraScriptConversionContext CreateScriptContext(FCreateScriptContextArgs Args) { return default; }
	///<summary>CreateAssetData</summary>
	public static FAssetData CreateAssetData(string InPath) { return default; }
	///<summary>CreateScriptInputLinkedParameter</summary>
	public static UNiagaraScriptConversionContextInput CreateScriptInputLinkedParameter(string ParameterNameString,ENiagaraScriptInputType InputType) { return default; }
	///<summary>CreateScriptInputFloat</summary>
	public static UNiagaraScriptConversionContextInput CreateScriptInputFloat(float Value) { return default; }
	///<summary>CreateScriptInputVec2</summary>
	public static UNiagaraScriptConversionContextInput CreateScriptInputVec2(FVector2D Value) { return default; }
	///<summary>CreateScriptInputVector</summary>
	public static UNiagaraScriptConversionContextInput CreateScriptInputVector(FVector Value) { return default; }
	///<summary>CreateScriptInputStruct</summary>
	public static UNiagaraScriptConversionContextInput CreateScriptInputStruct(UUserDefinedStruct Value) { return default; }
	///<summary>CreateScriptInputEnum</summary>
	public static UNiagaraScriptConversionContextInput CreateScriptInputEnum(string UserDefinedEnumAssetPath,string UserDefinedEnumValueNameString) { return default; }
	///<summary>CreateScriptInputInt</summary>
	public static UNiagaraScriptConversionContextInput CreateScriptInputInt(int Value) { return default; }
	///<summary>CreateScriptInputDynamic</summary>
	public static UNiagaraScriptConversionContextInput CreateScriptInputDynamic(UNiagaraScriptConversionContext Value,ENiagaraScriptInputType InputType) { return default; }
	///<summary>CreateScriptInputDI</summary>
	public static UNiagaraScriptConversionContextInput CreateScriptInputDI(UNiagaraDataInterface Value) { return default; }
	///<summary>CreateScriptInputBool</summary>
	public static UNiagaraScriptConversionContextInput CreateScriptInputBool(bool Value) { return default; }
	///<summary>CreateRibbonRendererProperties</summary>
	public static UNiagaraRibbonRendererProperties CreateRibbonRendererProperties() { return default; }
	///<summary>CreateMeshRendererProperties</summary>
	public static UNiagaraMeshRendererProperties CreateMeshRendererProperties() { return default; }
	///<summary>CreateLightRendererProperties</summary>
	public static UNiagaraLightRendererProperties CreateLightRendererProperties() { return default; }
	///<summary>CreateComponentRendererProperties</summary>
	public static UNiagaraComponentRendererProperties CreateComponentRendererProperties() { return default; }
	///<summary>Niagara DI Helpers</summary>
	public static UNiagaraDataInterfaceSkeletalMesh CreateSkeletalMeshDataInterface() { return default; }
	///<summary>CreateFloatCurveDI</summary>
	public static UNiagaraDataInterfaceCurve CreateFloatCurveDI(TArray<FRichCurveKeyBP> Keys) { return default; }
	///<summary>CreateVec2CurveDI</summary>
	public static UNiagaraDataInterfaceVector2DCurve CreateVec2CurveDI(TArray<FRichCurveKeyBP> X_Keys,TArray<FRichCurveKeyBP> Y_Keys) { return default; }
	///<summary>CreateVec3CurveDI</summary>
	public static UNiagaraDataInterfaceVectorCurve CreateVec3CurveDI(TArray<FRichCurveKeyBP> X_Keys,TArray<FRichCurveKeyBP> Y_Keys,TArray<FRichCurveKeyBP> Z_Keys) { return default; }
	///<summary>CreateVec4CurveDI</summary>
	public static UNiagaraDataInterfaceVector4Curve CreateVec4CurveDI(TArray<FRichCurveKeyBP> X_Keys,TArray<FRichCurveKeyBP> Y_Keys,TArray<FRichCurveKeyBP> Z_Keys,TArray<FRichCurveKeyBP> W_Keys) { return default; }
	///<summary>Niagara System and Emitter Helpers</summary>
	public static UNiagaraSystemConversionContext CreateSystemConversionContext(UNiagaraSystem InSystem) { return default; }
	///<summary>GetParticleModuleTypeDataGpuProps</summary>
	public static void GetParticleModuleTypeDataGpuProps(UParticleModuleTypeDataGpu ParticleModule) {}
	///<summary>GetParticleModuleTypeDataMeshProps</summary>
	public static void GetParticleModuleTypeDataMeshProps(UParticleModuleTypeDataMesh ParticleModule,UStaticMesh OutMesh,float OutLODSizeScale,bool bOutUseStaticMeshLODs,bool bOutCastShadows,bool bOutDoCollisions,EMeshScreenAlignment OutMeshAlignment,bool bOutOverrideMaterial,bool bOutOverrideDefaultMotionBlurSettings,bool bOutEnableMotionBlur,UDistribution OutRollPitchYawRange,EParticleAxisLock OutAxisLockOption,bool bOutCameraFacing,EMeshCameraFacingUpAxis OutCameraFacingUpAxisOption_DEPRECATED,EMeshCameraFacingOptions OutCameraFacingOption,bool bOutApplyParticleRotationAsSpin,bool bOutFacingCameraDirectionRatherThanPosition,bool bOutCollisionsConsiderParticleSize) {}
	///<summary>GetParticleModuleTypeDataRibbonClass</summary>
	public static UClass GetParticleModuleTypeDataRibbonClass() { return default; }
	///<summary>GetParticleModuleTypeDataRibbonProps</summary>
	public static void GetParticleModuleTypeDataRibbonProps(UParticleModuleTypeDataRibbon ParticleModule,int OutMaxTessellationBetweenParticles,int OutSheetsPerTrail,int OutMaxTrailCount,int OutMaxParticleInTrailCount,bool bOutDeadTrailsOnDeactivate,bool bOutClipSourceSegment,bool bOutEnablePreviousTangentRecalculation,bool bOutTangentRecalculationEveryFrame,bool bOutSpawnInitialParticle,ETrailsRenderAxisOption OutRenderAxis,float OutTangentSpawningScalar,bool bOutRenderGeometry,bool bOutRenderSpawnPoints,bool bOutRenderTangents,bool bOutRenderTessellation,float OutTilingDistance,float OutDistanceTessellationStepSize,bool bOutEnableTangentDiffInterpScale,float OutTangentTessellationScalar) {}
	///<summary>GetParticleModuleSpawnProps</summary>
	public static void GetParticleModuleSpawnProps(UParticleModuleSpawn ParticleModuleSpawn,UDistribution OutRate,UDistribution OutRateScale,EParticleBurstMethod OutBurstMethod,TArray<FParticleBurstBlueprint> OutBurstList,UDistribution OutBurstScale,bool bOutApplyGlobalSpawnRateScale,bool bOutProcessSpawnRate,bool bOutProcessSpawnBurst) {}
	///<summary>GetParticleModuleSpawnPerUnitProps</summary>
	public static void GetParticleModuleSpawnPerUnitProps(UParticleModuleSpawnPerUnit ParticleModule,float OutUnitScalar,float OutMovementTolerance,UDistribution OutSpawnPerUnit,float OutMaxFrameDistance,bool bOutIgnoreSpawnRateWhenMoving,bool bOutIgnoreMovementAlongX,bool bOutIgnoreMovementAlongY,bool bOutIgnoreMovementAlongZ,bool bOutProcessSpawnRate,bool bOutProcessBurstList) {}
	///<summary>GetParticleModuleRequiredPerRendererProps</summary>
	public static void GetParticleModuleRequiredPerRendererProps(UParticleModuleRequired ParticleModuleRequired,UMaterialInterface OutMaterialInterface,EParticleScreenAlignment OutScreenAlignment,int OutSubImages_Horizontal,int OutSubImages_Vertical,EParticleSortMode OutSortMode,EParticleSubUVInterpMethod OutInterpolationMethod,byte bOutRemoveHMDRoll,float OutMinFacingCameraBlendDistance,float OutMaxFacingCameraBlendDistance,UTexture2D OutCutoutTexture,ESubUVBoundingVertexCount OutBoundingMode,EOpacitySourceMode OutOpacitySourceMode,EEmitterNormalsMode OutEmitterNormalsMode,float OutAlphaThreshold) {}
	///<summary>GetParticleModuleRequiredPerModuleProps</summary>
	public static void GetParticleModuleRequiredPerModuleProps(UParticleModuleRequired ParticleModuleRequired,bool bOutOrbitModuleAffectsVelocityAlignment,float OutRandomImageTime,int OutRandomImageChanges,bool bOutOverrideSystemMacroUV,FVector OutMacroUVPosition,float OutMacroUVRadius) {}
	///<summary>GetParticleModuleRequiredPerEmitterProps</summary>
	public static void GetParticleModuleRequiredPerEmitterProps(UParticleModuleRequired ParticleModuleRequired,FVector OutEmitterOrigin,FRotator OutEmitterRotation,bool bOutUseLocalSpace,bool bOutKillOnDeactivate,bool bOutKillOnCompleted,bool bOutUseLegacyEmitterTime,bool bOutEmitterDurationUseRange,float OutEmitterDuration,float OutEmitterDurationLow,bool bOUtEmitterDelayUseRange,bool bOutDelayFirstLoopOnly,float OutEmitterDelay,float OutEmitterDelayLow,bool bOutDurationRecalcEachLoop,int OutEmitterLoops) {}
	///<summary>GetParticleModuleColorProps</summary>
	public static void GetParticleModuleColorProps(UParticleModuleColor ParticleModule,UDistribution OutStartColor,UDistribution OutStartAlpha,bool bOutClampAlpha) {}
	///<summary>GetParticleModuleColorOverLifeProps</summary>
	public static void GetParticleModuleColorOverLifeProps(UParticleModuleColorOverLife ParticleModule,UDistribution OutColorOverLife,UDistribution OutAlphaOverLife,bool bOutClampAlpha) {}
	///<summary>GetParticleModuleLifetimeProps</summary>
	public static void GetParticleModuleLifetimeProps(UParticleModuleLifetime ParticleModule,UDistribution OutLifetime) {}
	///<summary>GetParticleModuleSizeProps</summary>
	public static void GetParticleModuleSizeProps(UParticleModuleSize ParticleModule,UDistribution OutStartSize) {}
	///<summary>GetParticleModuleVelocityProps</summary>
	public static void GetParticleModuleVelocityProps(UParticleModuleVelocity ParticleModule,UDistribution OutStartVelocity,UDistribution OutStartVelocityRadial,bool bOutInWorldSpace,bool bOutApplyOwnerScale) {}
	///<summary>GetParticleModuleVelocityOverLifetimeProps</summary>
	public static void GetParticleModuleVelocityOverLifetimeProps(UParticleModuleVelocityOverLifetime ParticleModule,UDistribution OutVelOverLife,bool bOutAbsolute,bool bOutInWorldSpace,bool bOutApplyOwnerScale) {}
	///<summary>GetParticleModuleConstantAccelerationProps</summary>
	public static void GetParticleModuleConstantAccelerationProps(UParticleModuleAccelerationConstant ParticleModule,FVector OutConstAcceleration) {}
	///<summary>GetParticleModuleLocationPrimitiveSphereProps</summary>
	public static void GetParticleModuleLocationPrimitiveSphereProps(UParticleModuleLocationPrimitiveSphere ParticleModule,UDistribution OutStartRadius,bool bOutPositiveX,bool bOutPositiveY,bool bOutPositiveZ,bool bOutNegativeX,bool bOutNegativeY,bool bOutNegativeZ,bool bOutSurfaceOnly,bool bOutVelocity,UDistribution OutVelocityScale,UDistribution OutStartLocation) {}
	///<summary>GetParticleModuleLocationPrimitiveCylinderProps</summary>
	public static void GetParticleModuleLocationPrimitiveCylinderProps(UParticleModuleLocationPrimitiveCylinder ParticleModule,bool bOutRadialVelocity,UDistribution OutStartRadius,UDistribution OutStartHeight,CylinderHeightAxis OutHeightAxis,bool bOutPositiveX,bool bOutPositiveY,bool bOutPositiveZ,bool bOutNegativeX,bool bOutNegativeY,bool bOutNegativeZ,bool bOutSurfaceOnly,bool bOutVelocity,UDistribution OutVelocityScale,UDistribution OutStartLocation) {}
	///<summary>GetParticleModuleOrientationAxisLockProps</summary>
	public static void GetParticleModuleOrientationAxisLockProps(UParticleModuleOrientationAxisLock ParticleModule,EParticleAxisLock OutLockAxisFlags) {}
	///<summary>GetParticleModuleVelocityInheritParentProps</summary>
	public static void GetParticleModuleVelocityInheritParentProps(UParticleModuleVelocityInheritParent ParticleModule,UDistribution OutScale,bool bOutInWorldSpace,bool bOutApplyOwnerScale) {}
	///<summary>GetParticleModuleMeshRotationProps</summary>
	public static void GetParticleModuleMeshRotationProps(UParticleModuleMeshRotation ParticleModule,UDistribution OutStartRotation,bool bOutInheritParentRotation) {}
	///<summary>GetParticleModuleCollisionProps</summary>
	public static void GetParticleModuleCollisionProps(UParticleModuleCollision ParticleModule,UDistribution OutDampingFactor,UDistribution OutDampingFactorRotation,UDistribution OutMaxCollisions,EParticleCollisionComplete OutCollisionCompleteOption,TArray<EObjectTypeQuery> OutCollisionTypes,bool bOutApplyPhysics,bool bOutIgnoreTriggerVolumes,UDistribution OutParticleMass,float OutDirScalar,bool bOutPawnsDoNotDecrementCount,bool bOutOnlyVerticalNormalsDecrementCount,float OutVerticalFudgeFactor,UDistribution OutDelayAmount,bool bOutDropDetail,bool bOutCollideOnlyIfVisible,bool bOutIgnoreSourceActor,float OutMaxCollisionDistance) {}
	///<summary>GetParticleModuleSizeScaleProps</summary>
	public static void GetParticleModuleSizeScaleProps(UParticleModuleSizeScale ParticleModule,UDistribution OutSizeScale) {}
	///<summary>GetParticleModuleSizeScaleBySpeedProps</summary>
	public static void GetParticleModuleSizeScaleBySpeedProps(UParticleModuleSizeScaleBySpeed ParticleModule,FVector2D OutSpeedScale,FVector2D OutMaxScale) {}
	///<summary>GetParticleModuleVectorFieldLocalProps</summary>
	public static void GetParticleModuleVectorFieldLocalProps(UParticleModuleVectorFieldLocal ParticleModule,UVectorField OutVectorField,FVector OutRelativeTranslation,FRotator OutRelativeRotation,FVector OutRelativeScale3D,float OutIntensity,float OutTightness,bool bOutIgnoreComponentTransform,bool bOutTileX,bool bOutTileY,bool bOutTileZ,bool bOutUseFixDT) {}
	///<summary>GetParticleModuleVectorFieldRotationRateProps</summary>
	public static void GetParticleModuleVectorFieldRotationRateProps(UParticleModuleVectorFieldRotationRate ParticleModule,FVector OutRotationRate) {}
	///<summary>GetParticleModuleOrbitProps</summary>
	public static void GetParticleModuleOrbitProps(UParticleModuleOrbit ParticleModule,EOrbitChainMode OutChainMode,UDistribution OutOffsetAmount,FOrbitOptionsBP OutOffsetOptions,UDistribution OutRotationAmount,FOrbitOptionsBP OutRotationOptions,UDistribution OutRotationRateAmount,FOrbitOptionsBP OutRotationRateOptions) {}
	///<summary>GetParticleModuleSizeMultiplyLifeProps</summary>
	public static void GetParticleModuleSizeMultiplyLifeProps(UParticleModuleSizeMultiplyLife ParticleModule,UDistribution OutLifeMultiplier,bool OutMultiplyX,bool OutMultiplyY,bool OutMultiplyZ) {}
	///<summary>GetParticleModuleColorScaleOverLifeProps</summary>
	public static void GetParticleModuleColorScaleOverLifeProps(UParticleModuleColorScaleOverLife ParticleModule,UDistribution OutColorScaleOverLife,UDistribution OutAlphaScaleOverLife,bool bOutEmitterTime) {}
	///<summary>GetParticleModuleRotationProps</summary>
	public static void GetParticleModuleRotationProps(UParticleModuleRotation ParticleModule,UDistribution OutStartRotation) {}
	///<summary>GetParticleModuleRotationRateProps</summary>
	public static void GetParticleModuleRotationRateProps(UParticleModuleRotationRate ParticleModule,UDistribution OutStartRotationRate) {}
	///<summary>GetParticleModuleMeshRotationRateProps</summary>
	public static void GetParticleModuleMeshRotationRateProps(UParticleModuleMeshRotationRate ParticleModule,UDistribution OutStartRotationRate) {}
	///<summary>GetParticleModuleRotationOverLifetimeProps</summary>
	public static void GetParticleModuleRotationOverLifetimeProps(UParticleModuleRotationOverLifetime ParticleModule,UDistribution OutRotationOverLife,bool bOutScale) {}
	///<summary>GetParticleModuleMeshRotationRateMultiplyLifeProps</summary>
	public static void GetParticleModuleMeshRotationRateMultiplyLifeProps(UParticleModuleMeshRotationRateMultiplyLife ParticleModule,UDistribution OutLifeMultiplier) {}
	///<summary>GetParticleModulePivotOffsetProps</summary>
	public static void GetParticleModulePivotOffsetProps(UParticleModulePivotOffset ParticleModule,FVector2D OutPivotOffset) {}
	///<summary>GetParticleModuleSubUVProps</summary>
	public static void GetParticleModuleSubUVProps(UParticleModuleSubUV ParticleModule,USubUVAnimation OutAnimation,UDistribution OutSubImageIndex,bool bOutUseRealTime) {}
	///<summary>GetParticleModuleCameraOffsetProps</summary>
	public static void GetParticleModuleCameraOffsetProps(UParticleModuleCameraOffset ParticleModule,UDistribution OutCameraOffset,bool bOutSpawnTimeOnly,EParticleCameraOffsetUpdateMethod OutUpdateMethod) {}
	///<summary>GetParticleModuleSubUVMovieProps</summary>
	public static void GetParticleModuleSubUVMovieProps(UParticleModuleSubUVMovie ParticleModule,bool bOutUseEmitterTime,UDistribution OutFrameRate,int OutStartingFrame) {}
	///<summary>GetParticleModuleParameterDynamicProps</summary>
	public static void GetParticleModuleParameterDynamicProps(UParticleModuleParameterDynamic ParticleModule,TArray<FEmitterDynamicParameterBP> OutDynamicParams,bool bOutUsesVelocity) {}
	///<summary>GetParticleModuleAccelerationDragProps</summary>
	public static void GetParticleModuleAccelerationDragProps(UParticleModuleAccelerationDrag ParticleModule,UDistribution OutDragCoefficientRaw) {}
	///<summary>GetParticleModuleAccelerationDragScaleOverLifeProps</summary>
	public static void GetParticleModuleAccelerationDragScaleOverLifeProps(UParticleModuleAccelerationDragScaleOverLife ParticleModule,UDistribution OutDragScaleRaw) {}
	///<summary>GetParticleModuleAccelerationProps</summary>
	public static void GetParticleModuleAccelerationProps(UParticleModuleAcceleration ParticleModule,UDistribution OutAcceleration,bool bOutApplyOwnerScale) {}
	///<summary>GetParticleModuleAccelerationOverLifetimeProps</summary>
	public static void GetParticleModuleAccelerationOverLifetimeProps(UParticleModuleAccelerationOverLifetime ParticleModule,UDistribution OutAccelOverLife) {}
	///<summary>GetParticleModuleTrailSourceProps</summary>
	public static void GetParticleModuleTrailSourceProps(UParticleModuleTrailSource ParticleModule,ETrail2SourceMethod OutSourceMethod,FName OutSourceName,UDistribution OutSourceStrength,bool bOutLockSourceStrength,int OutSourceOffsetCount,TArray<FVector> OutSourceOffsetDefaults,EParticleSourceSelectionMethod OutSelectionMethod,bool bOutInheritRotation) {}
	///<summary>GetParticleModuleAttractorParticleProps</summary>
	public static void GetParticleModuleAttractorParticleProps(UParticleModuleAttractorParticle ParticleModule,FName OutEmitterName,UDistribution OutRange,bool bOutStrengthByDistance,UDistribution OutStrength,bool bOutAffectBaseVelocity,EAttractorParticleSelectionMethod OutSelectionMethod,bool bOutRenewSource,bool bOutInheritSourceVelocity) {}
	///<summary>GetParticleModuleAttractorPointProps</summary>
	public static void GetParticleModuleAttractorPointProps(UParticleModuleAttractorPoint ParticleModule,UDistribution OutPosition,UDistribution OutRange,UDistribution OutStrength,bool boutStrengthByDistance,bool bOutAffectsBaseVelocity,bool bOutOverrideVelocity,bool bOutUseWorldSpacePosition,bool bOutPositiveX,bool bOutPositiveY,bool bOutPositiveZ,bool bOutNegativeX,bool bOutNegativeY,bool bOutNegativeZ) {}
	///<summary>GetParticleModuleAttractorLineProps</summary>
	public static void GetParticleModuleAttractorLineProps(UParticleModuleAttractorLine ParticleModule,FVector OutStartPoint,FVector OutEndPoint,UDistribution OutRange,UDistribution OutStrength) {}
	///<summary>GetParticleModuleLocationDirectProps</summary>
	public static void GetParticleModuleLocationDirectProps(UParticleModuleLocationDirect ParticleModule,UDistribution OutLocation,UDistribution OutLocationOffset,UDistribution OutScaleFactor) {}
	///<summary>GetParticleModuleLocationProps</summary>
	public static void GetParticleModuleLocationProps(UParticleModuleLocation ParticleModule,UDistribution OutStartLocation,float OutDistributeOverNPoints,float OutDistributeThreshold) {}
	///<summary>GetParticleModuleLocationBoneSocketProps</summary>
	public static void GetParticleModuleLocationBoneSocketProps(UParticleModuleLocationBoneSocket ParticleModule,ELocationBoneSocketSource OutSourceType,FVector OutUniversalOffset,TArray<FLocationBoneSocketInfoBP> OutSourceLocations,ELocationBoneSocketSelectionMethod OutSelectionMethod,bool bOutUpdatePositionEachFrame,bool bOutOrientMeshEmitters,bool bOutInheritBoneVelocity,float OutInheritVelocityScale,FName OutSkelMeshActorParamName,int OutNumPreSelectedIndices,USkeletalMesh OutEditorSkelMesh) {}
	///<summary>GetParticleModuleKillBoxProps</summary>
	public static void GetParticleModuleKillBoxProps(UParticleModuleKillBox ParticleModule,UDistribution OutLowerLeftCorner,UDistribution OutUpperRightCorner,bool bOutWorldSpaceCoords,bool bOutKillInside,bool bOutAxisAlignedAndFixedSize) {}
	///<summary>GetParticleModuleLightProps</summary>
	public static void GetParticleModuleLightProps(UParticleModuleLight ParticleModule,bool bOutUseInverseSquaredFalloff,bool bOutAffectsTranslucency,bool bOutPreviewLightRadius,float OutSpawnFraction,UDistribution OutColorScaleOverLife,UDistribution OutBrightnessOverLife,UDistribution OutRadiusScale,UDistribution OutLightExponent,FLightingChannels OutLightingChannels,float OutVolumetricScatteringIntensity,bool bOutHighQualityLights,bool bOutShadowCastingLights) {}
	///<summary>GetParticleModuleMeshMaterialProps</summary>
	public static void GetParticleModuleMeshMaterialProps(UParticleModuleMeshMaterial ParticleModule,TArray<UMaterialInterface> OutMeshMaterials) {}
	///<summary>SetMeshRendererMaterialOverridesFromCascade</summary>
	public static void SetMeshRendererMaterialOverridesFromCascade(UNiagaraMeshRendererProperties MeshRendererProps,TArray<UMaterialInterface> MeshMaterials) {}
	///<summary>Cascade Distribution Getters</summary>
	public static void GetDistributionMinMaxValues(UDistribution Distribution,bool bOutSuccess,FVector OutMinValue,FVector OutMaxValue) {}
	///<summary>GetDistributionLockedAxes</summary>
	public static TArray<EDistributionVectorLockFlags> GetDistributionLockedAxes(UDistribution Distribution) { return default; }
	///<summary>GetDistributionType</summary>
	public static void GetDistributionType(UDistribution Distribution,EDistributionType OutDistributionType,EDistributionValueType OutCascadeDistributionValueType) {}
	///<summary>GetFloatDistributionConstValues</summary>
	public static void GetFloatDistributionConstValues(UDistributionFloatConstant Distribution,float OutConstFloat) {}
	///<summary>GetVectorDistributionConstValues</summary>
	public static void GetVectorDistributionConstValues(UDistributionVectorConstant Distribution,FVector OutConstVector) {}
	///<summary>GetFloatDistributionUniformValues</summary>
	public static void GetFloatDistributionUniformValues(UDistributionFloatUniform Distribution,float OutMin,float OutMax) {}
	///<summary>GetVectorDistributionUniformValues</summary>
	public static void GetVectorDistributionUniformValues(UDistributionVectorUniform Distribution,FVector OutMin,FVector OutMax) {}
	///<summary>GetFloatDistributionConstCurveValues</summary>
	public static void GetFloatDistributionConstCurveValues(UDistributionFloatConstantCurve Distribution,FInterpCurveFloat OutInterpCurveFloat) {}
	///<summary>GetVectorDistributionConstCurveValues</summary>
	public static void GetVectorDistributionConstCurveValues(UDistributionVectorConstantCurve Distribution,FInterpCurveVector OutInterpCurveVector) {}
	///<summary>GetFloatDistributionUniformCurveValues</summary>
	public static void GetFloatDistributionUniformCurveValues(UDistributionFloatUniformCurve Distribution,FInterpCurveVector2D OutInterpCurveVector2D) {}
	///<summary>GetVectorDistributionUniformCurveValues</summary>
	public static void GetVectorDistributionUniformCurveValues(UDistributionVectorUniformCurve Distribution,FInterpCurveTwoVectors OutInterpCurveTwoVectors) {}
	///<summary>GetFloatDistributionParameterValues</summary>
	public static void GetFloatDistributionParameterValues(UDistributionFloatParameterBase Distribution,FName OutParameterName,float OutMinInput,float OutMaxInput,float OutMinOutput,float OutMaxOutput) {}
	///<summary>GetVectorDistributionParameterValues</summary>
	public static void GetVectorDistributionParameterValues(UDistributionVectorParameterBase Distribution,FName OutParameterName,FVector OutMinInput,FVector OutMaxInput,FVector OutMinOutput,FVector OutMaxOutput) {}
	///<summary>Cascade curve helpers</summary>
	public static TArray<FRichCurveKeyBP> KeysFromInterpCurveFloat(FInterpCurveFloat Curve) { return default; }
	///<summary>KeysFromInterpCurveVector</summary>
	public static TArray<FRichCurveKeyBP> KeysFromInterpCurveVector(FInterpCurveVector Curve,int ComponentIdx) { return default; }
	///<summary>KeysFromInterpCurveVector2D</summary>
	public static TArray<FRichCurveKeyBP> KeysFromInterpCurveVector2D(FInterpCurveVector2D Curve,int ComponentIdx) { return default; }
	///<summary>KeysFromInterpCurveTwoVectors</summary>
	public static TArray<FRichCurveKeyBP> KeysFromInterpCurveTwoVectors(FInterpCurveTwoVectors Curve,int ComponentIdx) { return default; }
}
