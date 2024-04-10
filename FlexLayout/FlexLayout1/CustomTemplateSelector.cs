using System;
namespace FlexLayout1
{
    public class CustomTemplateSelector : DataTemplateSelector
    {
        public DataTemplate? TagTemplate { get; set; }

        public DataTemplate? DefaultTemplate { get; set; }

        protected override DataTemplate? OnSelectTemplate(object item, BindableObject container)
        {
            switch (item)
            {
                case Tags _:
                    return TagTemplate;
                default:
                    return DefaultTemplate;
            }
        }
    }
}

