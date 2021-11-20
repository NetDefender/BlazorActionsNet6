namespace BlazorActionsNet6.Shared
{
    public sealed partial class MainLayout
    {
        #region fields
        private bool _collapsed;
        #endregion

        #region methods
        private void OnCollapse(bool collapsed)
        {
            _collapsed = collapsed;
        }
        #endregion
    }
}