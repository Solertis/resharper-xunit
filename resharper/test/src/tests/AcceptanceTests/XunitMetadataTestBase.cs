using System.Threading;
using JetBrains.Metadata.Reader.API;
using JetBrains.ProjectModel;
using JetBrains.ProjectModel.Impl;
using JetBrains.ReSharper.FeaturesTestFramework.UnitTesting;
using JetBrains.ReSharper.UnitTestFramework;
using JetBrains.Util;
using XunitContrib.Runner.ReSharper.UnitTestProvider;

namespace XunitContrib.Runner.ReSharper.Tests.AcceptanceTests
{
    public abstract class XunitMetadataTestBase : UnitTestMetadataTestBase
    {
        protected override void ExploreAssembly(IProject testProject, IMetadataAssembly metadataAssembly, IUnitTestElementsObserver add)
        {
            GetMetdataExplorer().ExploreAssembly(testProject, metadataAssembly, add, CancellationToken.None);
        }

        protected override string GetIdString(IUnitTestElement element)
        {
            return string.Format("{0}::{1}::{2}", element.Id.Provider.ID, element.Id.Project.GetPersistentID(), element.Id.Id);
        }

        private XunitTestMetadataExplorer GetMetdataExplorer()
        {
            var services = Solution.GetComponent<XunitServiceProvider>();
            return new XunitTestMetadataExplorer(new UnitTestElementFactory(services, null));
        }

        protected override void PrepareBeforeRun(IProject testProject)
        {
            foreach (var assembly in GetReferencedAssemblies(GetPlatformID()))
            {
                var location = FileSystemPath.Parse(assembly);
                var reference = ProjectToAssemblyReference.CreateFromLocation(testProject, location);
                ((ProjectImpl) testProject).DoAddReference(reference);

                if (location.IsAbsolute && location.ExistsFile)
                {
                    var localCopy = TestDataPath2.Combine(location.Name);
                    if (!localCopy.ExistsFile || localCopy.FileModificationTimeUtc < location.FileModificationTimeUtc)
                        location.CopyFile(localCopy, true);
                }
            }
        }
    }
}