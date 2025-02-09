using System.Diagnostics;

namespace FSDProject.State
{
    public class NavState
    {
        private bool? isSidebarOpen;

        public event Action? OnChange;

        public bool Property
        {
            get => isSidebarOpen ?? false;
            set
            {
                isSidebarOpen = value;
                NotifyStateChanged();
            }
        }

        private void NotifyStateChanged() 
        {
            Debug.WriteLine("Nav State Changed" + Property);
            OnChange?.Invoke(); 
        }
    }
}
