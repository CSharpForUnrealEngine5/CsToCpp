namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloudEditorTools.h")]
public partial class ULidarToolActionsNormals : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Higher values will generally result in more accurate calculations, at the expense of time</summary>
	public int Quality;
	///<summary>Higher values are less susceptible to noise, but will most likely lose finer details, especially around hard edges.</summary>
	public float NoiseTolerance;
	///<summary>CalculateNormals</summary>
	public void CalculateNormals() {}
}
