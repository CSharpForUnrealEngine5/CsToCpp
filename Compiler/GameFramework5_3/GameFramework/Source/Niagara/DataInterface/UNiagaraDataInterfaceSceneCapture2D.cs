namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface which can control or read from a scene capture component.</summary>
[CppInclude("DataInterface/NiagaraDataInterfaceSceneCapture2D.h")]
public partial class UNiagaraDataInterfaceSceneCapture2D : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>How should we find the scene capture component to use?</summary>
	public ENDISceneCapture2DSourceMode SourceMode;
	///<summary>When valid should point to either a Scene Capture 2D Component or a Scene Capture 2D Actor.</summary>
	public FNiagaraUserParameterBinding SceneCaptureUserParameter;
	///<summary>When enabled the scene capture component will be automatically moved to the location of the NiagaraComponent with an optional offset.</summary>
	public bool bAutoMoveWithComponent;
	///<summary>Should we apply the auto move offset in local or world space?</summary>
	public ENDISceneCapture2DOffsetMode AutoMoveOffsetLocationMode;
	///<summary>Location offset when applying auto movement.</summary>
	public FVector AutoMoveOffsetLocation;
	///<summary>How we should apply the rotation</summary>
	public ENDISceneCapture2DOffsetMode AutoMoveOffsetRotationMode;
	///<summary>Rotation offset when applying auto movement.</summary>
	public FRotator AutoMoveOffsetRotation;
	///<summary>ManagedCaptureSource</summary>
	public ESceneCaptureSource ManagedCaptureSource;
	///<summary>ManagedTextureSize</summary>
	public FIntPoint ManagedTextureSize;
	///<summary>ManagedTextureFormat</summary>
	public ETextureRenderTargetFormat ManagedTextureFormat;
	///<summary>ManagedProjectionType</summary>
	public ECameraProjectionMode ManagedProjectionType;
	///<summary>ManagedFOVAngle</summary>
	public float ManagedFOVAngle;
	///<summary>ManagedOrthoWidth</summary>
	public float ManagedOrthoWidth;
	///<summary>bManagedCaptureEveryFrame</summary>
	public bool bManagedCaptureEveryFrame;
	///<summary>bManagedCaptureOnMovement</summary>
	public bool bManagedCaptureOnMovement;
	///<summary>ManagedShowOnlyActors</summary>
	public TArray<AActor> ManagedShowOnlyActors;
	///<summary>Allows you to set the show only actors when Niagara manages the component.  If Niagara does not manage the component use the regular BP methods.</summary>
	public static void SetSceneCapture2DManagedShowOnlyActors(UNiagaraComponent NiagaraSystem,FName ParameterName,TArray<AActor> ShowOnlyActors) {}
	///<summary>ManagedCaptureComponents</summary>
	public TMap<ulong,USceneCaptureComponent2D> ManagedCaptureComponents;
}
