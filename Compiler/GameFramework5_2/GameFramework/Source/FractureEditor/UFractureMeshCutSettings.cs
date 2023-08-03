#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolMeshCut.h")]
public partial class UFractureMeshCutSettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Static Mesh Actor to be used as a cutting surface. For best results, use a closed, watertight mesh</summary>
	public TLazyObjectPtr<AStaticMeshActor> CuttingActor;
	///<summary>How to arrange the mesh cuts in space</summary>
	public EMeshCutDistribution CutDistribution;
	///<summary>Number of meshes to random scatter</summary>
	public int NumberToScatter;
	///<summary>Number of meshes to add to grid in X</summary>
	public int GridX;
	///<summary>Number of meshes to add to grid in Y</summary>
	public int GridY;
	///<summary>Number of meshes to add to grid in Z</summary>
	public int GridZ;
	///<summary>Magnitude of random displacement to cutting meshes</summary>
	public float Variability;
	///<summary>Minimum scale factor to apply to cutting meshes. A random scale will be chosen between Min and Max</summary>
	public float MinScaleFactor;
	///<summary>Maximum scale factor to apply to cutting meshes. A random scale will be chosen between Min and Max</summary>
	public float MaxScaleFactor;
	///<summary>Whether to randomly vary the orientation of the cutting meshes</summary>
	public bool bRandomOrientation;
	///<summary>Roll will be chosen between -Range and +Range</summary>
	public float RollRange;
	///<summary>Pitch will be chosen between -Range and +Range</summary>
	public float PitchRange;
	///<summary>Yaw will be chosen between -Range and +Range</summary>
	public float YawRange;
}
