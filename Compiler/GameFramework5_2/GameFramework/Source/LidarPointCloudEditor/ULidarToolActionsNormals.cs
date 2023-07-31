#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloudEditorTools.h")]
public partial class ULidarToolActionsNormals : UInteractiveToolPropertySet {
	///<summary>Higher values will generally result in more accurate calculations, at the expense of time</summary>
	public int Quality;
	///<summary>Higher values are less susceptible to noise, but will most likely lose finer details, especially around hard edges.</summary>
	public float NoiseTolerance;
	///<summary>CalculateNormals</summary>
	public  void CalculateNormals() {}
}
