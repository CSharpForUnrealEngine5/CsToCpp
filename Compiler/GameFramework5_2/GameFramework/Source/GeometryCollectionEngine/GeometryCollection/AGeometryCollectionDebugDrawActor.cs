#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/GeometryCollectionDebugDrawActor.h")]
public partial class AGeometryCollectionDebugDrawActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Warning message to explain that the debug draw properties have no effect until starting playing/simulating.</summary>
	public FGeometryCollectionDebugDrawWarningMessage WarningMessage_DEPRECATED;
	///<summary>Picking tool used to select a rigid body id.</summary>
	public FGeometryCollectionDebugDrawActorSelectedRigidBody SelectedRigidBody_DEPRECATED;
	///<summary>Show debug visualization for the rest of the geometry collection related to the current rigid body id selection.</summary>
	public bool bDebugDrawWholeCollection;
	///<summary>Show debug visualization for the top level node rather than the bottom leaf nodes of a cluster&#39;s hierarchy. * Only affects Clustering and Geometry visualization.</summary>
	public bool bDebugDrawHierarchy;
	///<summary>Show debug visualization for all clustered children associated to the current rigid body id selection.</summary>
	public bool bDebugDrawClustering;
	///<summary>Geometry visibility setting. Select the part of the geometry to hide in order to better visualize the debug information.</summary>
	public EGeometryCollectionDebugDrawActorHideGeometry HideGeometry;
	///<summary>Display the selected rigid body&#39;s id.</summary>
	public bool bShowRigidBodyId;
	///<summary>Show the selected rigid body&#39;s collision volume.</summary>
	public bool bShowRigidBodyCollision;
	///<summary>Show the selected rigid body&#39;s collision volume at the origin, in local space.</summary>
	public bool bCollisionAtOrigin;
	///<summary>Show the selected rigid body&#39;s transform.</summary>
	public bool bShowRigidBodyTransform;
	///<summary>Show the selected rigid body&#39;s inertia tensor box.</summary>
	public bool bShowRigidBodyInertia;
	///<summary>Show the selected rigid body&#39;s linear and angular velocity.</summary>
	public bool bShowRigidBodyVelocity;
	///<summary>Show the selected rigid body&#39;s applied force and torque.</summary>
	public bool bShowRigidBodyForce;
	///<summary>Show the selected rigid body&#39;s on screen text information.</summary>
	public bool bShowRigidBodyInfos;
	///<summary>Show the transform index for the selected rigid body&#39;s associated cluster nodes.</summary>
	public bool bShowTransformIndex;
	///<summary>Show the transform for the selected rigid body&#39;s associated cluster nodes.</summary>
	public bool bShowTransform;
	///<summary>Show a link from the selected rigid body&#39;s associated cluster nodes to their parent&#39;s nodes.</summary>
	public bool bShowParent;
	///<summary>Show the hierarchical level for the selected rigid body&#39;s associated cluster nodes.</summary>
	public bool bShowLevel;
	///<summary>Show the connectivity edges for the selected rigid body&#39;s associated cluster nodes.</summary>
	public bool bShowConnectivityEdges;
	///<summary>Show the geometry index for the selected rigid body&#39;s associated geometries.</summary>
	public bool bShowGeometryIndex;
	///<summary>Show the geometry transform for the selected rigid body&#39;s associated geometries.</summary>
	public bool bShowGeometryTransform;
	///<summary>Show the bounding box for the selected rigid body&#39;s associated geometries.</summary>
	public bool bShowBoundingBox;
	///<summary>Show the faces for the selected rigid body&#39;s associated geometries.</summary>
	public bool bShowFaces;
	///<summary>Show the face indices for the selected rigid body&#39;s associated geometries.</summary>
	public bool bShowFaceIndices;
	///<summary>Show the face normals for the selected rigid body&#39;s associated geometries.</summary>
	public bool bShowFaceNormals;
	///<summary>Enable single face visualization for the selected rigid body&#39;s associated geometries.</summary>
	public bool bShowSingleFace;
	///<summary>The index of the single face to visualize.</summary>
	public int SingleFaceIndex;
	///<summary>Show the vertices for the selected rigid body&#39;s associated geometries.</summary>
	public bool bShowVertices;
	///<summary>Show the vertex indices for the selected rigid body&#39;s associated geometries.</summary>
	public bool bShowVertexIndices;
	///<summary>Show the vertex normals for the selected rigid body&#39;s associated geometries.</summary>
	public bool bShowVertexNormals;
	///<summary>Adapt visualization depending of the cluster nodes&#39; hierarchical level.</summary>
	public bool bUseActiveVisualization;
	///<summary>Thickness of points when visualizing vertices.</summary>
	public float PointThickness;
	///<summary>Thickness of lines when visualizing faces, normals, ...etc.</summary>
	public float LineThickness;
	///<summary>Draw shadows under the displayed text.</summary>
	public bool bTextShadow;
	///<summary>Scale of the font used to display text.</summary>
	public float TextScale;
	///<summary>Scale factor used for visualizing normals.</summary>
	public float NormalScale;
	///<summary>Scale of the axis used for visualizing all transforms.</summary>
	public float AxisScale;
	///<summary>Size of arrows used for visualizing normals, breaking information, ...etc.</summary>
	public float ArrowScale;
	///<summary>Color used for the visualization of the rigid body ids.</summary>
	public FColor RigidBodyIdColor;
	///<summary>Scale for rigid body transform visualization.</summary>
	public float RigidBodyTransformScale;
	///<summary>Color used for collision primitives visualization.</summary>
	public FColor RigidBodyCollisionColor;
	///<summary>Color used for the visualization of the rigid body inertia tensor box.</summary>
	public FColor RigidBodyInertiaColor;
	///<summary>Color used for rigid body velocities visualization.</summary>
	public FColor RigidBodyVelocityColor;
	///<summary>Color used for rigid body applied force and torque visualization.</summary>
	public FColor RigidBodyForceColor;
	///<summary>Color used for the visualization of the rigid body infos.</summary>
	public FColor RigidBodyInfoColor;
	///<summary>Color used for the visualization of the transform indices.</summary>
	public FColor TransformIndexColor;
	///<summary>Scale for cluster transform visualization.</summary>
	public float TransformScale;
	///<summary>Color used for the visualization of the levels.</summary>
	public FColor LevelColor;
	///<summary>Color used for the visualization of the link from the parents.</summary>
	public FColor ParentColor;
	///<summary>Line thickness used for the visualization of the rigid clustering connectivity edges.</summary>
	public float ConnectivityEdgeThickness;
	///<summary>Color used for the visualization of the geometry indices.</summary>
	public FColor GeometryIndexColor;
	///<summary>Scale for geometry transform visualization.</summary>
	public float GeometryTransformScale;
	///<summary>Color used for the visualization of the bounding boxes.</summary>
	public FColor BoundingBoxColor;
	///<summary>Color used for the visualization of the faces.</summary>
	public FColor FaceColor;
	///<summary>Color used for the visualization of the face indices.</summary>
	public FColor FaceIndexColor;
	///<summary>Color used for the visualization of the face normals.</summary>
	public FColor FaceNormalColor;
	///<summary>Color used for the visualization of the single face.</summary>
	public FColor SingleFaceColor;
	///<summary>Color used for the visualization of the vertices.</summary>
	public FColor VertexColor;
	///<summary>Color used for the visualization of the vertex indices.</summary>
	public FColor VertexIndexColor;
	///<summary>Color used for the visualization of the vertex normals.</summary>
	public FColor VertexNormalColor;
	///<summary>Display icon in the editor.</summary>
	public UBillboardComponent SpriteComponent;
}
