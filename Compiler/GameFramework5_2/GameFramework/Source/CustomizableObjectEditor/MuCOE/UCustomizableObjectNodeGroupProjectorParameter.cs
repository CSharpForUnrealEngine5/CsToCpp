#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeGroupProjectorParameter.h")]
public partial class UCustomizableObjectNodeGroupProjectorParameter : UCustomizableObjectNodeProjectorParameter {
	///<summary>Only used when connected to a Group node. Specifies which material channel in the Group node&#39;s child material nodes will be connected to the projection.</summary>
	public string MaterialChannelNameToConnect;
	///<summary>Only used when connected to a Group node. Specifies which material channel will be used to mask out the projection.</summary>
	public string MaskedOutAreaMaterialChannelName;
	///<summary>Reference Texture used to decide the texture properties of the mutable-generated textures</summary>
	public UTexture2D ReferenceTexture;
	///<summary>ProjectionTextureSize</summary>
	public int ProjectionTextureSize;
	///<summary>Specifies at which LOD level the projection texture will not be used and possibly save memory. A negative value means they will never be dropped.</summary>
	public int DropProjectionTextureAtLOD;
	///<summary>If true, projection textures will be shared between LODs of the same object, and will save memory. Only use if all the LODs share the same UV layout.</summary>
	public bool bShareProjectionTexturesBetweenLODs;
	///<summary>OptionImages</summary>
	public TArray<FGroupProjectorParameterImage> OptionImages;
	///<summary>OptionPoses</summary>
	public TArray<FGroupProjectorParameterPose> OptionPoses;
	///<summary>Name of the column in the Option Images Data Table with the additional option images, (UTexture2D assets).</summary>
	public string DataTableTextureColumnName;
	///<summary>Table where additional option images besides Option Images are read. The elements in this table have priority</summary>
	public UDataTable OptionImagesDataTable;
	///<summary>AlternateProjectionResolutionStateName</summary>
	public string AlternateProjectionResolutionStateName;
	///<summary>AlternateProjectionResolutionFactor</summary>
	public float AlternateProjectionResolutionFactor;
	///<summary>UVLayout</summary>
	public int UVLayout;
	///<summary>ImagePin</summary>
	public FEdGraphPinReference ImagePin;
}
