#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Operators/UVEditorUVTransformOp.h")]
///<summary>UV Transform Settings</summary>
public partial class UUVEditorUVTransformProperties : UUVEditorUVTransformPropertiesBase {
// UVEditorUVTransformProperties
	public FVector2D Scale;
	public float Rotation;
	public FVector2D Translation;
	public EUVEditorTranslationMode TranslationMode;
	public EUVEditorPivotType PivotMode;
	public FVector2D ManualPivot;
	public float QuickTranslateOffset;
	public float QuickRotationOffset;
	public FVector2D QuickTranslation;
	public float QuickRotation;
}
