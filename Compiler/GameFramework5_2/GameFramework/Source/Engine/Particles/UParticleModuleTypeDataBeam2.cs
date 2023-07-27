#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/TypeData/ParticleModuleTypeDataBeam2.h")]
public partial class UParticleModuleTypeDataBeam2 : UParticleModuleTypeDataBase {
// ParticleModuleTypeDataBeam2
	public EBeam2Method BeamMethod;
	public int TextureTile;
	public float TextureTileDistance;
	public int Sheets;
	public int MaxBeamCount;
	public float Speed;
	public int InterpolationPoints;
	public bool bAlwaysOn;
	public int UpVectorStepSize;
	public string BranchParentName;
	public FRawDistributionFloat Distance;
	public EBeamTaperMethod TaperMethod;
	public FRawDistributionFloat TaperFactor;
	public FRawDistributionFloat TaperScale;
	public bool RenderGeometry;
	public bool RenderDirectLine;
	public bool RenderLines;
	public bool RenderTessellation;
}
