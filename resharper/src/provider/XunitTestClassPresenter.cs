using JetBrains.CommonControls;
using JetBrains.Metadata.Reader.API;
using JetBrains.ReSharper.Feature.Services.Tree;
using JetBrains.ReSharper.UnitTestFramework;
using JetBrains.TreeModels;
using JetBrains.UI.TreeView;

namespace XunitContrib.Runner.ReSharper.UnitTestProvider
{
    [UnitTestPresenter]
    public class XunitTestClassPresenter : IUnitTestPresenter
    {
        private readonly TreePresenter treePresenter;

        public XunitTestClassPresenter()
        {
            treePresenter = new TreePresenter();
        }

        public void Present(IUnitTestElement element, IPresentableItem item, TreeModelNode node, PresentationState state)
        {
            // We only want to customise how class elements are displayed. If the
            // parent node isn't a namespace, and isn't the namespace of the class,
            // display the class as namespace qualified
            if (!(element is XunitTestClassElement))
                return;
            treePresenter.UpdateItem(element, node, item, state);
        }

        private class TreePresenter : TreeModelBrowserPresenter
        {
            public TreePresenter()
            {
                Present(new PresentationCallback<TreeModelNode, IPresentableItem, XunitTestClassElement>(PresentClassElement));
            }

            protected override bool IsNaturalParent(object parentValue, object childValue)
            {
                var unitTestNamespace = parentValue as IUnitTestElementNamespace;
                var classElement = childValue as XunitTestClassElement;
                if (classElement != null && unitTestNamespace != null)
                    return unitTestNamespace.QualifiedName.Equals(classElement.GetNamespace().QualifiedName);
                return base.IsNaturalParent(parentValue, childValue);
            }

            protected override object Unwrap(object value)
            {
                var element = value as XunitTestClassElement;
                if (element != null)
                    value = element.GetDeclaredElement();

                return base.Unwrap(value);
            }

            private void PresentClassElement(XunitTestClassElement value, IPresentableItem item, TreeModelNode modelNode, PresentationState state)
            {
                if (IsNodeParentNatural(modelNode, value))
                    item.RichText = value.TypeName.ShortName;
                else if (string.IsNullOrEmpty(value.TypeName.GetNamespaceName()))
                    item.RichText = value.TypeName.ShortName;
                else
                    item.RichText = string.Format("{0}.{1}", value.TypeName.GetNamespaceName(), value.TypeName.ShortName);
            }
        }
    }
}
