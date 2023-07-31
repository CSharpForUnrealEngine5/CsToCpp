#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/TypeData/ParticleModuleTypeDataBeam2.h")]
public partial class UParticleModuleTypeDataBeam2 : UParticleModuleTypeDataBase {
	///<summary>The method with which to form the beam(s). Must be one of the following:</summary>
	public EBeam2Method BeamMethod;
	///<summary>The number of times to tile the texture along each beam.</summary>
	public int TextureTile;
	///<summary>The distance per texture tile.</summary>
	public float TextureTileDistance;
	///<summary>The number of sheets to render</summary>
	public int Sheets;
	///<summary>The number of live beams</summary>
	public int MaxBeamCount;
	///<summary>The speed at which the beam should move from source to target when firing up.</summary>
	public float Speed;
	///<summary>Indicates whether the beam should be interpolated.</summary>
	public int InterpolationPoints;
	///<summary>If true, there will ALWAYS be a beam...</summary>
	public bool bAlwaysOn;
	///<summary>The approach to use for determining the Up vector(s) for the beam.</summary>
	public int UpVectorStepSize;
	///<summary>The name of the emitter to branch from (if mode is PEB2M_Branch)</summary>
	public string BranchParentName;
	///<summary>The distance along the X-axis to stretch the beam</summary>
	public FRawDistributionFloat Distance;
	///<summary>Tapering mode - one of the following:</summary>
	public EBeamTaperMethod TaperMethod;
	///<summary>Tapering factor, 0 = source of beam, 1 = target</summary>
	public FRawDistributionFloat TaperFactor;
	///<summary>Tapering scaling</summary>
	public FRawDistributionFloat TaperScale;
	///<summary>Beam Rendering Variables.</summary>
	public bool RenderGeometry;
	///<summary>RenderDirectLine</summary>
	public bool RenderDirectLine;
	///<summary>RenderLines</summary>
	public bool RenderLines;
	///<summary>RenderTessellation</summary>
	public bool RenderTessellation;
}
