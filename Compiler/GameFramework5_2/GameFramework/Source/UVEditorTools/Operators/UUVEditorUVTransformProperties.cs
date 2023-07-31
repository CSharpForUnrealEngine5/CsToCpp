#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UV Transform Settings</summary>
[CppInclude("Operators/UVEditorUVTransformOp.h")]
public partial class UUVEditorUVTransformProperties : UUVEditorUVTransformPropertiesBase {
	///<summary>Scale applied to UVs, potentially non-uniform</summary>
	public FVector2D Scale;
	///<summary>Rotation applied to UVs after scaling, specified in degrees</summary>
	public float Rotation;
	///<summary>Translation applied to UVs, and after scaling and rotation</summary>
	public FVector2D Translation;
	///<summary>Translation applied to UVs, and after scaling and rotation</summary>
	public EUVEditorTranslationMode TranslationMode;
	///<summary>Transformation origin mode used for scaling and rotation</summary>
	public EUVEditorPivotType PivotMode;
	///<summary>Manual Transformation origin point</summary>
	public FVector2D ManualPivot;
	///<summary>QuickTranslateOffset</summary>
	public float QuickTranslateOffset;
	///<summary>QuickRotationOffset</summary>
	public float QuickRotationOffset;
	///<summary>QuickTranslation</summary>
	public FVector2D QuickTranslation;
	///<summary>QuickRotation</summary>
	public float QuickRotation;
}
