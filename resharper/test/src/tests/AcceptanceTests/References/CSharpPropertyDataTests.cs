﻿using JetBrains.ReSharper.FeaturesTestFramework.Completion;
using JetBrains.ReSharper.Psi.Resolve;
using JetBrains.ReSharper.TestFramework;
using NUnit.Framework;
using XunitContrib.Runner.ReSharper.UnitTestProvider.PropertyData;

namespace XunitContrib.Runner.ReSharper.Tests.AcceptanceTests.References
{
    [Xunit1TestReferences]
    [IncludeMsCorLib]
    public class CSharpPropertyDataTests : ReferenceTestBase
    {
        // How does ReferenceTestBase work?
        // Override RelativeTestDataPath to tell it where the data + gold files are
        // Override Format to provide formatting for reference targets that aren't paths, modules or declared elements
        // Override PresentExtraInfo to provide more details about an IReference
        // Implement AcceptReference to allow filtering of references to output
        // Override BeforeTestStarted + AfterTestFinished for anything else
        // Uses ReferenceTestUtil.ReferenceCollector to collect references + sort
        // Uses TestFrameworkUtil.DumpReferencePositions to add references into original text, e.g. |System|(0).Xml
        // Loops over all references, resolves and outputs result + reference target (using Format)
        // also calls PresentExtraInfo + dumps candidate info

        protected override string RelativeTestDataPath { get { return @"References\"; } }

        protected override bool AcceptReference(IReference reference)
        {
            return reference is PropertyDataReference;
        }

        [Test] public void PropertyDataInSameClass() { DoNamedTest(); }
        [Test] public void PropertyDataInOtherClass() { DoNamedTest(); }
        [Test] public void PropertyDataFromDerivedClass() { DoNamedTest(); }
        [Test] public void InvalidPropertyDataProperties() { DoNamedTest(); }
        [Test] public void UnresolvedPropertyData() { DoNamedTest(); }
    }

    [Xunit1TestReferences]
    public class CSharpPropertyDataCompletionTests : CodeCompletionTestBase
    {
        protected override string RelativeTestDataPath { get { return @"References\CodeCompletion\"; } }

        protected override bool CheckAutomaticCompletionDefault()
        {
            return true;
        }

        protected override CodeCompletionTestType TestType
        {
            get { return CodeCompletionTestType.List; }
        }

        [Test] public void ListsPropertyDataCandidatesInSameClass() { DoNamedTest();}
        [Test] public void ListsPropertyDataCandidatesInOtherClass() { DoNamedTest();}
    }
}