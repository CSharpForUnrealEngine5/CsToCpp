#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AttributeEditorTool.h")]
public partial class UAttributeEditorLightmapUVActions : UAttributeEditorActionPropertySet {
	///<summary>Whether or not Lightmap UVs are enabled in the Static Mesh Build Settings. Use the Static Mesh Editor to change this value.</summary>
	public bool bGenerateLightmapUVs;
	///<summary>Source UV channel used to compute Lightmap UVs. Use the Static Mesh Editor to change this value.</summary>
	public int SourceUVIndex;
	///<summary>Lightmap UVs are stored in this UV Channel. Use the Static Mesh Editor to change this value.</summary>
	public int DestinationUVIndex;
	///<summary>Enable</summary>
	public  void Enable() {}
	///<summary>Disable</summary>
	public  void Disable() {}
	///<summary>Reset Lightmap UV channels to Source Channel UV0 and Destination as UVMax+1</summary>
	public  void Reset() {}
}
