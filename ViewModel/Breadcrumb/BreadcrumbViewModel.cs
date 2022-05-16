namespace sga_stif.ViewModel.Breadcrumb
{
    public class BreadcrumbViewModel
    {

        public string Text { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public bool Active { get; set; }

        public BreadcrumbViewModel() { }

        public BreadcrumbViewModel(string text, string action, string controller, bool active)
        {
            this.Text = text;
            this.Action = action;
            this.Controller = controller;
            this.Active = active;
        }
        
    }
}