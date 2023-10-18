namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshVertexPaintTool.h")]
public partial class UVertexPaintBasicProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Primary Brush Mode //UPROPERTY(EditAnywhere, Category = Brush2, meta = (DisplayName = &quot;Brush Type&quot;))</summary>
	public EMeshVertexPaintBrushType PrimaryBrushType;
	///<summary>Painting Operation to apply when left-clicking and dragging</summary>
	public EMeshVertexPaintInteractionType SubToolType;
	///<summary>The Color that will be assigned to painted triangle vertices</summary>
	public FLinearColor PaintColor;
	///<summary>Controls how painted Colors will be combined with the existing Colors</summary>
	public EMeshVertexPaintColorBlendMode BlendMode;
	///<summary>The Brush Operation that will be applied when holding the Shift key when in Painting</summary>
	public EMeshVertexPaintSecondaryActionType SecondaryActionType;
	///<summary>Color to set when using Erase brush</summary>
	public FLinearColor EraseColor;
	///<summary>Strength of Smooth Brush</summary>
	public float SmoothStrength;
	///<summary>Controls which Color Channels will be affected by Operations. Only enabled Channels are rendered.</summary>
	public FModelingToolsColorChannelFilter ChannelFilter;
	///<summary>Create Split Colors / Hard Color Edges at the borders of the painted area. Use Soften operations to un-split.</summary>
	public bool bHardEdges;
}
