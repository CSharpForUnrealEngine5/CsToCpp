namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassRepresentationFragments.h")]
public partial struct FMassRepresentationParameters {
	public UClass RepresentationActorManagementClass;
	public EMassRepresentationType LODRepresentation;
	public bool bKeepLowResActors;
	public bool bKeepActorExtraFrame;
	public bool bSpreadFirstVisualizationUpdate;
	public string WorldPartitionGridNameContainingCollision;
	public float NotVisibleUpdateRate;
	public EMassRepresentationType CachedDefaultRepresentationType;
	public UMassRepresentationActorManagement CachedRepresentationActorManagement;
}
