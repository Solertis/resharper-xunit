using JetBrains.Application;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.FeaturesTestFramework.UnitTesting;
using JetBrains.ReSharper.Psi.Search;
using JetBrains.ReSharper.UnitTestFramework;
using XunitContrib.Runner.ReSharper.UnitTestProvider;

namespace XunitContrib.Runner.ReSharper.Tests.AcceptanceTests
{
    public abstract class XunitSourceTestBase : UnitTestSourceTestBase
    {
        protected override IUnitTestElementsSource FileExplorer
        {
            get
            {
                return new XunitTestElementsSource(Solution.GetComponent<XunitServiceProvider>(),
                    Solution.GetComponent<SearchDomainFactory>(),
                    Solution.GetComponent<IShellLocks>());
            }
        }

        protected override string GetIdString(IUnitTestElement element)
        {
            return string.Format("{0}::{1}::{2}", element.Id.Provider.ID, element.Id.Project.GetPersistentID(), element.Id.Id);
        }
    }
}